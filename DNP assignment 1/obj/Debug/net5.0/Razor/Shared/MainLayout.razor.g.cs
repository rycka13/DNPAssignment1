#pragma checksum "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1be0b6ea76b03584135e05e93dbc4d922ae7de2"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP_assignment_1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\_Imports.razor"
using DNP_assignment_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\_Imports.razor"
using DNP_assignment_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Shared\MainLayout.razor"
using LoginComponent;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-qevmyar3ps");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-qevmyar3ps");
            __builder.OpenComponent<DNP_assignment_1.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-qevmyar3ps");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-qevmyar3ps");
            __builder.OpenComponent<LoginComponent.Login>(14);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "content px-4");
            __builder.AddAttribute(18, "b-qevmyar3ps");
            __builder.AddContent(19, 
#nullable restore
#line 16 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Shared\MainLayout.razor"
      

    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        var user = (await AuthStat).User;
        if(!user.Identity.IsAuthenticated)
        {
            _navigationManager.NavigateTo($"/Login");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
