#pragma checksum "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmParent.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "83c4f46c0d1e6cebd20c22f0420a626477204ff4756aa901ea69262ab3c09348"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp6.Pages.Demos.ParentChild
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bookp\source\repos\C-\BlazorApp6\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\bookp\source\repos\C-\BlazorApp6\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\bookp\source\repos\C-\BlazorApp6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\bookp\source\repos\C-\BlazorApp6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\bookp\source\repos\C-\BlazorApp6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\bookp\source\repos\C-\BlazorApp6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\bookp\source\repos\C-\BlazorApp6\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\bookp\source\repos\C-\BlazorApp6\_Imports.razor"
using BlazorApp6

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\bookp\source\repos\C-\BlazorApp6\_Imports.razor"
using BlazorApp6.Shared

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmParent.razor"
      "/Demos/ParentChild/FrmParent"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class FrmParent : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FrmParent</h3>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "value", "부모에서 호출");
            __builder.AddAttribute(4, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmParent.razor"
                                               ParentCall

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<hr>\r\n\r\n\r\n");
            __builder.OpenComponent<global::BlazorApp6.Pages.Demos.ParentChild.FrmChild>(6);
            __builder.AddAttribute(7, "FromParent", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 11 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmParent.razor"
                1234

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "OnParentCall", (object)((global::System.Action)(
#nullable restore
#line 12 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmParent.razor"
                  ParentCall

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "PageIndexChangedChild", (object)((global::System.Action<System.Int32>)(
#nullable restore
#line 13 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmParent.razor"
                                 PageIndexChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmParent.razor"
       
    protected void ParentCall()
    {
        js.InvokeAsync<object>("alert", "ParentCall호출됨");
    }

    protected void PageIndexChanged(int pageIndex)
    {
        js.InvokeAsync<object>("alert", $"{pageIndex} 인덱스 넘어옴");
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 2 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmParent.razor"
        IJSRuntime

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 2 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmParent.razor"
                   js

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
