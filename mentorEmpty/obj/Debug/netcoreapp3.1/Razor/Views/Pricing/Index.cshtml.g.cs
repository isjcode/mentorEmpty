#pragma checksum "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Pricing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f3b8a12a0fdf417c248663fe09a1cdca44ea3f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pricing_Index), @"mvc.1.0.view", @"/Views/Pricing/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f3b8a12a0fdf417c248663fe09a1cdca44ea3f5", @"/Views/Pricing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"353fce5cc52765cbcfcaea7514cc8d84c2232d20", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pricing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PricingVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Pricing\Index.cshtml"
  
    ViewData["Title"] = "View";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <main id=""main"">
    <!-- ======= Breadcrumbs ======= -->
    <div class=""breadcrumbs"" data-aos=""fade-in"">
      <div class=""container"">
        <h2>Pricing</h2>
        <p>Est dolorum ut non facere possimus quibusdam eligendi voluptatem. Quia id aut similique quia voluptas sit quaerat debitis. Rerum omnis ipsam aperiam consequatur laboriosam nemo harum praesentium. </p>
      </div>
    </div><!-- End Breadcrumbs -->

    <!-- ======= Pricing Section ======= -->
    <section id=""pricing"" class=""pricing"">
      <div class=""container"" data-aos=""fade-up"">

        <div class=""row"">
");
#nullable restore
#line 21 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Pricing\Index.cshtml"
           foreach (Pricings p in Model.Pricing) {       

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"col-lg-3 col-md-6\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 828, "\"", 873, 2);
            WriteAttributeValue("", 836, "box", 836, 3, true);
#nullable restore
#line 23 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Pricing\Index.cshtml"
WriteAttributeValue(" ", 839, p.IsFeatured ? "featured" : "", 840, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n              <span");
            BeginWriteAttribute("class", " class=\"", 896, "\"", 937, 1);
#nullable restore
#line 24 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Pricing\Index.cshtml"
WriteAttributeValue("", 904, p.isAdvanced ? "advanced" : "", 904, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 24 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Pricing\Index.cshtml"
                                                           Write(p.isAdvanced ? "Advanced" : null);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n              <h3>");
#nullable restore
#line 25 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Pricing\Index.cshtml"
             Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n              <h4><sup>$</sup>");
#nullable restore
#line 26 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Pricing\Index.cshtml"
                         Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> / month</span></h4>\r\n              <ul>\r\n");
#nullable restore
#line 28 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Pricing\Index.cshtml"
                                 foreach (Features feature in Model.Features)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li");
            BeginWriteAttribute("class", " class=\"", 1256, "\"", 1352, 1);
#nullable restore
#line 30 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Pricing\Index.cshtml"
WriteAttributeValue("", 1264, feature.Join.Any(x => x.PricingId == p.Id) ? null : "na text-decoration-line-through", 1264, 88, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 30 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Pricing\Index.cshtml"
                                                                                                                                     Write(feature.Feature);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li> \r\n");
#nullable restore
#line 31 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Pricing\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </ul>\r\n              <div class=\"btn-wrap\">\r\n                <a href=\"#\" class=\"btn-buy\">Buy Now</a>\r\n              </div>\r\n            </div>\r\n          </div>\r\n");
#nullable restore
#line 38 "C:\Users\lasau\source\repos\mentorEmpty\mentorEmpty\Views\Pricing\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n      </div>\r\n    </section><!-- End Pricing Section -->\r\n\r\n  </main><!-- End #main -->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PricingVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
