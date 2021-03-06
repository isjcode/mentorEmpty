#pragma checksum "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2762c737350e59fdbd7a3794fac1bb53d8d1c82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Index), @"mvc.1.0.view", @"/Views/Courses/Index.cshtml")]
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
#nullable restore
#line 3 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\_ViewImports.cshtml"
using mentorEmpty.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\_ViewImports.cshtml"
using mentorEmpty.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2762c737350e59fdbd7a3794fac1bb53d8d1c82", @"/Views/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"353fce5cc52765cbcfcaea7514cc8d84c2232d20", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Courses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Courses>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Courses\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <main id=""main"" data-aos=""fade-in"">

    <!-- ======= Breadcrumbs ======= -->
    <div class=""breadcrumbs"">
      <div class=""container"">
        <h2>Courses</h2>
        <p>Est dolorum ut non facere possimus quibusdam eligendi voluptatem. Quia id aut similique quia voluptas sit quaerat debitis. Rerum omnis ipsam aperiam consequatur laboriosam nemo harum praesentium. </p>
      </div>
    </div><!-- End Breadcrumbs -->

    <!-- ======= Courses Section ======= -->
    <section id=""courses"" class=""courses"">
      <div class=""container"" data-aos=""fade-up"">

        <div class=""row"" data-aos=""zoom-in"" data-aos-delay=""100"">
");
#nullable restore
#line 22 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Courses\Index.cshtml"
           foreach (var c in @Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch\">\r\n            <div class=\"course-item\">\r\n              <img");
            BeginWriteAttribute("src", " src=\"", 924, "\"", 955, 2);
            WriteAttributeValue("", 930, "assets/img/", 930, 11, true);
#nullable restore
#line 25 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Courses\Index.cshtml"
WriteAttributeValue("", 941, c.CourseImage, 941, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"...\">\r\n              <div class=\"course-content\">\r\n                <div class=\"d-flex justify-content-between align-items-center mb-3\">\r\n                  <h4>");
#nullable restore
#line 28 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Courses\Index.cshtml"
                 Write(c.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                  <p class=\"price\">$");
#nullable restore
#line 29 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Courses\Index.cshtml"
                               Write(c.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <h3><a href=\"course-details.html\">");
#nullable restore
#line 32 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Courses\Index.cshtml"
                                             Write(c.Position.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                <p>");
#nullable restore
#line 33 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Courses\Index.cshtml"
              Write(c.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"trainer d-flex justify-content-between align-items-center\">\r\n                  <div class=\"trainer-profile d-flex align-items-center\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1539, "\"", 1580, 2);
            WriteAttributeValue("", 1545, "assets/img/trainers/", 1545, 20, true);
#nullable restore
#line 36 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Courses\Index.cshtml"
WriteAttributeValue("", 1565, c.TrainerImage, 1565, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 1599, "\"", 1605, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <span>");
#nullable restore
#line 37 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Courses\Index.cshtml"
                     Write(c.TrainerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                  </div>\r\n                  <div class=\"trainer-rank d-flex align-items-center\">\r\n                    <i class=\"bx bx-user\"></i>&nbsp;");
#nullable restore
#line 40 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Courses\Index.cshtml"
                                               Write(c.Humans);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    &nbsp;&nbsp;\r\n                    <i class=\"bx bx-heart\"></i>&nbsp;");
#nullable restore
#line 42 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Courses\Index.cshtml"
                                                Write(c.Hearts);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\r\n          </div> <!-- End Course Item-->\r\n");
#nullable restore
#line 48 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Courses\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("      \r\n        </div>\r\n\r\n      </div>\r\n    </section><!-- End Courses Section -->\r\n\r\n  </main><!-- End #main -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Courses>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
