#pragma checksum "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\SideBar\SideBarContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f524446f5b55f0e603fa4d9a18716f6d9ad4e2c"
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
    public partial class SideBarContainer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "aside");
            __builder.AddAttribute(1, "class", "main-sidebar sidebar-dark-primary elevation-4");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddContent(3, 
#line 4 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\SideBar\SideBarContainer.razor"
     ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 6 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\SideBar\SideBarContainer.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591