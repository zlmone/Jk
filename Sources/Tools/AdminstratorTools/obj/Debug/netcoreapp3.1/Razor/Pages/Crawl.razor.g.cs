#pragma checksum "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\Pages\Crawl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3abb1d73c0c449af9f53fde60ddc455f46fa94c6"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 19 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\Pages\Crawl.razor"
     strategy

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "h3");
            __builder.AddContent(4, 
#nullable restore
#line 20 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\Pages\Crawl.razor"
     method

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "social-box");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 24 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\Pages\Crawl.razor"
           if (string.IsNullOrEmpty(method))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-lg-4 col-xs-12 text-center");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "box");
            __builder.AddMarkupContent(21, "\r\n                            <i class=\"fa fa-behance fa-3x\" aria-hidden=\"true\"></i>\r\n                            ");
            __builder.AddMarkupContent(22, "<div class=\"box-title\">\r\n                                <h3>Grammar strategy</h3>\r\n                            </div>\r\n                            ");
            __builder.AddMarkupContent(23, "<div class=\"box-text\">\r\n                                <span>A built-in strategy to scrap this site content.</span>\r\n                            </div>\r\n                            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "box-btn");
            __builder.AddMarkupContent(26, "\r\n                                ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\Pages\Crawl.razor"
                                                                            () => chooseStrategyMethod("grammar")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Continue");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 42 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\Pages\Crawl.razor"
            } 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 44 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\Pages\Crawl.razor"
           if (processPercent > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                ");
            __builder.AddMarkupContent(38, "<div class=\"sonar-wrapper\">\r\n                    <div class=\"sonar-emitter\">\r\n                        <div class=\"sonar-wave\"></div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 51 "D:\MyProjects\JK\Sources\Tools\AdminstratorTools\Pages\Crawl.razor"
            } 

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
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