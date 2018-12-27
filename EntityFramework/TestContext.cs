using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public class TestContext:DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {

        }
        

        public DbSet<Student> Students { get; set; }
    }
}
