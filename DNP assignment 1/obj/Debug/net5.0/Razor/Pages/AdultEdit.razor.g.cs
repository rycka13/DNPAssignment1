#pragma checksum "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6d93433af974142aedaa00ab8b2a6bd0e2228de"
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
#line 2 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
using DNP_assignment_1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AdultEdit/{Id:int}")]
    public partial class AdultEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Editing ");
            __builder.OpenElement(2, "span");
            __builder.AddAttribute(3, "style", "color: #1b6ec2");
            __builder.AddContent(4, 
#nullable restore
#line 7 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                                            _adultActions.getAllAdults().First(a => a.Id == Id).FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " ");
            __builder.AddContent(6, 
#nullable restore
#line 7 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                                                                                                             _adultActions.getAllAdults().First(a => a.Id == Id).LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(7, " ID:");
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "style", "color: #1b6ec2");
            __builder.AddContent(10, 
#nullable restore
#line 7 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                                                                                                                                                                                                                    Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
 if (adultToEdit == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<em>Adult not found</em>");
#nullable restore
#line 13 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                      adultToEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                                                   Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "Name: <br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(23);
                __builder2.AddAttribute(24, "rows", "1");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                                                 adultToEdit.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.FirstName = __value, adultToEdit.FirstName))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "Last name: <br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(32);
                __builder2.AddAttribute(33, "rows", "1");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                                                 adultToEdit.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.LastName = __value, adultToEdit.LastName))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "Hair color: <br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(41);
                __builder2.AddAttribute(42, "rows", "1");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                                                 adultToEdit.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.HairColor = __value, adultToEdit.HairColor))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.HairColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group");
                __builder2.AddMarkupContent(49, "Eye color: <br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(50);
                __builder2.AddAttribute(51, "rows", "1");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                                                 adultToEdit.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.EyeColor = __value, adultToEdit.EyeColor))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.EyeColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "Age: <br>\r\n            ");
                __Blazor.DNP_assignment_1.Pages.AdultEdit.TypeInference.CreateInputNumber_0(__builder2, 59, 60, 
#nullable restore
#line 31 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                                      adultToEdit.Age

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Age = __value, adultToEdit.Age)), 62, () => adultToEdit.Age);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddMarkupContent(66, "Weight (in kg): <br>\r\n            ");
                __Blazor.DNP_assignment_1.Pages.AdultEdit.TypeInference.CreateInputNumber_1(__builder2, 67, 68, 
#nullable restore
#line 33 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                                      adultToEdit.Weight

#line default
#line hidden
#nullable disable
                , 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Weight = __value, adultToEdit.Weight)), 70, () => adultToEdit.Weight);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddMarkupContent(74, "Height (in cm): <br>\r\n            ");
                __Blazor.DNP_assignment_1.Pages.AdultEdit.TypeInference.CreateInputNumber_2(__builder2, 75, 76, 
#nullable restore
#line 35 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                                      adultToEdit.Height

#line default
#line hidden
#nullable disable
                , 77, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Height = __value, adultToEdit.Height)), 78, () => adultToEdit.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group");
                __builder2.AddMarkupContent(82, "Sex: <br>\r\n            ");
                __Blazor.DNP_assignment_1.Pages.AdultEdit.TypeInference.CreateInputSelect_3(__builder2, 83, 84, 
#nullable restore
#line 37 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                                      adultToEdit.Sex

#line default
#line hidden
#nullable disable
                , 85, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Sex = __value, adultToEdit.Sex)), 86, () => adultToEdit.Sex, 87, (__builder3) => {
                    __builder3.AddMarkupContent(88, "<option>M</option>\r\n                ");
                    __builder3.AddMarkupContent(89, "<option>F</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n        ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-group");
                __builder2.AddMarkupContent(93, "Job title: <br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(94);
                __builder2.AddAttribute(95, "rows", "1");
                __builder2.AddAttribute(96, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                                                 adultToEdit.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.JobTitle.JobTitle = __value, adultToEdit.JobTitle.JobTitle))));
                __builder2.AddAttribute(98, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.JobTitle.JobTitle));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n        ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "form-group");
                __builder2.AddMarkupContent(102, "Salary: <br>\r\n            ");
                __Blazor.DNP_assignment_1.Pages.AdultEdit.TypeInference.CreateInputNumber_4(__builder2, 103, 104, 
#nullable restore
#line 44 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
                                      adultToEdit.JobTitle.Salary

#line default
#line hidden
#nullable disable
                , 105, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.JobTitle.Salary = __value, adultToEdit.JobTitle.Salary)), 106, () => adultToEdit.JobTitle.Salary);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n\r\n        ");
                __builder2.AddMarkupContent(108, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Save</button></p>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 49 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\rytis\Desktop\DNP git\DNP assignment 1\Pages\AdultEdit.razor"
       
    [Parameter]
    public int Id { get; set; }

    private Adult adultToEdit = new Adult()
    {
        JobTitle = new Job()
    };

    protected override async Task OnInitializedAsync()
    {
        
        adultToEdit = _adultActions.getAllAdults().First(a => a.Id == Id);
    }

    private void Save()
    {
        _adultActions.editAdult(adultToEdit);
        _navigationManager.NavigateTo("/AdultList");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultActions _adultActions { get; set; }
    }
}
namespace __Blazor.DNP_assignment_1.Pages.AdultEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
