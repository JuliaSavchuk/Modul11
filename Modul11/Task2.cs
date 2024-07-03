using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11
{
    public class Play : IDisposable
    {
        public string Title { get; set; }
        public string Theater { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public List<string> Actors { get; set; }


        ~Play()
        {
            Console.WriteLine("Деструктор викликається для вистави: " + Title);
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose викликається для вистави: " + Title);
            GC.SuppressFinalize(this);
        }
    }

}
