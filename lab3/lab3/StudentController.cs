using Microsoft.AspNetCore.Mvc;

namespace lab3
{
    public class StudentController
    {


    }

    public Student GetWithFilters(string name, int age) { 
        return 

    }

    [HttpGet("fromRouteWithId/{id}")]
    public Strudent GetById([FromRoute]int id) {
        return StudentController.FirstOrDefault(string=> string.Id.Eqyals(id));

    }

    [HttpGet("fromHeader")]
    public Strudent GetByIdwithFromHeader([FromRoute] int id)
    {
        return StudentController.FirstOrDefault(string=> string.Id.Eqyals(id));

    }


}
