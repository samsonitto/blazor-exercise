#pragma checksum "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aa92c41508f81b74c2e16e7e4cd1c72be69a374"
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
#line 1 "D:\Adafy\FootballStatsApp\FootballStats\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Adafy\FootballStatsApp\FootballStats\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Adafy\FootballStatsApp\FootballStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Adafy\FootballStatsApp\FootballStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Adafy\FootballStatsApp\FootballStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Adafy\FootballStatsApp\FootballStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Adafy\FootballStatsApp\FootballStats\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Adafy\FootballStatsApp\FootballStats\_Imports.razor"
using FootballStats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Adafy\FootballStatsApp\FootballStats\_Imports.razor"
using FootballStats.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "text-center");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h2 class=\"display-4\" style=\"color:#006622\">VEIKKAUSLIIGA: RESULTS</h2>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "placeholder", "Search by the team name");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
                                             searchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchTerm = __value, searchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 10 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
 if (data != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table table-hover table-striped");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "tbody");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 14 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
             foreach (var m in filteredData)
            {
                // Printing out the matches

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                ");
            __builder.OpenElement(18, "tr");
            __builder.AddAttribute(19, "class", "tr-pointer");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
                                                   e => showStats(m.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 18 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
                         m.MatchDate.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 19 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
                         m.HomeTeam.Name.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 20 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
                         m.HomeGoals.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, " : ");
            __builder.AddContent(31, 
#nullable restore
#line 20 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
                                                   m.AwayGoals.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 21 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
                         m.AwayTeam.Name.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 23 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 26 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "alert alert-danger");
            __builder.AddAttribute(43, "role", "alert");
            __builder.AddMarkupContent(44, "\r\n        JSON API Error: ");
            __builder.AddContent(45, 
#nullable restore
#line 30 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
                         MatchAPI.error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(46, " Reload the page to try again.\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 32 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\Adafy\FootballStatsApp\FootballStats\Pages\Index.razor"
      
    private List<Match> data;
    public string url = "/matchstats";
    public string searchTerm = "";

    protected override async Task OnInitializedAsync()
    {
        // Getting the results data from MatchAPI class
        data = MatchApi.GetMatches();
        await base.OnInitializedAsync();
    }

    private void showStats(int id)
    {
        //Redirecting to the match events page
        navManager.NavigateTo(url + "/" + id);
    }

    //Filtering the fixture list by the search criteria
    List<Match> filteredData => data.Where(i => (i.HomeTeam.Name.ToLower().Contains(searchTerm.ToLower())) || (i.AwayTeam.Name.ToLower().Contains(searchTerm.ToLower()))).ToList();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MatchAPI MatchApi { get; set; }
    }
}
#pragma warning restore 1591
