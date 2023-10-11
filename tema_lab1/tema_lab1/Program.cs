using tema_lab1;
using System.Collections.Generic;

var mat1 = new Materie()
{
    Titlu = "SO",
    Durata = "2 ore"
};

var mat2 = new Materie()
{
    Titlu = "AF",
    Durata = "3 ore"
};

var mat3 = new Materie()
{
    Titlu = "PF",
    Durata = "1 ora"
};

var mat4 = new Materie()
{
    Titlu = "DAW",
    Durata = "2 ore"
};

var mat5 = new Materie()
{
    Titlu = "P&S",
    Durata = "4 ore"
};

var mat6 = new Materie()
{
    Titlu = "SGBD",
    Durata = "3 ore"
};

var stud1 = new Student() {
    Nume = "Tamas",
    Prenume = "Iulia",
    Varsta = 20,
    Materii = new List<Materie> { mat1, mat2, mat3}
};

var stud2 = new Student()
{
    Nume = "Boroica",
    Prenume = "Denisa",
    Varsta = 19,
    Materii = new List<Materie> { mat6, mat4, mat5 }
};

var stud3 = new Student()
{
    Nume = "Covrig",
    Prenume = "Larisa",
    Varsta = 21,
    Materii = new List<Materie> { mat3, mat4, mat1 }
};

var Studenti = new List<Student> { stud1, stud2, stud3};

foreach (Student stud in Studenti) 
{
    stud.Afisaree();
    Console.WriteLine('\n');
}

