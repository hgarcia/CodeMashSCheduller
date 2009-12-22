using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using CodeMashScheduller.Models;

namespace CodeMashScheduller
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Scheduller", action = "Index", id = "" }  // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
           // InitializeActiveRecord();
        }

        public static void InitializeActiveRecord()
        {
            if (ActiveRecordStarter.IsInitialized) return;
            var properties = new Dictionary<string,string>
                                 {
                                     {"connection.driver_class", "NHibernate.Driver.SqlClientDriver"},
                                     {"dialect", "NHibernate.Dialect.MsSql2005Dialect"},
                                     {"connection.provider", "NHibernate.Connection.DriverConnectionProvider"},
                                     {"proxyfactory.factory_class", "NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle"},
                                     {
                                         "connection.connection_string",
                                         @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Development\Code\Net3.5\CodeMashScheduller\CodeMashScheduller\App_Data\CodeMashScheduller.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
                                         }
                                 };

            var source = new InPlaceConfigurationSource();

            source.Add(typeof(ActiveRecordBase), properties);    
            ActiveRecordStarter.Initialize(source, typeof(Session),typeof(Speaker),typeof(Precompiler));
            
            try
            {
                ActiveRecordStarter.CreateSchema();
            }catch
            {
                ActiveRecordStarter.UpdateSchema();
            }
        }
    }
}