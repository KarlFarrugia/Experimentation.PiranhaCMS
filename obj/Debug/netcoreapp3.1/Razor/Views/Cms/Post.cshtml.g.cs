#pragma checksum "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cea30c191338c7eb55f78f3a3f332551a54c87b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_Post), @"mvc.1.0.view", @"/Views/Cms/Post.cshtml")]
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
#line 1 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\_ViewImports.cshtml"
using Piranha.AspNetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\_ViewImports.cshtml"
using experimentation_repos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cea30c191338c7eb55f78f3a3f332551a54c87b", @"/Views/Cms/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0dc8f3f4fc32fb34b4c651b64c203e542fff8bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StandardPost>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
  
    ViewData["Title"] = !string.IsNullOrEmpty(Model.MetaTitle) ? Model.MetaTitle : Model.Title;
    var hasImage = Model.PrimaryImage.HasValue;
    var archive = await WebApp.Api.Pages.GetByIdAsync(Model.BlogId);

#line default
#line hidden
#nullable disable
            DefineSection("head", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 8 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
Write(WebApp.MetaTags(Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n<header ");
#nullable restore
#line 11 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
    Write(hasImage ? "class=has-image" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
                                         Write(hasImage ? $"style=background-image:url({ @Url.Content(WebApp.Media.ResizeImage(Model.PrimaryImage, 1920, 400)) })" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n    <div class=\"dimmer\"></div>\n    <div class=\"container text-center\">\n        <h1>");
#nullable restore
#line 14 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        <p class=\"post-meta\">\n            <span>\n                In <a");
            BeginWriteAttribute("href", " href=\"", 626, "\"", 681, 3);
#nullable restore
#line 17 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
WriteAttributeValue("", 633, archive.Permalink, 633, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 651, "/category/", 651, 10, true);
#nullable restore
#line 17 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
WriteAttributeValue("", 661, Model.Category.Slug, 661, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
                                                                         Write(Model.Category.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n            </span>\n            <span>\n                Tags\n");
#nullable restore
#line 21 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
                 foreach (var tag in Model.Tags)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 858, "\"", 897, 3);
#nullable restore
#line 23 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
WriteAttributeValue("", 865, archive.Permalink, 865, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 883, "/tag/", 883, 5, true);
#nullable restore
#line 23 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
WriteAttributeValue("", 888, tag.Slug, 888, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">#");
#nullable restore
#line 23 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
                                                           Write(tag.Slug);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 24 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </span>\n");
#nullable restore
#line 26 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
             if (Model.IsPublished)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>\n                    Published ");
#nullable restore
#line 29 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
                         Write(Model.Published.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </span>\n");
#nullable restore
#line 31 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
             if (Model.EnableComments && Model.CommentCount > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>\n                    <a href=\"#comments\">");
#nullable restore
#line 35 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
                                   Write(Model.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
                                                        Write(Model.CommentCount == 1 ? "comment" : "comments");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </span>\n");
#nullable restore
#line 37 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </p>\n");
#nullable restore
#line 39 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.Excerpt))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row justify-content-center\">\n                <div class=\"col-lg-8 lead\">\n                    ");
#nullable restore
#line 43 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
               Write(Html.Raw(Model.Excerpt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n");
#nullable restore
#line 46 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</header>\n\n<main>\n");
#nullable restore
#line 51 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
     foreach (var block in Model.Blocks)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 1753, "\"", 1783, 2);
            WriteAttributeValue("", 1761, "block", 1761, 5, true);
#nullable restore
#line 53 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
WriteAttributeValue(" ", 1766, block.CssName(), 1767, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <div class=\"container\">\n                ");
#nullable restore
#line 55 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
           Write(Html.DisplayFor(m => block, block.GetType().Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n");
#nullable restore
#line 58 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
     if (Model.EnableComments)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"comments\" class=\"container comments\">\n");
#nullable restore
#line 62 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
             if (Model.IsCommentsOpen)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-comment mt-2 mb-5\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cea30c191338c7eb55f78f3a3f332551a54c87b12767", async() => {
                WriteLiteral("\n                        ");
#nullable restore
#line 66 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 67 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
                   Write(Html.Hidden("Id", Model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        <h3 class=""mb-3"">Leave a comment</h3>
                        <p class=""mb-4"">
                            Please note that we won't show your email to others, or use it for sending
                            unwanted emails. We will only use it to render your Gravatar image and to
                            validate you as a real person.
                        </p>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <input name=""CommentAuthor"" type=""text"" class=""form-control"" placeholder=""Your name"">
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <input name=""CommentEmail"" type=""text"" class=""form-control"" placeholder=""Your email address"">
                            </div>
                        </div>
                        <div class=""f");
                WriteLiteral(@"orm-group"">
                            <input name=""CommentUrl"" type=""text"" class=""form-control"" placeholder=""An (optional) URL to your website"">
                        </div>
                        <div class=""form-group"">
                            <textarea name=""CommentBody"" rows=""6"" class=""form-control"" placeholder=""Your awesome comment""></textarea>
                        </div>
                        <div class=""form-group text-left"">
                            <button class=""btn btn-success"">Post Comment</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 65 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
AddHtmlAttributeValue("", 2168, Model.Permalink, 2168, 16, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2184, "/comment", 2184, 8, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n");
#nullable restore
#line 96 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 97 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
       Write(Html.DisplayFor(m => m.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 99 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Post.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</main>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StandardPost> Html { get; private set; }
    }
}
#pragma warning restore 1591
