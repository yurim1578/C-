#pragma checksum "C:\Users\bookp\source\repos\C-\BlazorApp5\Pages\Demos\BlasorForm\BlazorForm.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7c2a862e173e9728a7d6a7a0127ed94437034126d5b84272faf81eebeead136e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp5.Pages.Demos.BlasorForm
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bookp\source\repos\C-\BlazorApp5\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\bookp\source\repos\C-\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\bookp\source\repos\C-\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\bookp\source\repos\C-\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\bookp\source\repos\C-\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\bookp\source\repos\C-\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\bookp\source\repos\C-\BlazorApp5\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\bookp\source\repos\C-\BlazorApp5\_Imports.razor"
using BlazorApp5

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\bookp\source\repos\C-\BlazorApp5\_Imports.razor"
using BlazorApp5.Shared

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\bookp\source\repos\C-\BlazorApp5\Pages\Demos\BlasorForm\BlazorForm.razor"
 using BlazorApp5.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\bookp\source\repos\C-\BlazorApp5\Pages\Demos\BlasorForm\BlazorForm.razor"
      "/BlazorForm"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class BlazorForm : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>BlazorForm</h3>\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 6 "C:\Users\bookp\source\repos\C-\BlazorApp5\Pages\Demos\BlasorForm\BlazorForm.razor"
                  exampleModel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\bookp\source\repos\C-\BlazorApp5\Pages\Demos\BlasorForm\BlazorForm.razor"
                                                btnSubmit_Click

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "id", (object)("txtName"));
                __builder2.AddAttribute(12, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 9 "C:\Users\bookp\source\repos\C-\BlazorApp5\Pages\Demos\BlasorForm\BlazorForm.razor"
                                         exampleModel.Name

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(13, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => exampleModel.Name = __value, exampleModel.Name)))));
                __builder2.AddAttribute(14, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => exampleModel.Name)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                global::__Blazor.BlazorApp5.Pages.Demos.BlasorForm.BlazorForm.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 10 "C:\Users\bookp\source\repos\C-\BlazorApp5\Pages\Demos\BlasorForm\BlazorForm.razor"
                              ()=>exampleModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.AddMarkupContent(19, "<button type=\"submit\">Submit</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n\r\n<hr>\r\n");
            __builder.AddContent(21, 
#nullable restore
#line 15 "C:\Users\bookp\source\repos\C-\BlazorApp5\Pages\Demos\BlasorForm\BlazorForm.razor"
 exampleModel.Name

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\bookp\source\repos\C-\BlazorApp5\Pages\Demos\BlasorForm\BlazorForm.razor"
       
    private ExampleModel exampleModel = new ExampleModel();
    protected override void OnInitialized()
    {
        exampleModel.Name = "홍길동";
    }
    private void btnSubmit_Click()
    {
        
    }

#line default
#line hidden
#nullable disable

    }
}
namespace __Blazor.BlazorApp5.Pages.Demos.BlasorForm.BlazorForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
