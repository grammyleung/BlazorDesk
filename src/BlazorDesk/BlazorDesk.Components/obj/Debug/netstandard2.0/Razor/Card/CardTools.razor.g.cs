#pragma checksum "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Card\CardTools.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaf7f0c92a782149ce8280044593f6426869cc72"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDesk.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 3 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 4 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 5 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 6 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
    public partial class CardTools : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-tools");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddContent(3, 
#line 3 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Card\CardTools.razor"
         CustomTools

#line default
#line hidden
            );
            __builder.AddMarkupContent(4, "\r\n");
#line 4 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Card\CardTools.razor"
         if (ShowOnRefresh)
        {

#line default
#line hidden
            __builder.AddContent(5, "            ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "type", "button");
            __builder.AddAttribute(8, "class", "btn btn-tool");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 6 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Card\CardTools.razor"
                                                                 DoOnRefresh

#line default
#line hidden
            ));
            __builder.AddMarkupContent(10, "\r\n                <i class=\"fas fa-sync-alt\"></i>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#line 9 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Card\CardTools.razor"
        }

#line default
#line hidden
#line 10 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Card\CardTools.razor"
         if (Options.Maximizable)
        {

#line default
#line hidden
            __builder.AddContent(12, "            ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "btn btn-tool");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 12 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Card\CardTools.razor"
                                                                 DoOnMaximize

#line default
#line hidden
            ));
            __builder.AddAttribute(17, "data-card-widget", "maximize");
            __builder.AddMarkupContent(18, "\r\n                <i class=\"fas fa-expand\"></i>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#line 15 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Card\CardTools.razor"
        }

#line default
#line hidden
#line 16 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Card\CardTools.razor"
         if (Options.Collapsable && !IsMaximized)
        {

#line default
#line hidden
            __builder.AddContent(20, "            ");
            __builder.AddMarkupContent(21, "<button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"collapse\">\r\n                <i class=\"fas fa-minus\"></i>\r\n            </button>\r\n");
#line 21 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Card\CardTools.razor"
        }

#line default
#line hidden
#line 22 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Card\CardTools.razor"
         if (Options.Expandable && !IsMaximized)
        {

#line default
#line hidden
            __builder.AddContent(22, "            ");
            __builder.AddMarkupContent(23, "<button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"collapse\">\r\n                <i class=\"fas fa-plus\"></i>\r\n            </button>\r\n");
#line 27 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Card\CardTools.razor"
        }

#line default
#line hidden
#line 28 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Card\CardTools.razor"
         if (Options.Removable && !IsMaximized)
        {

#line default
#line hidden
            __builder.AddContent(24, "            ");
            __builder.AddMarkupContent(25, "<button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"remove\">\r\n                <i class=\"fas fa-times\"></i>\r\n            </button>\r\n");
#line 33 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Card\CardTools.razor"
        }

#line default
#line hidden
            __builder.AddContent(26, "    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
