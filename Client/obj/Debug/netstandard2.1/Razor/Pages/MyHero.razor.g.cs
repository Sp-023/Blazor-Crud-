#pragma checksum "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\Pages\MyHero.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83b2b17d096e11d6ad6e0966ef87310679f18813"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebAssemblyApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\_Imports.razor"
using BlazorWebAssemblyApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\_Imports.razor"
using BlazorWebAssemblyApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\_Imports.razor"
using BlazorWebAssemblyApp.Client.services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\_Imports.razor"
using BlazorWebAssemblyApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MyHero")]
    public partial class MyHero : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>MyHero</h3>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\Pages\MyHero.razor"
 if (heroes.Count==0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "                ");
            __builder.AddMarkupContent(2, "<span>Loading heros..</span>\r\n");
#nullable restore
#line 11 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\Pages\MyHero.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "                ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n                    ");
            __builder.AddMarkupContent(7, @"<thead>
                        <tr>
                            <th>FirstName</th>
                            <th>LastName</th>
                            <th>HeroName</th>
                            <th>Comic</th>
                            <th></th>

                        </tr>
                        
                    </thead>
                    ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 27 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\Pages\MyHero.razor"
                         foreach (var hero in heroes)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                    ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                        ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 30 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\Pages\MyHero.razor"
                             hero.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 31 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\Pages\MyHero.razor"
                             hero.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 32 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\Pages\MyHero.razor"
                             hero.HeroName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 33 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\Pages\MyHero.razor"
                             hero.Comic.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\Pages\MyHero.razor"
                                                                      (() => ShowHero(hero.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Show");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 38 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\Pages\MyHero.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 42 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\Pages\MyHero.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "\r\n");
            __builder.OpenComponent<BlazorWebAssemblyApp.Client.Shared.EditSuperHero>(38);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\surya\source\repos\BlazorWebAssemblyApp\Client\Pages\MyHero.razor"
        
    List<BlazorWebAssemblyApp.Shared.MyHeros> heroes = new List<BlazorWebAssemblyApp.Shared.MyHeros>();
    protected async override Task OnInitializedAsync()
    {
        await MyHero_Service.GetComics();
        heroes = await  MyHero_Service.Getheros();

    }
    void ShowHero(int id)
    {
        NavigationManager.NavigateTo($"/Hero/{id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMyHero_Service MyHero_Service { get; set; }
    }
}
#pragma warning restore 1591
