#pragma checksum "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7572e9f47f8f23f1135ebc9e1a6313967275d9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Trails), @"mvc.1.0.view", @"/Views/Main/Trails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Trails.cshtml", typeof(AspNetCore.Views_Main_Trails))]
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
#line 2 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\_ViewImports.cshtml"
using LostInTheWoods.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7572e9f47f8f23f1135ebc9e1a6313967275d9f", @"/Views/Main/Trails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0b81a7f85c9f061712fb0a50135ae4952e65c51", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Trails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Trail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
  
    double lat= (double)@Model.Latitude;
    double lng = (double)@Model.Longitude;

#line default
#line hidden
            BeginContext(109, 253, true);
            WriteLiteral("<!-- Insert Model Here -->\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-lg-10 border border-white rounded justify-content-center m-4 bg-light\">\r\n        <div class=\"row justify-content-center m-3\">\r\n            <h1 class=\"text-center\">");
            EndContext();
            BeginContext(363, 10, false);
#line 10 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(373, 227, true);
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"row justify-content-center m-3\">\r\n            <div class=\"col-5\">\r\n                <div class=\"row m-3\">\r\n                    <h4>Description</h4>\r\n                    <p class=\"ml-5\">");
            EndContext();
            BeginContext(601, 17, false);
#line 16 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                               Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(618, 212, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"row m-3\">\r\n                    <h4>Trail Length</h4>\r\n                </div>\r\n                <div class=\"row m-3\">\r\n                    <h6 class=\"ml-5\">");
            EndContext();
            BeginContext(831, 12, false);
#line 22 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                                Write(Model.Length);

#line default
#line hidden
            EndContext();
            BeginContext(843, 223, true);
            WriteLiteral(" Miles</h6>\r\n                </div>\r\n                <div class=\"row m-3\">\r\n                    <h4>Elevation Change</h4>\r\n                </div>\r\n                <div class=\"row m-3\">\r\n                    <h6 class=\"ml-5\">");
            EndContext();
            BeginContext(1067, 15, false);
#line 28 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                                Write(Model.Elevation);

#line default
#line hidden
            EndContext();
            BeginContext(1082, 470, true);
            WriteLiteral(@" Feet</h6>
                </div>
            </div>
            <div class=""col-5"">
                <div class=""row m-1"">
                    <div id=""map"" style=""width: 120%; height: 400px;"" class=""mb-3"">
                         <!-- Working on adding Google Maps API -->
                         <script>
                            // Initialize and add the map
                            function initMap() {
                            var pos = {lat: ");
            EndContext();
            BeginContext(1553, 3, false);
#line 38 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                                       Write(lat);

#line default
#line hidden
            EndContext();
            BeginContext(1556, 7, true);
            WriteLiteral(", lng: ");
            EndContext();
            BeginContext(1564, 3, false);
#line 38 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                                                  Write(lng);

#line default
#line hidden
            EndContext();
            BeginContext(1567, 752, true);
            WriteLiteral(@"};
                            var map = new google.maps.Map(
                                document.getElementById('map'), {zoom: 8, center: pos});

                            var marker = new google.maps.Marker({position: pos, map: map});
                            }
                            </script>
                        <script async defer
                            src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyCCDIK0lQGNWrwd9dLatF89vIlL_5WG3yQ&callback=initMap"">
                        </script>
                    </div>
                    <!-- <img src=""~/images/map.jpg"" alt=""Map of Trail"" style=""width: 120%; height: 120%"" class=""mb-3""> -->
                </div>
                <div class=""row m-1"">
");
            EndContext();
#line 52 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                     if (Model.Longitude > 0)
                    {

#line default
#line hidden
            BeginContext(2389, 39, true);
            WriteLiteral("                        <p>Longitude - ");
            EndContext();
            BeginContext(2429, 15, false);
#line 54 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                                  Write(Model.Longitude);

#line default
#line hidden
            EndContext();
            BeginContext(2444, 14, true);
            WriteLiteral(" &#176 W</p>\r\n");
            EndContext();
#line 55 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2530, 39, true);
            WriteLiteral("                        <p>Longitude - ");
            EndContext();
            BeginContext(2570, 15, false);
#line 58 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                                  Write(Model.Longitude);

#line default
#line hidden
            EndContext();
            BeginContext(2585, 14, true);
            WriteLiteral(" &#176 E</p>\r\n");
            EndContext();
#line 59 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                    }

#line default
#line hidden
            BeginContext(2622, 63, true);
            WriteLiteral("                </div>\r\n                <div class=\"row m-1\">\r\n");
            EndContext();
#line 62 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                     if (Model.Latitude > 0)
                    {

#line default
#line hidden
            BeginContext(2754, 38, true);
            WriteLiteral("                        <p>Latitude - ");
            EndContext();
            BeginContext(2793, 14, false);
#line 64 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                                 Write(Model.Latitude);

#line default
#line hidden
            EndContext();
            BeginContext(2807, 14, true);
            WriteLiteral(" &#176 N</p>\r\n");
            EndContext();
#line 65 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2893, 38, true);
            WriteLiteral("                        <p>Latitude - ");
            EndContext();
            BeginContext(2932, 14, false);
#line 68 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                                 Write(Model.Latitude);

#line default
#line hidden
            EndContext();
            BeginContext(2946, 14, true);
            WriteLiteral(" &#176 S</p>\r\n");
            EndContext();
#line 69 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\LostInTheWoods\Views\Main\Trails.cshtml"
                    }

#line default
#line hidden
            BeginContext(2983, 323, true);
            WriteLiteral(@"                </div>
            </div>
        </div>
        <div class=""form-row justify-content-end mb-2"">
            <div class=""col-lg-5 text-center"">
                <a href=""/NewTrail"" class=""btn btn-success pl-4 pr-4 mb-2"">Add a new Trail</a>
            </div>
        </div>
    </div>
</div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Trail> Html { get; private set; }
    }
}
#pragma warning restore 1591