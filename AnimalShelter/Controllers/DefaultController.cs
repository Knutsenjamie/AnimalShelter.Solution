using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiVersioning.Web.Contracts;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{

    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class DefaultController : ControllerBase
        {
            string[] authors = new string[]
            { "Jamie Knutsen" };
            [HttpGet]
            public IEnumerable<string> Get()
            {
                return authors;
            }
            
            [HttpGet("{id}")]
            [MapToApiVersion("1.0")]
            public string Get(int id)
            {
            return authors[id];
            }
        }
}