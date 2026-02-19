using AutoMapper;
using School.Core.Features.Students.Queries.Results;
using School.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Mapping.Students.QueryMapping;

public partial class StudentProfile: Profile
{ 
    // Create the map the one you called in Core
    public StudentProfile() 
    {
        GetStudentListMapping();
    }
}
