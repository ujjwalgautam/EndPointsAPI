using Ardalis.ApiEndpoints;
using EndPointsAPI.ContextClass;
using EndPointsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EndPointsAPI.Endpoints.StudentEndpoint
{
    public class GetAllStudents : EndpointBaseSync.WithoutRequest.
        WithActionResult<List<Student>>
    {
        //private readonly StudentContext myContext;

        //public GetAllStudents(StudentContext context)
        //{
        //    myContext = context;
        //}


        [HttpGet]
        [Route("Students")]
        public override ActionResult<List<Student>> Handle()
        {
            StudentContext myContext = new();
            var stu = myContext.Students.ToList();
            if(stu.Count ==0) 
            {
                return Content("Empty data");
            }
            else
                return Ok(stu);
        }
    }
}
