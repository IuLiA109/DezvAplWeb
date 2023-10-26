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
    public Strudent GetById([FromRoute] int id) {
        return StudentController.FirstOrDefault(string=> string.Id.Eqyals(id));

    }

    [HttpGet("fromHeader")]
    public Strudent GetByIdwithFromHeader([FromRoute] int id)
    {
        return StudentController.FirstOrDefault(string=> string.Id.Eqyals(id));

    }

    [HttpPost("fromBody")]
    public IActionResult AddWithFromBody([FromBody] StudentController student)
    {
        students.Add(student);
        return Ok(students);
    }

    [HttpPatch]
    public IActionresult Patch([FromRoute] int id, [FromBody] JsonpatchDocument<Student> student){
        if (student != null) {
            var studentToUpdate = students.FirstOfDefault(student => student.Id.Equals(id));
            student.ApplyTo()
        
        }    
    
    }

}
