using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11
{
    public class Film : IDisposable
    {
        public string Title { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }


        ~Film()
        {
            Console.WriteLine("Деструктор викликається для фільму: " + Title);
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose викликається для фільму: " + Title);
            GC.SuppressFinalize(this);
        }
    }
}
