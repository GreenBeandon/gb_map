#pragma checksum "C:\Users\Bean\source\repos\jquerytestingapp\jquerytestingapp\Views\FaithProject\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8fac965fded8c50f2989edc2a26598fa671b981"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FaithProject_Index), @"mvc.1.0.view", @"/Views/FaithProject/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FaithProject/Index.cshtml", typeof(AspNetCore.Views_FaithProject_Index))]
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
#line 1 "C:\Users\Bean\source\repos\jquerytestingapp\jquerytestingapp\Views\_ViewImports.cshtml"
using jquerytestingapp;

#line default
#line hidden
#line 2 "C:\Users\Bean\source\repos\jquerytestingapp\jquerytestingapp\Views\_ViewImports.cshtml"
using jquerytestingapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8fac965fded8c50f2989edc2a26598fa671b981", @"/Views/FaithProject/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fd799255f10edfd312987a401ba388a43fb7e19", @"/Views/_ViewImports.cshtml")]
    public class Views_FaithProject_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Bean\source\repos\jquerytestingapp\jquerytestingapp\Views\FaithProject\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 1236, true);
            WriteLiteral(@"
<div id=""main"">
    <p id=""width""></p>
    <p id=""height""></p>
    <div id=""usabox"" style=""max-width:50em;display:inline-block;position:relative;"">
            <img id=""usmap"" style=""width:100%;"" src=""https://static.vecteezy.com/system/resources/previews/000/027/496/original/us-map-silhouette-vector.jpg""/>
    </div>

</div>
<!--Load prerequiste js-->
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<script type=""text/javascript"" src=""https://drive.google.com/uc?export=view&id=1aWB-bjjBK_-NCvNoW4_6G_s6sIC6Wb35""></script>
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn-132.anonfiles.com/N0q7le8du0/cfe7bc23-1626995113/gb_map.css"">
<script>
    $(document).ready(function () {
        console.log(""ready!"");
        gb_map.init();
        arr = [
            {
                name: ""test location"",
                x: 50,
                y: 60
            },
            {
                name: ""test location 2"",
                x: 200,
    ");
            WriteLiteral("            y: 200\r\n            },\r\n            {\r\n                name: \"test location 3\",\r\n                x: 235,\r\n                y: 75\r\n            }\r\n        ];\r\n        gb_map.map(arr);\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
