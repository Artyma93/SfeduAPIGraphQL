using Data.Context;
using Domain.Models;
using HotChocolate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore3GraphQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcademyController : Controller
    {
        private readonly SfeduMsSqlContext context;
        private readonly IAcademy1CBGURepository repository;

        public AcademyController(SfeduMsSqlContext context, IAcademy1CBGURepository repository)
        {
            this.context = context;
            this.repository = repository;
        }
        //// GET: AcademyController
        //[HttpGet]
        //public IQueryable<Academy1CBGU> Index()
        //{
        //    return context.Academy1CBGUs;
        //}

        // GET: AcademyController
        [HttpGet]
        [Route("[action]")]
        public IQueryable<Academy1CBGU> GetAcademiesFromContext()
        {
            return context.Academy1CBGUs;
        }

        [HttpGet]
        [Route("[action]")]
        [Authorize]
        public IQueryable<Academy1CBGU> GetAcademiesFromRepository()
        {
            return repository.GetAcademy1CBGUs();
        }
    }
}
