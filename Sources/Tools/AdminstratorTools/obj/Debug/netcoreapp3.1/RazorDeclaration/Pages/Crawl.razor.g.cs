#pragma checksum "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\Pages\Crawl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3abb1d73c0c449af9f53fde60ddc455f46fa94c6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AdminstratorTools.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\_Imports.razor"
using AdminstratorTools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\_Imports.razor"
using AdminstratorTools.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/crawl")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/crawl/{strategy}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/crawl/{strategy}/{method}")]
    public partial class Crawl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\Pages\Crawl.razor"
       
    [Parameter]
    public string strategy { get; set; }
    [Parameter]
    public string method { get; set; }

    private int processPercent { get; set; } = 0;

    protected override void OnInitialized()
    {
        strategy = strategy ?? "";
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\Pages\Crawl.razor"
       

    void chooseStrategyMethod(string _method)
    {
        method = _method;

        processMethod();
    }

    void processMethod()
    {
        processPercent++;


    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591