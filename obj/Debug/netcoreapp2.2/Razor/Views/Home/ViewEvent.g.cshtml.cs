#pragma checksum "/home/peekoh/Documents/coding_dojo/net/belt_exam/Views/Home/ViewEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a7047bbf33e07c182b68d232ec371f63fd4bf6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewEvent), @"mvc.1.0.view", @"/Views/Home/ViewEvent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewEvent.cshtml", typeof(AspNetCore.Views_Home_ViewEvent))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/peekoh/Documents/coding_dojo/net/belt_exam/Views/_ViewImports.cshtml"
using belt_exam;

#line default
#line hidden
#line 2 "/home/peekoh/Documents/coding_dojo/net/belt_exam/Views/_ViewImports.cshtml"
using belt_exam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a7047bbf33e07c182b68d232ec371f63fd4bf6a", @"/Views/Home/ViewEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ede5520864f7369b9a1226860671520e8e6fbcf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(46, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a7047bbf33e07c182b68d232ec371f63fd4bf6a3302", async() => {
                BeginContext(52, 189, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n    <title>Document</title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(248, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(249, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a7047bbf33e07c182b68d232ec371f63fd4bf6a4662", async() => {
                BeginContext(255, 9, true);
                WriteLiteral("\n    <h2>");
                EndContext();
                BeginContext(265, 11, false);
#line 11 "/home/peekoh/Documents/coding_dojo/net/belt_exam/Views/Home/ViewEvent.cshtml"
   Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(276, 26, true);
                WriteLiteral("</h2>\n    <p>Coordinator: ");
                EndContext();
                BeginContext(303, 13, false);
#line 12 "/home/peekoh/Documents/coding_dojo/net/belt_exam/Views/Home/ViewEvent.cshtml"
               Write(Model.Creator);

#line default
#line hidden
                EndContext();
                BeginContext(316, 40, true);
                WriteLiteral("</p>\n    <h3>Participants</h3>\n    <ul>\n");
                EndContext();
#line 15 "/home/peekoh/Documents/coding_dojo/net/belt_exam/Views/Home/ViewEvent.cshtml"
         foreach(var p in Model.Participants){

#line default
#line hidden
                BeginContext(403, 16, true);
                WriteLiteral("            <li>");
                EndContext();
                BeginContext(420, 12, false);
#line 16 "/home/peekoh/Documents/coding_dojo/net/belt_exam/Views/Home/ViewEvent.cshtml"
           Write(p.User.Alias);

#line default
#line hidden
                EndContext();
                BeginContext(432, 6, true);
                WriteLiteral("</li>\n");
                EndContext();
#line 17 "/home/peekoh/Documents/coding_dojo/net/belt_exam/Views/Home/ViewEvent.cshtml"
        }

#line default
#line hidden
                BeginContext(448, 10, true);
                WriteLiteral("    </ul>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(465, 8, true);
            WriteLiteral("\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event> Html { get; private set; }
    }
}
#pragma warning restore 1591