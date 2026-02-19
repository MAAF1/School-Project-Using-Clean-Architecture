using Microsoft.EntityFrameworkCore;
using School.Domain.Entites;
using School.Infrastructure.Abstracts;
using School.Infrastructure.Data;
using School.Infrastructure.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Repositories
{
    public class StudentRepository :GenericRepositoryAsync<Student>, IStudentRepository  
    {
        #region Fields
        private readonly AppDbContext _context;
        private readonly DbSet<Student> _students;
        #endregion

        #region Constructors
        public StudentRepository(AppDbContext context) : base(context) 
        {
            _context = context;
            _students = context.Set<Student>();
        }
        #endregion

        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _students.Include(x => x.Department).ToListAsync();
         }
    }
}
