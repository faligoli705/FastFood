using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NHibernate.Cfg;
using NHibernate.Driver;
using NHibernate.Dialect;
using System;
using System.Collections.Generic;
 using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
 
namespace FastFood
{
    public class Program
    {
        public static void Main(string[] args)
        {             
            var cfg = new Configuration();
            cfg.DataBaseIntegration(x =>
            {
                x.ConnectionString = "Data Source=DESKTOP-9AQA9OL;Initial Catalog=FastFood;Integrated Security=false; User=sa; Password=123456;";
                x.Driver<SqlClientDriver>();
                x.Dialect<MsSql2012Dialect>();

            });
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
           var sessionFactory= cfg.BuildSessionFactory();
            using(var session= sessionFactory.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                //perform database logic
                tx.Commit();
            }


                CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

