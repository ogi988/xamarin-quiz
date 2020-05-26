using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using webApi.Models;

namespace webApi.Controllers
{
    public class QuestionsController : ApiController
    {
        private ApplicationDbContext _context;
        public QuestionsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Authorize]
        public IEnumerable<Question> GetQuestions()
        {
            return _context.Questions.ToList();
        }

       

       
        
    }
}