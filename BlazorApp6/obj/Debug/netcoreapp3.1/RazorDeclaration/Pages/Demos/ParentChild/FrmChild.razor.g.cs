// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
