using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    { 
        static void Main(string[] args)  
        {
            //create an instance of a BusinessLogic class 
            //BusinessLogic businessLogic = new BusinessLogic();

            ////use the instance to invoke a method inside the BusinessLogic class
            //businessLogic.ProcessData();

            var container = ContainerConfig.Configure(); //configures the container

            //set a new scope for instances being passed out
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
             
            Console.ReadLine();
        }
    }
}
