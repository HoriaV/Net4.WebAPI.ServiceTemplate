using System.Web.Http;

namespace Net4.WebAPI.ServiceTemplate.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}",
                defaults: new { controller = "Service" }
            );
            //config.Routes.MapHttpRoute(
            //    name: "SoapApi",
            //    routeTemplate: "{controller}/{action}",
            //    defaults: new { controller = "Service" }
            //);

        }
    }
}