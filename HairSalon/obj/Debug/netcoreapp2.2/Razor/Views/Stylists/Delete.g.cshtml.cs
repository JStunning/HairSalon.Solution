#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\HairSalon.Solution\HairSalon\Views\Stylists\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "836307d6e76338b56a43fc603653fd929be441cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Delete), @"mvc.1.0.view", @"/Views/Stylists/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Delete.cshtml", typeof(AspNetCore.Views_Stylists_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"836307d6e76338b56a43fc603653fd929be441cb", @"/Views/Stylists/Delete.cshtml")]
    public class Views_Stylists_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\HairSalon.Solution\HairSalon\Views\Stylists\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(65, 73, true);
            WriteLiteral("\r\n<h2>Delete?</h2>\r\n<h4>Are you sure you want to delete this?</h4>\r\n\r\n<p>");
            EndContext();
            BeginContext(139, 40, false);
#line 10 "C:\Users\Stunning\Desktop\epicodusProjects\c#\HairSalon.Solution\HairSalon\Views\Stylists\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(179, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(182, 36, false);
#line 10 "C:\Users\Stunning\Desktop\epicodusProjects\c#\HairSalon.Solution\HairSalon\Views\Stylists\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(218, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\HairSalon.Solution\HairSalon\Views\Stylists\Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(254, 59, true);
            WriteLiteral("    <input class=\"button\" type=\"submit\" value=\"Delete\" />\r\n");
            EndContext();
#line 14 "C:\Users\Stunning\Desktop\epicodusProjects\c#\HairSalon.Solution\HairSalon\Views\Stylists\Delete.cshtml"
}

#line default
#line hidden
            BeginContext(317, 40, false);
#line 15 "C:\Users\Stunning\Desktop\epicodusProjects\c#\HairSalon.Solution\HairSalon\Views\Stylists\Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591