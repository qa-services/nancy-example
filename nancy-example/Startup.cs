using Microsoft.AspNetCore.Builder;
using Nancy;
using Nancy.Owin;

namespace qa_services.nancy_example
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(x => x.UseNancy());
        }
    }
}
