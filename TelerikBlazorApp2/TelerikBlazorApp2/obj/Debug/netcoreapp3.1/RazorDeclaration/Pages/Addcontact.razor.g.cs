#pragma checksum "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Addcontact.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "751057c0624a094a823fdafc616367ecb42e04f9"
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
#line 3 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Addcontact.razor"
using DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Addcontact.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Addcontact.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addcontact")]
    public partial class Addcontact : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\rando\source\repos\TelerikBlazorApp2\TelerikBlazorApp2\Pages\Addcontact.razor"
       

    private List<ContactModel> contacts;
    public string test;


    protected override async Task OnInitializedAsync()
    {
        contacts = await _db.GetContact();
    }

    public async void delete(ContactModel contact)
    {

        test= contact.id;
        await JSRuntime.InvokeAsync<string>("open", $"/editcontact/{contact.id}","_blank");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
