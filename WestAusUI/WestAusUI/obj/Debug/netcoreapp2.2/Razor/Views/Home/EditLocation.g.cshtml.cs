#pragma checksum "D:\WestAusUI\WestAusUI\Views\Home\EditLocation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1b30d76da916a553cb903452b5b4333e8018318"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditLocation), @"mvc.1.0.view", @"/Views/Home/EditLocation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/EditLocation.cshtml", typeof(AspNetCore.Views_Home_EditLocation))]
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
#line 1 "D:\WestAusUI\WestAusUI\Views\_ViewImports.cshtml"
using WestAusUI;

#line default
#line hidden
#line 2 "D:\WestAusUI\WestAusUI\Views\_ViewImports.cshtml"
using WestAusUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1b30d76da916a553cb903452b5b4333e8018318", @"/Views/Home/EditLocation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef5984f519fdd5528ab270fefee3524b0a7f33b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditLocation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/dataTables.bootstrap4.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\WestAusUI\WestAusUI\Views\Home\EditLocation.cshtml"
  
    ViewData["Title"] = "Edit Location";

#line default
#line hidden
            BeginContext(49, 824, true);
            WriteLiteral(@"
<div class=""container-fluid mt-4"">
    <div class=""card mb-4 animated fadeIn"">
        <div class=""card-header p-3"">
            <div class=""row align-items-center"">
                <div class=""col"">
                    <h3 id=""customerNameLabel"" class=""mb-0 skewed skewed-yellow  d-inline-block text-uppercase ls-1 text-white"">Customer :</h3>
                </div>

            </div>
        </div>
        <div class=""card-body p-3"">
            <div class=""row"">

                <div class=""col-md-12"">
                    <div class=""form-group"">

                        <label class=""form-control-label text-dark ls-1 text-uppercase"">Location Details</label>
                        <input class=""form-control"" id=""locationDetails"" />
                        <input type=""hidden"" id=""customerId""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 873, "\"", 900, 1);
#line 23 "D:\WestAusUI\WestAusUI\Views\Home\EditLocation.cshtml"
WriteAttributeValue("", 881, ViewBag.CustomerId, 881, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(901, 65, true);
            WriteLiteral(" />\r\n                        <input type=\"hidden\" id=\"locationId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 966, "\"", 993, 1);
#line 24 "D:\WestAusUI\WestAusUI\Views\Home\EditLocation.cshtml"
WriteAttributeValue("", 974, ViewBag.LocationId, 974, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(994, 363, true);
            WriteLiteral(@" />
                    </div>

                </div>

                <div class=""col-lg-12"">
                    <div class=""form-group mb-0"">
                        <input type=""button"" value=""Save"" id=""editButton"" class=""btn btn-primary"" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1375, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1381, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1b30d76da916a553cb903452b5b4333e80183186343", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 39 "D:\WestAusUI\WestAusUI\Views\Home\EditLocation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1504, 2053, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            var customerId = $(""#customerId"").val();
            var endpoint = ""https://localhost:44303/api/customers/"" + customerId;

            $.ajax({
                url: endpoint,
                contentType: ""application/json"",
                type: ""GET"",
                dataType: 'json',
                success: function (result) {
                    if (result != null) {
                        $(""#customerNameLabel"").append("" "" + result.name);
                    }

                }
            })
            var locationId = $(""#locationId"").val();
            var endpoint = ""https://localhost:44303/api/locations/"" + locationId;

            $.ajax({
                url: endpoint,
                contentType: ""application/json"",
                type: ""GET"",
                dataType: 'json',
                success: function (result) {
                    if (result != null) {
              ");
                WriteLiteral(@"          $(""#locationDetails"").val(result.locationDetails);
                    }
                   
                }
            })


            $('#editButton').on('click', function () {
                var locationDetails = $(""#locationDetails"").val();
                var endpoint = ""https://localhost:44303/api/locations""
                var sendData = '{ ""id"":""' + locationId + '"",""locationDetails"" : ""' + locationDetails + '"", ""customerId"":""' + customerId + '""}'
                $.ajax({
                    url: endpoint,
                    contentType: ""application/json"",
                    type: ""PATCH"",
                    data: sendData,
                    dataType: 'json',
                    success: function (result) {
                        if (result != null) {
                            location.href = '/Home/LocationIndex/?customerId=' + customerId;
                        }
                    }
                })


            });
        });



    </scri");
                WriteLiteral("pt>\r\n");
                EndContext();
#line 98 "D:\WestAusUI\WestAusUI\Views\Home\EditLocation.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
