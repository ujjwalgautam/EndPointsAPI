using Ardalis.ApiEndpoints;
using EndPointsAPI.Ado;
using EndPointsAPI.ContextClass;
using EndPointsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EndPointsAPI.Endpoints.StudentEndpoint
{
    public class AddStudents : EndpointBaseSync.WithRequest<AdoStudents>.WithActionResult
    {
        [HttpPost]
        [Route("AddStudents")]
        public override ActionResult Handle(AdoStudents request)
        {
            StudentContext myContext = new();
            Student Stu=new Student();
            Stu.Address = request.Address;
            Stu.Email = request.Email;
            Stu.Name = request.Name;
            myContext.Students.Add(Stu);
            myContext.SaveChanges();
            return Ok(request);
        }

      
    }
}
