namespace MVC01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();
            app.UseRouting();

            #region
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("you are in home page");
            //    });
            //    endpoints.MapGet("/Products/{id?:int?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["id"];
            //        if (idData != null)
            //        {
            //            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //            await context.Response.WriteAsync($"you are in products page with id => {id}");
            //        }
            //        else
            //            await context.Response.WriteAsync("you are in products page");
            //    });
            //    endpoints.MapGet("/Books/{id}/{author:alpha:minlength(4):maxlength(6)}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //        string author = context.Request.RouteValues["author"].ToString();
            //        await context.Response.WriteAsync($"you are in books page with id => {id} and author => {author}");
            //    });
            //});
            //app.Run(async (HttpContext) =>
            //{
            //    await HttpContext.Response.WriteAsync("your requested page not found");
            //});
            #endregion

            app.MapControllerRoute(
                name: "default",
                pattern: "/{Controller=Home}/{action=Index}",
                defaults: new {Controller ="Home" , Action ="Index"}
                );
            app.Run();
        }
    }
}
