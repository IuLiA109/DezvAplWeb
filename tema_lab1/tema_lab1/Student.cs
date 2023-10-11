using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace tema_lab1
{
    public class Student
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }

        public List<Materie> Materii { get; set; }

        public void Afisaree()
        {
            Console.WriteLine($"Nume: {Nume}, Prenume: {Prenume}, Varsta: {Varsta}");
            if (Materii != null) 
            {
                Console.WriteLine("Materii: ");
                foreach (Materie mat in Materii) 
                { 
                    mat.Afisare();  

                }
            }
        }

    }
}
