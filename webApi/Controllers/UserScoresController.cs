using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webApi.Models;

namespace webApi.Controllers
{
    public class UserScoresController : ApiController
    {
        private ApplicationDbContext _context;
        public UserScoresController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public IEnumerable<UserScore> GetUserScores()
        {
            return _context.UserScores.ToList();
        }

        [HttpPost]
        public IHttpActionResult CreateCustomer(UserScore userScore)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = new UserScore { Username = userScore.Username, Score = userScore.Score };
            _context.UserScores.Add(userScore);
            _context.SaveChanges();


            return Ok();
        }
    }
}
