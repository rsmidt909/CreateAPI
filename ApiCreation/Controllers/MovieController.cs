using ApiCreation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;

namespace ApiCreation.Controllers
{
    public class MovieController : ApiController
    {

        public ApplicationDbContext db;
            public MovieController()
        {
            db = new ApplicationDbContext();
        }


        // GET api/<controller>
        public IEnumerable<Movie> GetAll()
        {
            List<Movie> thing = db.Movies.ToList();
            return thing;
        }

        // GET api/<controller>/5
        public Movie Get(int id)
        {
            var movie = db.Movies.Find(id);
            return movie;
        }

        // POST api/<controller>
        public void Post([FromBody]Movie value)
        {

            //if(value == null)
            //{
            //    throw new Exception("That aint right punk");
            //}
            //db.Movies.Add(value);
            //db.SaveChanges();

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Movie value)
        {
            //var thing1 = db.Movies.Find(id);
            //thing1 = value;
            //db.SaveChanges();
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            //var thing1337 = db.Movies.Find(id);
            //db.Movies.Remove(thing1337);
            //db.SaveChanges();

        }
    }
}