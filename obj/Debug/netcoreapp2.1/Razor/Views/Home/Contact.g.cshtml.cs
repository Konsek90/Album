#pragma checksum "C:\Users\E7470\Documents\GitHub\2\ASP.NET Projekt\Album\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68628e96c067851fa7586f906627a3bbb6283dce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\E7470\Documents\GitHub\2\ASP.NET Projekt\Album\Views\_ViewImports.cshtml"
using Album;

#line default
#line hidden
#line 2 "C:\Users\E7470\Documents\GitHub\2\ASP.NET Projekt\Album\Views\_ViewImports.cshtml"
using Album.Models;

#line default
#line hidden
#line 1 "C:\Users\E7470\Documents\GitHub\2\ASP.NET Projekt\Album\Views\Home\Contact.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68628e96c067851fa7586f906627a3bbb6283dce", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e2824c53204bb4fd24c47298f60c69c4e04b04", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\E7470\Documents\GitHub\2\ASP.NET Projekt\Album\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = ViewLocalizer["Contact"];

#line default
#line hidden
            BeginContext(146, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(151, 17, false);
#line 8 "C:\Users\E7470\Documents\GitHub\2\ASP.NET Projekt\Album\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(168, 29, true);
            WriteLiteral("</h2>\r\n\r\n<address>\r\n    <abbr");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 197, "\"", 229, 1);
#line 11 "C:\Users\E7470\Documents\GitHub\2\ASP.NET Projekt\Album\Views\Home\Contact.cshtml"
WriteAttributeValue("", 205, ViewLocalizer["Adress"], 205, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(230, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(232, 23, false);
#line 11 "C:\Users\E7470\Documents\GitHub\2\ASP.NET Projekt\Album\Views\Home\Contact.cshtml"
                                      Write(ViewLocalizer["Adress"]);

#line default
#line hidden
            EndContext();
            BeginContext(255, 92, true);
            WriteLiteral(":</abbr>\r\n    Konrad ALbum nr.: 11806<br />\r\n    Kraków Chłodna 104 30-444 <br />\r\n    <abbr");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 347, "\"", 378, 1);
#line 14 "C:\Users\E7470\Documents\GitHub\2\ASP.NET Projekt\Album\Views\Home\Contact.cshtml"
WriteAttributeValue("", 355, ViewLocalizer["Phone"], 355, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(379, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(381, 22, false);
#line 14 "C:\Users\E7470\Documents\GitHub\2\ASP.NET Projekt\Album\Views\Home\Contact.cshtml"
                                     Write(ViewLocalizer["Phone"]);

#line default
#line hidden
            EndContext();
            BeginContext(403, 62, true);
            WriteLiteral(":</abbr>\r\n    122224388\r\n</address>\r\n\r\n<address>\r\n    <strong>");
            EndContext();
            BeginContext(466, 24, false);
#line 19 "C:\Users\E7470\Documents\GitHub\2\ASP.NET Projekt\Album\Views\Home\Contact.cshtml"
       Write(ViewLocalizer["Support"]);

#line default
#line hidden
            EndContext();
            BeginContext(490, 91, true);
            WriteLiteral(":</strong> <a href=\"mailto:Support@example.com\">Support@example.com</a><br />\r\n</address>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer ViewLocalizer { get; private set; }
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
