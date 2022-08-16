using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BooksUnitTest.Models;

namespace BooksUnitTest.Data
{
    public class BooksUnitTestContext : DbContext
    {
        public BooksUnitTestContext (DbContextOptions<BooksUnitTestContext> options)
            : base(options)
        {
        }

        public DbSet<BooksUnitTest.Models.Student> Student { get; set; } = default!;
    }
}
