#pragma checksum "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d68c744aa34694e1eb40dfd625422e4b7f351ac6"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP_assignment_1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\_Imports.razor"
using DNP_assignment_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\_Imports.razor"
using DNP_assignment_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
using DNP_assignment_1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AdultList")]
    public partial class AdultList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AdultList</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by Name: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
                                                   (arg) => Filter(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width: 100px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.AddMarkupContent(8, "<p style=\"color: red\">Log in to add/remove/edit adults</p>");
#nullable restore
#line 14 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
 if (adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<p><em>Loading...</em></p>");
#nullable restore
#line 19 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
}
else if (!adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<p><em>No Adults items exist. Please add some</em></p>");
#nullable restore
#line 25 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table");
            __builder.AddMarkupContent(13, @"<thead><tr><th>Id</th>
            <th>Name</th>
            <th>Surname</th>
            <th>Hair color</th>
            <th>Eye color</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>
            <th>Remove</th>
            <th>Edit</th></tr></thead>
        ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 45 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
         foreach (var item in adultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 48 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 49 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 50 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 51 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 52 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 53 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 54 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 55 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 56 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(44);
            __builder.AddAttribute(45, "Policy", "SecurityLevel5");
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(47, "button");
                __builder2.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
                                        () => RemoveAdult(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(49, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(52);
            __builder.AddAttribute(53, "Policy", "SecurityLevel5");
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(55, "button");
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
                                            () => EditAdult(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(57, "<i class=\"oi oi-justify-right\" style=\"color:blue\"></i>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\rytis\Desktop\DNP assignemnt\DNP assignment 1\DNP assignment 1\Pages\AdultList.razor"
       
    private IList<Adult> adultsToShow;
    private IList<Adult> allAdults;

    private void Filter(ChangeEventArgs changeEventArgs)
    {
        string filterByName = null;
        try
        {
            filterByName = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {
    // ignored
        }
        adultsToShow = allAdults.Where(t => (filterByName != null && t.FirstName.Contains(filterByName) || filterByName == null)).ToList();
    }

    protected override async Task OnInitializedAsync()
    {
        allAdults = _adultActions.getAllAdults();
        adultsToShow = allAdults;
    }

    private void RemoveAdult(Adult adult)
    {
        _adultActions.removeAdult(adult);
        adultsToShow.Remove(adult);
        allAdults.Remove(adult);
    }

    private void EditAdult(int id)
    {
        _navigationManager.NavigateTo($"AdultEdit/{id}");
    }
    
    /*private void CompletedChange(ChangeEventArgs evt, Todo todo)
    {
        todo.IsCompleted = (bool) evt.Value;
        TodoData.Update(todo);
    }*/

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultActions _adultActions { get; set; }
    }
}
#pragma warning restore 1591
