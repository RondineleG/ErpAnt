namespace ErpAnt.Server.Extensions
{
    public static class ServiceExtensions
    {
         public static void ConfigureCors(this IserviceCollection services)
         {

             services.AddCors(options =>
             {
                 options.AddPolicy("CorsPolicy",
                 builder => builder.AllowAnyOrigin()
                 .AllowMethod()
                 .AllowHeader());
             });

         }
            
    }
}