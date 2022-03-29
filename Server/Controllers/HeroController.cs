using BlazorWebAssemblyApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        static List<comic> Comics = new List<comic>
        {
            new comic { Id=1,Name = "Marvel" },
            new comic { Id=2,Name = "Dc" }
           
        };
        static List<MyHeros> heroes = new List<MyHeros>
        {
            new MyHeros { Id=1,FirstName="Tony",LastName="Stark",HeroName="Ironman",Comic = Comics[0]},
             new MyHeros { Id=2,FirstName="peter",LastName="Parker",HeroName="Spidy",Comic = Comics[1]}
             
        };

        [HttpGet("Comics")]
        public async Task<IActionResult> GetComic()
        {
            return Ok(Comics);
        }

        [HttpGet]
        public async Task<IActionResult> Getheros()
        {
            return Ok( heroes);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetsingleHero(int id)
        {
            var hero =  heroes.FirstOrDefault(h => h.Id == id);
            if(hero==null)
            {
                return NotFound("hero not found");
            }
            else { return Ok(hero); }
        }
        public async Task<IActionResult> CreateSuperhero(MyHeros hero)
        {
            heroes.Add(hero);
            return Ok(heroes);  
        }

     }
}
