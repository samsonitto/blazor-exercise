#pragma checksum "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4a1f9b2335b1f295db513f7f1400f6e1a05c6dc"
// <auto-generated/>
#pragma warning disable 1591
namespace FootballStats.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\_Imports.razor"
using FootballStats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\_Imports.razor"
using FootballStats.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\Pages\Index.razor"
using FootballStats.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"display-4\">VEIKKAUSLIIGA: RESULTS</h2>\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "class", "form-control");
            __builder.AddAttribute(3, "placeholder", "Hae pelit joukkueen nimellä");
            __builder.AddAttribute(4, "style", "margin:10px 0px; text-align:center;");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\Pages\Index.razor"
                                         searchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchTerm = __value, searchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table table-hover table-striped");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 10 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\Pages\Index.razor"
         foreach (var m in filteredData)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.OpenElement(14, "tr");
            __builder.AddAttribute(15, "style", "cursor:pointer");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\Pages\Index.razor"
                                               e => showStats(m.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 13 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\Pages\Index.razor"
                 m.MatchDate.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 14 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\Pages\Index.razor"
                 m.HomeTeam.Name.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 15 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\Pages\Index.razor"
                 m.HomeGoals.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, " : ");
            __builder.AddContent(27, 
#nullable restore
#line 15 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\Pages\Index.razor"
                                           m.AwayGoals.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 16 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\Pages\Index.razor"
                 m.AwayTeam.Name.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 18 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\samso\Documents\Adafy\blazor-exercise\FootballStatsApp\FootballStats\Pages\Index.razor"
      
    private List<Match> data;
    public string url = "/matchstats";
    public string searchTerm = "";

    protected override async Task OnInitializedAsync()
    {
        try
        {
            data = MatchApi.GetMatches();
        }
        catch
        {
            
        }

    }

    private void showStats(int id)
    {
        navManager.NavigateTo(url + "/" + id);
    }

    List<Match> filteredData => data.Where(i => (i.HomeTeam.Name.ToLower().Contains(searchTerm.ToLower())) || (i.AwayTeam.Name.ToLower().Contains(searchTerm.ToLower()))).ToList();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MatchAPI MatchApi { get; set; }
    }
}
#pragma warning restore 1591
