#pragma checksum "C:\Users\Girjesh kumar\source\repos\WebAppCoreMoviesAPI\WebAppCoreMoviesAPI\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ad85be21fcd395b9e2f7ab74631fbaa55759f26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ad85be21fcd395b9e2f7ab74631fbaa55759f26", @"/Views/Movies/Details.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppCoreMoviesAPI.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Girjesh kumar\source\repos\WebAppCoreMoviesAPI\WebAppCoreMoviesAPI\Views\Movies\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Movie</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Girjesh kumar\source\repos\WebAppCoreMoviesAPI\WebAppCoreMoviesAPI\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Girjesh kumar\source\repos\WebAppCoreMoviesAPI\WebAppCoreMoviesAPI\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Girjesh kumar\source\repos\WebAppCoreMoviesAPI\WebAppCoreMoviesAPI\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StarCast));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Girjesh kumar\source\repos\WebAppCoreMoviesAPI\WebAppCoreMoviesAPI\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.StarCast));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Girjesh kumar\source\repos\WebAppCoreMoviesAPI\WebAppCoreMoviesAPI\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Producer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Girjesh kumar\source\repos\WebAppCoreMoviesAPI\WebAppCoreMoviesAPI\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Producer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Girjesh kumar\source\repos\WebAppCoreMoviesAPI\WebAppCoreMoviesAPI\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Girjesh kumar\source\repos\WebAppCoreMoviesAPI\WebAppCoreMoviesAPI\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Girjesh kumar\source\repos\WebAppCoreMoviesAPI\WebAppCoreMoviesAPI\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Girjesh kumar\source\repos\WebAppCoreMoviesAPI\WebAppCoreMoviesAPI\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1274, "\"", 1299, 1);
#nullable restore
#line 46 "C:\Users\Girjesh kumar\source\repos\WebAppCoreMoviesAPI\WebAppCoreMoviesAPI\Views\Movies\Details.cshtml"
WriteAttributeValue("", 1289, Model.Mid, 1289, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppCoreMoviesAPI.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
