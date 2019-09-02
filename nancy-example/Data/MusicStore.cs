using qa_services.nancy_example.Models;
using System.Collections.Generic;

namespace qa_services.nancy_example.Data
{
    public class MusicStore
    {
        public MusicStore()
        {
            Guitars = new List<Guitar>
            {
                new Guitar { Id = 1, Type = "Classical", FretCount = 17, StringCount = 6, Price = 900.99 },
                new Guitar { Id = 2, Type = "Electric", FretCount = 22, StringCount = 6, Price = 2899.50 },
                new Guitar { Id = 3, Type = "Bass", FretCount = 22, StringCount = 5, Price = 1400.67 }
            };
        }

        public List<Guitar> Guitars { get; }
    }
}
