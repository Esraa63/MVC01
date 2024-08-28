namespace MVC01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseRouting();
           
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Home", async context =>
                {
                    await context.Response.WriteAsync("you are in home page");
                });
                endpoints.MapGet("/Products/{id}", async context =>
                {
                    int id = Convert.ToInt32( context.Request.RouteValues["id"]);
                       await context.Response.WriteAsync($"you are in products page with id => {id}");
                });
                endpoints.MapGet("/Books/{id}/{author}", async context =>
                {
                    int id = Convert.ToInt32(context.Request.RouteValues["id"]);
                    string author = context.Request.RouteValues["author"].ToString();
                    await context.Response.WriteAsync($"you are in books page with id => {id} and author => {author}");
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
