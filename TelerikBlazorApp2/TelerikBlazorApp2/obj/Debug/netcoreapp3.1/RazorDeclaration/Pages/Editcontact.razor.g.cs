#pragma checksum "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Editcontact.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8913dc6c2d21b442a7f7706d959b5cd9af6a6e4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591