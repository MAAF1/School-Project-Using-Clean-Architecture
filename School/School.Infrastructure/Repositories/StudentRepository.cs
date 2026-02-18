using Microsoft.EntityFrameworkCore;
using School.Domain.Entites;
using School.Infrastructure.Abstracts;
using School.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository  
    {
        #region Fields
        private readonly AppDbContext _context;
        #endregion

        #region Constructors
        public StudentRepository(AppDbContext context)
        { 
            _context = context;
        }
        #endregion

        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
