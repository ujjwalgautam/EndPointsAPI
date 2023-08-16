using Ardalis.ApiEndpoints;
using EndPointsAPI.ContextClass;
using EndPointsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EndPointsAPI.Endpoints.StudentEndpoint
{
    public class DeleteStudents : EndpointBaseSync.WithRequest<int>.WithActionResult<Student>
    {
        [HttpDelete]
        [Route("Update")]
        public override ActionResult<Student> Handle(int request)
        {
            StudentContext myContext = new();
            var stu = myContext.Students.Find(request);
            if(stu is  null)
            {
                return Content("No data found!!");
            }
            else
            {
                myContext.Remove(stu);
                myContext.SaveChanges();
                return Ok(stu);
            }

        }
    }
}
