#pragma checksum "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmChild.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b0b1dfed9cdbf6edbe916b796962629716b6f61676cf5be8fa20d81e5ff3a92f"
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
    #nullable restore
    public partial class FrmChild : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FrmChild</h3>\r\n\r\n부모에서 전달된 값 :  ");
            __builder.AddContent(1, 
#nullable restore
#line 4 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmChild.razor"
               FromParent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "button");
            __builder.AddAttribute(5, "value", "자식에서 호출");
            __builder.AddAttribute(6, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmChild.razor"
                                               btnChildClick

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "value", "1페이지");
            __builder.AddAttribute(11, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmChild.razor"
                                              ()=>PagerButtonClicked(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "value", "1페이지");
            __builder.AddAttribute(16, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmChild.razor"
                                              ()=>PagerButtonClicked(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmChild.razor"
       
    [Parameter] 
    public int FromParent { get; set; }

    [Parameter]
    public Action OnParentCall { get; set; } //참조

    [Parameter]
    public Action<int> PageIndexChangedChild { get; set; }

    protected void btnChildClick()
    {
        js.InvokeAsync<object>("alert", "btnChildClick호출됨");
        OnParentCall?.Invoke(); //부모에서 전송된 메서드 호출
    }

    protected void PagerButtonClicked(int pagenumber)
    {
        PageIndexChangedChild?.Invoke(pagenumber - 1);
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 1 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmChild.razor"
        IJSRuntime

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 1 "C:\Users\bookp\source\repos\C-\BlazorApp6\Pages\Demos\ParentChild\FrmChild.razor"
                   js

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591