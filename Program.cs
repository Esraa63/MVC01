namespace MVC01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseRouting();
            app.Use(async (context, next) =>
            {
                Endpoint endpoint = context.GetEndpoint();
                if (endpoint is null)
                    await context.Response.WriteAsync("your requested page not found");
                await next();
            }
            
            );
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Home", async context =>
                {
                    await context.Response.WriteAsync("you are in home page");
                });
                endpoints.MapPost("/Products", async context =>
                {
                    await context.Response.WriteAsync("you are in products page");
                });
            });
            app.Run(async (HttpContext) =>
            {
                await HttpContext.Response.WriteAsync("your requested page not found");
            });
            app.Run();
        }
    }
}
