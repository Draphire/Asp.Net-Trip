﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripTrackerBackService.Models;

namespace TripTrackerBackService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        public TripsController(Repository repository)
        {
            _repository = repository;
        }

        private Repository _repository; 

        // GET api/Trips
        [HttpGet]
        public ActionResult<IEnumerable<Trip>> Get()
        {
            return _repository.Get();
            //return new string[] { "value1", "value2" };
        }

        // GET api/Trips/5
        [HttpGet("{id}")]
        public ActionResult<Trip> Get(int id)
        {
            //return "value";
            return _repository.Get(id);
        }

        // POST api/Trips
        [HttpPost]
        public void Post([FromBody] Trip value)
        {
            _repository.Add(value);
        }

        // PUT api/Trips/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Trip value)
        {
            _repository.Update(value);
        }

        // DELETE api/Trips/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Remove(id);
        }
    }
}
