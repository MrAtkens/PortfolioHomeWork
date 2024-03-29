#pragma checksum "C:\Users\77077\Desktop\PortfolioAspNetCore\PortfolioAspNetCore\Views\Admin\ExpiresAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "220db4c9aaa0f08ca736b7fced66e49c888fdcb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ExpiresAdmin), @"mvc.1.0.view", @"/Views/Admin/ExpiresAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"220db4c9aaa0f08ca736b7fced66e49c888fdcb7", @"/Views/Admin/ExpiresAdmin.cshtml")]
    public class Views_Admin_ExpiresAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/expires.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\77077\Desktop\PortfolioAspNetCore\PortfolioAspNetCore\Views\Admin\ExpiresAdmin.cshtml"
  
	var expires = ViewBag.Expiretis;

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.7/css/bootstrap.min.css\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "220db4c9aaa0f08ca736b7fced66e49c888fdcb73997", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<a class=""nav-link text-dark"" href=""http://localhost:3529/Admin/AboutAdmin"">About CRUD</a>
<div class=""container"">
	<form class=""form-position"">

		<div class=""form-group"">
			<label>Article:</label>
			<input type=""text"" name=""article"" class=""form-control"" required>
		</div>

		<div class=""form-group"">
			<label>Date of Expiretis:</label>
			<input type=""text"" name=""dateOfExpiretis"" class=""form-control"" required>
		</div>

		<div class=""form-group"">
			<label>Description:</label>
			<input type=""text"" name=""description"" class=""form-control"" required>
		</div>

		<button type=""submit"" class=""btn btn-success save-btn"">Save</button>

	</form>
	<br />
	<table class=""table table-bordered data-table"">
		<thead>
		<th>Article</th>
		<th>DateOfExpiretis</th>
		<th>Description</th>
		<th width=""200px"">Action</th>
		</thead>
		<tbody>
");
#nullable restore
#line 37 "C:\Users\77077\Desktop\PortfolioAspNetCore\PortfolioAspNetCore\Views\Admin\ExpiresAdmin.cshtml"
             foreach (var element in expires)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr data-id=\'");
#nullable restore
#line 39 "C:\Users\77077\Desktop\PortfolioAspNetCore\PortfolioAspNetCore\Views\Admin\ExpiresAdmin.cshtml"
                        Write(element.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' data-article=\'");
#nullable restore
#line 39 "C:\Users\77077\Desktop\PortfolioAspNetCore\PortfolioAspNetCore\Views\Admin\ExpiresAdmin.cshtml"
                                                   Write(element.Article);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' data-dateOfExpiretis=\'");
#nullable restore
#line 39 "C:\Users\77077\Desktop\PortfolioAspNetCore\PortfolioAspNetCore\Views\Admin\ExpiresAdmin.cshtml"
                                                                                           Write(element.DateOfExpiretis);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' data-description=\'");
#nullable restore
#line 39 "C:\Users\77077\Desktop\PortfolioAspNetCore\PortfolioAspNetCore\Views\Admin\ExpiresAdmin.cshtml"
                                                                                                                                       Write(element.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'><td>");
#nullable restore
#line 39 "C:\Users\77077\Desktop\PortfolioAspNetCore\PortfolioAspNetCore\Views\Admin\ExpiresAdmin.cshtml"
                                                                                                                                                                 Write(element.Article);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 39 "C:\Users\77077\Desktop\PortfolioAspNetCore\PortfolioAspNetCore\Views\Admin\ExpiresAdmin.cshtml"
                                                                                                                                                                                          Write(element.DateOfExpiretis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 39 "C:\Users\77077\Desktop\PortfolioAspNetCore\PortfolioAspNetCore\Views\Admin\ExpiresAdmin.cshtml"
                                                                                                                                                                                                                           Write(element.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td><button class=\'btn btn-info btn-xs btn-edit ml-20\'>Edit</button><button class=\'btn btn-danger btn-xs btn-delete ml-20\'>Delete</button></td></tr>\r\n");
#nullable restore
#line 40 "C:\Users\77077\Desktop\PortfolioAspNetCore\PortfolioAspNetCore\Views\Admin\ExpiresAdmin.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n\r\n</div>\r\n\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.0/jquery.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "220db4c9aaa0f08ca736b7fced66e49c888fdcb79420", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
