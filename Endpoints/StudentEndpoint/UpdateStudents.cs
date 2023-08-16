using Ardalis.ApiEndpoints;
using EndPointsAPI.Ado;
using EndPointsAPI.ContextClass;
using EndPointsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EndPointsAPI.Endpoints.StudentEndpoint
{
    public class Updatereq
    {
        [FromRoute]
        public int Id { get; set; }
        [FromBody]
        public AdoStudents stu { get; set; }
    }
        public class UpdateStudents : EndpointBaseAsync.WithRequest<Updatereq>.WithActionResult<Student>
        {
            
            [HttpPut]
            [Route("Update")]

            public override async Task<ActionResult<Student>> HandleAsync(Updatereq request, CancellationToken cancellationToken = default)
            {
                StudentContext myContext = new();
                var student = myContext.Students.Find(request.Id);
                if (student is null)
                {
                    return Content("data not found!!");
                }
                else
                {
                    student.Name = request.stu.Name;
                    student.Email = request.stu.Email;
                    student.Address = request.stu.Address;
                    await myContext.SaveChangesAsync();
                    return Ok(student);
                }

            }
        }
    }

