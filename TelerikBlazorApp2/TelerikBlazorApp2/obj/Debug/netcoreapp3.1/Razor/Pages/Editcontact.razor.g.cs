#pragma checksum "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8913dc6c2d21b442a7f7706d959b5cd9af6a6e4"
// <auto-generated/>
#pragma warning disable 1591
namespace TelerikBlazorApp2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using TelerikBlazorApp2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using TelerikBlazorApp2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
using DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editcontact/{currentCount}")]
    public partial class Editcontact : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Edit or Delete contact</h1>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<p><button class=\"btn btn-success\" onclick=\"location.href=\'viewcontact\';\"> Add contact</button></p>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
 if (newContact != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
                      newContact

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 19 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
                                                  EditContact

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n        ");
                __builder2.AddMarkupContent(12, "<label for=\"lname\">Last name:</label>");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "id", "lname");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
                                                                                newContact.lastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newContact.lastName = __value, newContact.lastName))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newContact.lastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "<br><br>\r\n        ");
                __builder2.AddMarkupContent(19, "<label for=\"fname\">First name:</label>");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "id", "fname");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
                                                                                 newContact.firstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newContact.firstName = __value, newContact.firstName))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newContact.firstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "<br><br>\r\n        ");
                __builder2.AddMarkupContent(26, "<label for=\"bdate\">Birth Date:</label>");
                __Blazor.TelerikBlazorApp2.Pages.Editcontact.TypeInference.CreateInputDate_0(__builder2, 27, 28, "date", 29, "start", 30, "bdate", 31, "1800-01-01", 32, "2018-12-31", 33, 
#nullable restore
#line 26 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
                                                                                                                                            newContact.birthDate

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newContact.birthDate = __value, newContact.birthDate)), 35, () => newContact.birthDate);
                __builder2.AddMarkupContent(36, "<br><br>\r\n        ");
                __builder2.AddMarkupContent(37, "<label for=\"pnumber\">Phone Number:</label>");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "id", "pnumber");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
                                                                                       newContact.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newContact.PhoneNumber = __value, newContact.PhoneNumber))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newContact.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "<br><br>\r\n\r\n\r\n        ");
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "type", "submit");
                __builder2.AddAttribute(46, "class", "btn btn-primary");
                __builder2.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
                                                                 Delete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(48, "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.AddMarkupContent(50, "<button type=\"submit\" class=\"btn btn-primary\" onclick=\"location.href=\'addcontact\';\">Cancel</button>\r\n        ");
                __builder2.OpenElement(51, "button");
                __builder2.AddAttribute(52, "type", "submit");
                __builder2.AddAttribute(53, "class", "btn btn-primary");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
                                                                 InsertContact

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(55, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 34 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "p");
            __builder.AddContent(59, 
#nullable restore
#line 35 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
    currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor"
       
    private List<ContactModel> contacts;
    private ContactModel newContact;

    [Parameter]
    public string currentCount { get; set; }

    protected override void OnParametersSet()
    {
        //the param will be set now
        var test = currentCount;
    }

    protected override async Task OnInitializedAsync()
    {
        contacts = await _db.GetContact();

        foreach (ContactModel contact in contacts)
        {
            if (contact.id == currentCount)
            {
                newContact = contact;
            }
        }
    }

    async void InsertContact()
    {
        // await _db.Delete(currentCount);

        // Random check = new Random();

        // newContact.id = check.Next(1, 1000) + "";

        //  await _db.InsertContact(newContact);

        await _db.updateContact(newContact);
    }
    public async void EditContact()
    {

        await JSRuntime.InvokeAsync<string>("open", $"/addContact");

    }
    public async void Delete()
    {
        await _db.Delete(currentCount);

        await JSRuntime.InvokeAsync<string>("open", $"/addContact");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
namespace __Blazor.TelerikBlazorApp2.Pages.Editcontact
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, System.Object __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "name", __arg2);
        __builder.AddAttribute(__seq3, "min", __arg3);
        __builder.AddAttribute(__seq4, "max", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
