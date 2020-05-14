using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Api.Models;

namespace Api.Data
{
    public class QuizContext : DbContext
    {
        public QuizContext() : base("DefaultConnection")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}