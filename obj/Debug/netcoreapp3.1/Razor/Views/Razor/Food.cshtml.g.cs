#pragma checksum "C:\Users\admin\Desktop\Dojo Assignments\C#\ASP.NET Core\Razor_Fun!\Views\Razor\Food.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6578cefb2c596eebc899339bd1f5cc242ac233c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Razor_Food), @"mvc.1.0.view", @"/Views/Razor/Food.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6578cefb2c596eebc899339bd1f5cc242ac233c0", @"/Views/Razor/Food.cshtml")]
    public class Views_Razor_Food : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6578cefb2c596eebc899339bd1f5cc242ac233c02730", async() => {
                WriteLiteral("\r\n  <meta charset=\"UTF-8\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n  <title>Document</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6578cefb2c596eebc899339bd1f5cc242ac233c03835", async() => {
                WriteLiteral("\r\n  <h1>Here are some delicious foods!</h1>\r\n");
#nullable restore
#line 10 "C:\Users\admin\Desktop\Dojo Assignments\C#\ASP.NET Core\Razor_Fun!\Views\Razor\Food.cshtml"
    
    var Food = new List<string>
    {
      "Hot Dogs",
      "Hamburgers",
      "French Fries",
      "Cucumber Tomato Salad",
      "Cookies",
      "Gyros",
      "Donuts",
    };
        
    foreach(var food in Food)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n");
#nullable restore
#line 25 "C:\Users\admin\Desktop\Dojo Assignments\C#\ASP.NET Core\Razor_Fun!\Views\Razor\Food.cshtml"
             if(food.StartsWith("C"))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("              <p style=\"color : red\">");
#nullable restore
#line 27 "C:\Users\admin\Desktop\Dojo Assignments\C#\ASP.NET Core\Razor_Fun!\Views\Razor\Food.cshtml"
                                Write(food);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 28 "C:\Users\admin\Desktop\Dojo Assignments\C#\ASP.NET Core\Razor_Fun!\Views\Razor\Food.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("              <p>");
#nullable restore
#line 31 "C:\Users\admin\Desktop\Dojo Assignments\C#\ASP.NET Core\Razor_Fun!\Views\Razor\Food.cshtml"
            Write(food);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 32 "C:\Users\admin\Desktop\Dojo Assignments\C#\ASP.NET Core\Razor_Fun!\Views\Razor\Food.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("      </div>\r\n");
#nullable restore
#line 34 "C:\Users\admin\Desktop\Dojo Assignments\C#\ASP.NET Core\Razor_Fun!\Views\Razor\Food.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
