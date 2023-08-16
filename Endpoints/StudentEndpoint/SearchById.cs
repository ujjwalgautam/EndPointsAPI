using Ardalis.ApiEndpoints;
using EndPointsAPI.ContextClass;
using EndPointsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EndPointsAPI.Endpoints.StudentEndpoint
{
    public class SearchById : EndpointBaseSync.WithRequest<int>.WithActionResult<Student>
    {
        [HttpGet]
        [Route("SearchById")]
        public override ActionResult<Student> Handle(int request)
        {
            StudentContext myContext = new StudentContext();
            var data = myContext.Students.Find(request);
            if (data != null) 
            {
                return Ok(data);
            }
            else
            { return Content("Data with given Id not found"); }    
        }
    }
}
