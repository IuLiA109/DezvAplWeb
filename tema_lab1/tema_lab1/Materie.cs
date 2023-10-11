using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_lab1
{
    public class Materie
    {
        public string Titlu { get; set; }
        public string Durata { get; set; }

        public void Afisare() {
            Console.WriteLine($"Titlu: {Titlu}, Durata: {Durata}");
        }
    }
}
