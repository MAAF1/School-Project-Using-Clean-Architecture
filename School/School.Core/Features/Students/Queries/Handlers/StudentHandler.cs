using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using School.Core.Features.Students.Queries.Models;
using School.Core.Features.Students.Queries.Results;
using School.Domain.Entites;
using School.Service.Abstracts;
using School.Core.Bases;
namespace School.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler: ResponseHandler, IRequestHandler<GetStudentListQuery, Response<List<GetStudentListResponse>>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cts)
        {
           var studentList = await _studentService.GetStudentsListAsync();
            var StudentListMapper = _mapper.Map<List<GetStudentListResponse>>(studentList);

            return Success(StudentListMapper);
        }
    }
}
