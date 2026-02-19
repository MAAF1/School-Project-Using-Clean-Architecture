using AutoMapper;
using School.Core.Features.Students.Queries.Results;
using School.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Mapping.Students.QueryMapping
{
    public partial class StudentProfile: Profile
    {

        public void GetStudentListMapping()
        {
            // src , dest
            CreateMap<Student, GetStudentListResponse>()
                .ForMember(des => des.DepartmentName, opt => opt.MapFrom(src => src.Department.DName));
        }

    }
}
