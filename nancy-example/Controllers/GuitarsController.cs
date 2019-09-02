using Nancy;
using qa_services.nancy_example.Data;
using System;
using System.Linq;

namespace qa_services.nancy_example.Controllers
{
    public sealed class GuitarsController : NancyModule
    {
        private readonly MusicStore _musicStore = new MusicStore();

        public GuitarsController()
        {
            Get("guitars/", parameters =>
            {
                Console.WriteLine("Received GET /guitars request.");
                return Response.AsJson(_musicStore.Guitars);
            });

            Get("guitars/{id:int}", parameters =>
            {
                Console.WriteLine($"Received GET /guitars/{parameters.id} request.");
                return Response.AsJson(_musicStore.Guitars.Where(g => g.Id == parameters.id));
            });
        }
    }
}
