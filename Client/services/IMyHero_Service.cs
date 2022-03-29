using BlazorWebAssemblyApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyApp.Client.services
{
   public  interface IMyHero_Service
    {
        List<comic> Comics { get; set; }
        Task<List<MyHeros>> Getheros();
        Task GetComics();
        Task<MyHeros> Getherobyid(int id);
        Task<List<MyHeros>> CreateSuperHero(MyHeros hero);

    }
}
