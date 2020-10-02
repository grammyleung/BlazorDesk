#pragma checksum "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\SideBar\SideBarMenuItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ecaa4f486f7fdda934f6852f8e2fdb59cc0523f"
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
    public partial class SideBarMenuItem : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 12 "D:\Solutions\2020\BlazorDesk\repo\src\BlazorDesk\BlazorDesk.Components\SideBar\SideBarMenuItem.razor"
       
    [Parameter]
    public string Icon { get; set; }
    [Parameter]
    public string Link { get; set; } = "javascript:void(0)";
    [Parameter]
    public RenderFragment ChildContent { get; set; }
    [Parameter]
    public NavLinkState NavLinkState { get; set; }

    private string navLinkState { get; set; }

    private void LocationChanged(object sender, LocationChangedEventArgs args)
    {
        if (Link.StartsWith("javascript"))
            return;
        NavLinkState = new Uri(Nav.Uri).PathAndQuery.Trim('/') == Link.Trim('/') ? NavLinkState.Active : NavLinkState.Inactive;
        navLinkState = NavLinkState.GetDescription<StyleAttribute>();
        StateHasChanged();
    }

    protected override Task OnInitializedAsync()
    {
        Nav.LocationChanged += LocationChanged;
        return base.OnInitializedAsync();
    }

    void IDisposable.Dispose()
    {
        Nav.LocationChanged -= LocationChanged;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
    }
}
#pragma warning restore 1591
