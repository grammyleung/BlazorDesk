#pragma checksum "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Tabs\TabBodyItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b23754d1a7536d40b7bc0a72c6ee9efaab27970b"
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
    public partial class TabBodyItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "tab-pane" + " fade" + " show" + " " + (
#line 2 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Tabs\TabBodyItem.razor"
                                 IsActive ? "active" : string.Empty

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "id", 
#line 2 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Tabs\TabBodyItem.razor"
                                                                           CompositeIdentifier

#line default
#line hidden
            );
            __builder.AddAttribute(3, "role", "tabpanel");
            __builder.AddAttribute(4, "aria-labelledby", "custom-tabs-one-home-tab");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddContent(6, 
#line 3 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\Tabs\TabBodyItem.razor"
     ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
