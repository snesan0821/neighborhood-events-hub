using System.Web.Http;

namespace CalendarFeedService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // enable attribute routing
            config.MapHttpAttributeRoutes();

            // fallback conventional route
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
