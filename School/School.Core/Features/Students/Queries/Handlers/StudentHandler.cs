using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using School.Core.Features.Students.Queries.Models;
using School.Domain.Entites;
using School.Service.Abstracts;

namespace School.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler: IRequestHandler<GetStudentListQuery, List<Student>>
    {
        private readonly IStudentService _studentService;

        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cts)
        {
           return await _studentService.GetStudentsListAsync();
        }
    }
}
