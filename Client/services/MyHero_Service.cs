using BlazorWebAssemblyApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorWebAssemblyApp.Client.services
{
    public class MyHero_Service : IMyHero_Service
    {

        private readonly HttpClient ht;
        public MyHero_Service(HttpClient _ht)
        {
            ht = _ht;
        }

        public List<comic> Comics { get; set; } = new List<comic>();

        public async Task<List<MyHeros>> Getheros()
        {
            return await ht.GetFromJsonAsync<List<MyHeros>>("api/Hero");
        }

        public async Task<MyHeros> Getherobyid(int id)
        {
            return await ht.GetFromJsonAsync<MyHeros>($"api/Hero/{id}");   
        }

        public async Task<List<MyHeros>> CreateSuperHero(MyHeros hero)
        {
             var res = await ht.PostAsJsonAsync<MyHeros>($"api/Hero",hero);
            var hh = await res.Content.ReadFromJsonAsync<List<MyHeros>>();
            return hh;
        }

        public async Task GetComics()
        {
            Comics= await ht.GetFromJsonAsync<List<comic>>($"api/Hero/comics");
        }
    }
}
