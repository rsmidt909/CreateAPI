﻿using ApiCreation.AllowCrossSite;
using ApiCreation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;


namespace ApiCreation.Controllers
{
    [EnableCors(origins:"*", headers: "*", methods:"*")]
    public class MovieController : ApiController
    {

        public ApplicationDbContext db;
            public MovieController()
        {
            db = new ApplicationDbContext();
        }


        // GET api/<controller>
        [AllowCrossSite]
        public IEnumerable<Movie> GetAll()
        {
            List<Movie> thing = db.Movies.ToList();
            return thing;
        }
        //public Movie Get(string Title)
        //{
        //   Movie movie = db.Movies.Where(m=>m.Title == Title).ToArray();
        //    return movie;
        //}

        //GET api/<controller>/5
        [AllowCrossSite]
        public Movie Get(int id)
        {
            var movie = db.Movies.Find(id);
            return movie;
        }

        // POST api/<controller>
        [AllowCrossSite]
        public void Post([FromBody]Movie value)
        {

            if (value == null)
            {
                throw new Exception("That movie is empty");
            }
            db.Movies.Add(value);
            db.SaveChanges();

        }

        // PUT api/<controller>/5
        [AllowCrossSite]
        public void Put(int id, [FromBody]Movie value)
        {
            if (value == null)
            {
                throw new Exception("That movie is empty");
            }
            var movie = db.Movies.Find(id);
            movie = value;
            db.SaveChanges();
        }

        // DELETE api/<controller>/5
        [AllowCrossSite]
        public void Delete(int id)
        {
            var movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();

        }
    }
}