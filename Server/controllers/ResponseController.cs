﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseController : ControllerBase
    {
        // GET: api/Response
        [HttpGet]
        public IEnumerable<Server.entities.response> Get()
        {
            var aList = new List<Server.entities.response>();

            for (int i = 1; i < 20; i++)
            {
                var oResponse = new Server.entities.response();

                oResponse.Id = i;
                oResponse.Text = "Respuesta" + i;

                aList.Add(oResponse);
            }

            return aList;
        }

        // GET: api/Response/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Response
        /*[HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Response/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
