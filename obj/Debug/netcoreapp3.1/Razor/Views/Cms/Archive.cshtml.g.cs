#pragma checksum "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aa9d8b11b72ada675c0639dccda806ea4731f11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_Archive), @"mvc.1.0.view", @"/Views/Cms/Archive.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aa9d8b11b72ada675c0639dccda806ea4731f11", @"/Views/Cms/Archive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0dc8f3f4fc32fb34b4c651b64c203e542fff8bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_Archive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StandardArchive>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
  
    ViewData["Title"] = !string.IsNullOrEmpty(Model.MetaTitle) ? Model.MetaTitle : Model.Title;
    var hasImage = Model.PrimaryImage.HasValue;

    var posts = Model.Archive.Posts.Count;

#line default
#line hidden
#nullable disable
            DefineSection("head", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 9 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
Write(WebApp.MetaTags(Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n<header ");
#nullable restore
#line 12 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
    Write(hasImage ? "class=has-image" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                                         Write(hasImage ? $"style=background-image:url({ @Url.Content(WebApp.Media.ResizeImage(Model.PrimaryImage, 1920, 400)) })" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n    <div class=\"dimmer\"></div>\n    <div class=\"container text-center\">\n        <h1>");
#nullable restore
#line 15 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 16 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.Excerpt))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row justify-content-center\">\n                <div class=\"col-lg-8 lead\">\n                    ");
#nullable restore
#line 20 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
               Write(Html.Raw(Model.Excerpt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n");
#nullable restore
#line 23 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</header>\n\n<main class=\"archive\">\n");
#nullable restore
#line 28 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
     foreach (var block in Model.Blocks)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 898, "\"", 928, 2);
            WriteAttributeValue("", 906, "block", 906, 5, true);
#nullable restore
#line 30 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
WriteAttributeValue(" ", 911, block.CssName(), 912, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <div class=\"container\">\n                ");
#nullable restore
#line 32 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
           Write(Html.DisplayFor(m => block, block.GetType().Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n");
#nullable restore
#line 35 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\n");
#nullable restore
#line 37 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
         for (var n = 0; n < posts; n += 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\n");
#nullable restore
#line 40 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                 for (var i = n; i < Math.Min(posts, n + 2); i++)
                {
                    var post = Model.Archive.Posts[i];


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 1350, "\"", 1394, 1);
#nullable restore
#line 44 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1358, i == 0 ? "col-md-12" : "col-md-6", 1358, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <article>\n                            <header>\n");
#nullable restore
#line 47 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                                 if (post.PrimaryImage.HasValue)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1605, "\"", 1627, 1);
#nullable restore
#line 49 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1612, post.Permalink, 1612, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                        <img class=\"rounded mb-3\"");
            BeginWriteAttribute("src", " src=\"", 1695, "\"", 1769, 1);
#nullable restore
#line 50 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1701, Url.Content(WebApp.Media.ResizeImage(post.PrimaryImage, 1140, 450)), 1701, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1770, "\"", 1808, 1);
#nullable restore
#line 50 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1776, post.PrimaryImage.Media.AltText, 1776, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                    </a>\n");
#nullable restore
#line 52 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h3>");
#nullable restore
#line 53 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                               Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                                <p class=\"post-meta\">\n                                    <span>\n                                        In <a");
            BeginWriteAttribute("href", " href=\"", 2081, "\"", 2133, 3);
#nullable restore
#line 56 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2088, Model.Permalink, 2088, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2104, "/category/", 2104, 10, true);
#nullable restore
#line 56 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2114, post.Category.Slug, 2114, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 56 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                                                                                              Write(post.Category.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                    </span>\n                                    <span>\n                                        Tags\n");
#nullable restore
#line 60 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                                         foreach (var tag in post.Tags)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a");
            BeginWriteAttribute("href", " href=\"", 2452, "\"", 2489, 3);
#nullable restore
#line 62 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2459, Model.Permalink, 2459, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2475, "/tag/", 2475, 5, true);
#nullable restore
#line 62 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2480, tag.Slug, 2480, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">#");
#nullable restore
#line 62 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                                                                                 Write(tag.Slug);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 63 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </span>\n");
#nullable restore
#line 65 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                                     if (post.IsPublished)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>\n                                            Published ");
#nullable restore
#line 68 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                                                 Write(post.Published.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </span>\n");
#nullable restore
#line 70 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                                     if (post.EnableComments && post.CommentCount > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3136, "\"", 3167, 2);
#nullable restore
#line 74 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3143, post.Permalink, 3143, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3158, "#comments", 3158, 9, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 74 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                                                                          Write(post.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 74 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                                                                                              Write(post.CommentCount == 1 ? "comment" : "comments");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                        </span>\n");
#nullable restore
#line 76 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </p>\n                                <p>");
#nullable restore
#line 78 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                              Write(Html.Raw(post.Excerpt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3463, "\"", 3485, 1);
#nullable restore
#line 79 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3470, post.Permalink, 3470, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Read more</a>\n                            </header>\n                        </article>\n                    </div>\n");
#nullable restore
#line 83 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                     if (i == 0)
                    {
                        n--;
                        break;
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n");
#nullable restore
#line 90 "C:\Users\User\source\experimentation_repos\Experimentation.PiranhaCMS\Views\Cms\Archive.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</main>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StandardArchive> Html { get; private set; }
    }
}
#pragma warning restore 1591
