#pragma checksum "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\UIElements\ButtonTool.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a276189d3133caeeb109ef43d992ded73aa640c"
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
    public partial class ButtonTool : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "type", "button");
            __builder.AddAttribute(2, "class", "btn btn-tool");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "i");
            __builder.AddAttribute(5, "class", 
#line 3 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\UIElements\ButtonTool.razor"
               Icon

#line default
#line hidden
            );
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 3 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\UIElements\ButtonTool.razor"
                               onClick

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 5 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\UIElements\ButtonTool.razor"
       
    [Parameter]
    public string Icon { get; set; }

    private void onClick(MouseEventArgs args)
    {
        OnClick.InvokeAsync(args);
    }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
