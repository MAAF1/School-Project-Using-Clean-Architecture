using School.Domain.Entites;
using School.Infrastructure.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Abstracts
{
    public interface IStudentRepository: IGenericRepositoryAsync<Student>
    {
        public Task<List<Student>> GetStudentsListAsync();   
    }
}
 