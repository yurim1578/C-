#pragma checksum "C:\Users\bookp\source\repos\C-\BlazorApp7\Shared\LoginDisplay.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "56518a88bef7285f82b1d614c14b1dde361a633316629126ffd7a165c583a4d2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp7.Shared
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bookp\source\repos\C-\BlazorApp7\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\bookp\source\repos\C-\BlazorApp7\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\bookp\source\repos\C-\BlazorApp7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\bookp\source\repos\C-\BlazorApp7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\bookp\source\repos\C-\BlazorApp7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\bookp\source\repos\C-\BlazorApp7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\bookp\source\repos\C-\BlazorApp7\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\bookp\source\repos\C-\BlazorApp7\_Imports.razor"
using BlazorApp7

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\bookp\source\repos\C-\BlazorApp7\_Imports.razor"
using BlazorApp7.Shared

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class LoginDisplay : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "a");
                __builder2.AddAttribute(4, "href", "Identity/Account/Manage");
                __builder2.AddContent(5, "Hello, ");
                __builder2.AddContent(6, 
#nullable restore
#line 3 "C:\Users\bookp\source\repos\C-\BlazorApp7\Shared\LoginDisplay.razor"
                                                  context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(7, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddMarkupContent(9, "<form method=\"post\" action=\"Identity/Account/LogOut\">\r\n            <button type=\"submit\" class=\"nav-link btn btn-link\">Log out</button>\r\n        </form>\r\n    ");
            }
            ));
            __builder.AddAttribute(10, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddMarkupContent(12, "<a href=\"Identity/Account/Register\">Register</a>\r\n        ");
                __builder2.AddMarkupContent(13, "<a href=\"Identity/Account/Login\">Log in</a>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
