#pragma checksum "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\NavBar\NavBarBadge.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02849e8d413b3b31b656fdde29d2f7335291a6b6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class NavBarBadge : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 7 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\NavBar\NavBarBadge.razor"
       
    private ElementReference reference;
    [Parameter]
    public string Icon { get; set; }
    [Parameter]
    public RenderFragment ChildContent { get; set; }
    [Parameter]
    public Color Color { get; set; }
    //data-toggle="dropdown"
    private string color => Color.GetDescription<StyleAttribute>();

    private async Task Toggle(object e)
    {
        await js.InvokeAsync<string>("toggleMenu", reference);
        StateHasChanged();
    }

    private async Task Hide()
    {
        await Task.Delay(150);
        await js.InvokeAsync<string>("hideMenu", reference);
        StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
