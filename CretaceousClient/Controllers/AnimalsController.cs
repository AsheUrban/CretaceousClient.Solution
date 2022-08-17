using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CretaceousClient.Models;

namespace CretaceousClient.Controllers
{
  // [Route("api/[controller]")]
  // [ApiController]
  public class AnimalsController : Controller
  {
    // private readonly CretaceousClientContext _context;

    // public AnimalsController(CretaceousClientContext context)
    // {
    //     _context = context;
    // }

      public IActionResult Index()
      {
        var allAnimals = Animal.GetAnimals();
        return View(allAnimals);
      }
    }
	}