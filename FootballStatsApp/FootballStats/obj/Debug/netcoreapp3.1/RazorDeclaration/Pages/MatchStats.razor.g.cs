#pragma checksum "D:\Adafy\FootballStatsApp\FootballStats\Pages\MatchStats.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94391720591b93c855f2399bb61bc660e3135152"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "D:\Adafy\FootballStatsApp\FootballStats\Pages\MatchStats.razor"
using FootballStats.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/matchstats/{id}")]
    public partial class MatchStats : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\Adafy\FootballStatsApp\FootballStats\Pages\MatchStats.razor"
       
    private Match match;
    [Parameter]
    public string ID { get; set; }
    int id;

    protected override async Task OnInitializedAsync()
    {
        id = int.Parse(ID);
        match = MatchApi.GetMatch(id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MatchAPI MatchApi { get; set; }
    }
}
#pragma warning restore 1591
