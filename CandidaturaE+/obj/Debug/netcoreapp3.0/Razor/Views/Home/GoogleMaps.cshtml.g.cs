#pragma checksum "E:\Projetos\PV_Projeto\Projecto_ESW_1920\CandidaturaE+\Views\Home\GoogleMaps.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "793dce4007ca947cce2cb72f6e501d70a766582f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GoogleMaps), @"mvc.1.0.view", @"/Views/Home/GoogleMaps.cshtml")]
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
#line 1 "E:\Projetos\PV_Projeto\Projecto_ESW_1920\CandidaturaE+\Views\_ViewImports.cshtml"
using CandidaturaE_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projetos\PV_Projeto\Projecto_ESW_1920\CandidaturaE+\Views\_ViewImports.cshtml"
using CandidaturaE_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"793dce4007ca947cce2cb72f6e501d70a766582f", @"/Views/Home/GoogleMaps.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"662cb516559575d5c0fce08b3d0f2d802266e980", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GoogleMaps : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Projetos\PV_Projeto\Projecto_ESW_1920\CandidaturaE+\Views\Home\GoogleMaps.cshtml"
  
    ViewData["Title"] = "GoogleMaps";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>");
#nullable restore
#line 6 "E:\Projetos\PV_Projeto\Projecto_ESW_1920\CandidaturaE+\Views\Home\GoogleMaps.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<style>
    /* Always set the map height explicitly to define the size of the div
       * element that contains the map. */
    #map {
        height: 400px;
        width:400px
    }
</style>

<div class=""row"">
    <div id=""map""></div>
    <script>
        var map;
        function initMap() {
            map = new google.maps.Map(document.getElementById('map'), {
                center: { lat: -34.397, lng: 150.644 },
                zoom: 15
            });
        }
    </script>
    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyAuyoUM2HoU0jM9514q7AXV8cWWlOMgFZg&callback=initMap""
            async defer></script>
</div>");
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