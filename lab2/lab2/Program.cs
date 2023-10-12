
using lab2;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

generic_Class<string> genericClassWithString = new()
{
    Value = "abc"


};

generic_Class<int> genericClassWithInt = new()
{
    Value = 123


};

Console.WriteLine(genericClassWithString.Value);
Console.WriteLine(genericClassWithInt.Value);


GenericMultiple<int, string> genericMulti = new() { 
    Key=456,
    Value="Value: 456"
};

string obj = JsonConvert.SerializeObject(genericMulti);
Console.WriteLine(obj);

Tuple<int, string, string> tuplu = new Tuple<int, string, string>(1, "abc", "val 1");
var tuplu2 = Tuple.Create(2, "deewd", "ddde 3");

int sum(int a, int b, int c = 10) 
{ 
    return a + b + c;   
}

Console.WriteLine(sum(1, 2)); //13

void sumref(int a, int b, ref int c)
{
    c = a + b;
}

int num = 2;
sumref(4, 5, ref num);
Console.WriteLine(num); 


void sumout(int a, int b, out int c) 
{
    c = a + b;

}

int c;
sumout(4, 4, out c);
Console.WriteLine(c);

var aobjclass = new { Title = "abc", Size = 23 };

//dynamic student = new {Lastname = }



