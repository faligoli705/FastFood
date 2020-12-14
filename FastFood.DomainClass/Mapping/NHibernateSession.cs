using NHibernate;
 using System;
using System.Collections.Generic;
 using System.Text;

namespace FastFood.DomainClass.Mapping
{
   public class NHibernateSession
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\Mapping\hibernate.cfg.xml");
            configuration.Configure(configurationPath);
            var factorConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Mappings\Factors.hbm.xml");
            configuration.AddFile(factorConfigurationFile);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}
