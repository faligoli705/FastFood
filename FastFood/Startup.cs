

using FastFood.DataLayer.DataAccess;
using FastFood.DataLayer.Services.Interface;
using FastFood.DataLayer.Services.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;

namespace FastFood
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //var cfg = new Configuration();
            //cfg.DataBaseIntegration(x =>
            //{
            //    x.ConnectionString = Configuration.GetConnectionString("FastFoodConnection");
            //    x.Driver<SqlClientDriver>();
            //    x.Dialect<MsSql2012Dialect>();
            //});

            //cfg.AddAssembly(Assembly.GetExecutingAssembly());
            //var sessionFactory = cfg.BuildSessionFactory();
            //using (var session = sessionFactory.OpenSession())
            //using (var tx = session.BeginTransaction())
            //{
            //    tx.Commit();
            //}

            services.AddMvc();
            services.AddDbContext<FastFoodContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("FastFoodConnection"));
            });
            services.AddControllersWithViews();
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            //services.AddScoped<IStoreInvoicing, Factors>();
            services.AddTransient<IProduct, Products>();
            services.AddTransient<ICategory, Types>();
            services.AddTransient<ICustomer,Customers>();
             services.AddControllers();

            services.AddSwaggerGen(c =>
           {
               c.SwaggerDoc("v1", new OpenApiInfo { Title = "FastFood", Version = "v1" });
           });
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FastFood v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
