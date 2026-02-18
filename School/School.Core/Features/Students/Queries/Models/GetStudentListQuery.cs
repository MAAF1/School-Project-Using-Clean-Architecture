using System;
using System.Collections.Generic;
using MediatR;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Domain.Entites;

namespace School.Core.Features.Students.Queries.Models
{
    public class GetStudentListQuery : IRequest<List<Student>>
    {


    }
}
