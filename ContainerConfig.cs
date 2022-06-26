using Autofac;
using DemoLibrary;
using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // whenever you look for IBussinesLogic interface
            //return an instance of BusinnesLogic
            builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<Application>().As<IApplication>();



            //repeat the above for every class in the utilities folder
            //builder.RegisterType<DataAccess>().As<IDataAccess>();
            //builder.RegisterType<Logger>().As<ILogger>();

            //use the following approach if you have too many classes inside a folders
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                  .Where(x => x.Namespace.Contains("Utilities"))
                  .As(x => x.GetInterfaces().FirstOrDefault(i => i.Name == "I" + x.Name));

            return builder.Build();

        }
    }
}
