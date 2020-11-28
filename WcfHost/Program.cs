using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using WcfRESTLibrary;

namespace WcfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost host = new WebServiceHost(typeof(Service1), new Uri("http://localhost:8080/"));
            var epoint = host.AddServiceEndpoint(typeof(IService1), new WebHttpBinding(), "");
            var sdb = host.Description.Behaviors.Find<ServiceDebugBehavior>();
            sdb.HttpHelpPageEnabled = false;

            host.Open();
            Console.WriteLine("Press ENTER to stop the service");
            Console.ReadLine();
            host.Close();
        }
    }
}
