#pragma checksum "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd46bd3723bbf51da20b8f4b62483144c0003af1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
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
#line 1 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\_ViewImports.cshtml"
using Final.WebAppUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\_ViewImports.cshtml"
using Final.WebAppUser.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Details.cshtml"
using Final.Business.BusinessObject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd46bd3723bbf51da20b8f4b62483144c0003af1", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd3475373e418e124edde1b363012f411f4ae9f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Final.Business.BusinessObject.Blog>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("back-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://unpkg.com/scrollreveal""></script>
<style>
    * {
        font-family: Cambria, Cochin, Georgia, Times, Times New Roman, serif;
    }

    .detail-image {
        width: 50%;
        border-radius: 5%;
        box-shadow: 0px 3px 8px black;
    }

    .detail-title {
        font-size: 42px;
        font-weight: bold;
        text-align: center;
    }

    .blog-context {
        text-align: justify;
        font-size: 20px;
        margin-top: 5%;
    }

    .back-button {
        color: darkslategray;
        font-size: 16px;
        transition: 1s;
    }

        .back-button:hover {
            color: black;
        }

    .comment{
        margin-top:3%;
    }

    .comment-context{
        margin-left:4%;
        margin-bottom:4%;
    }
</style>
<div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd46bd3723bbf51da20b8f4b62483144c0003af17106", async() => {
                WriteLiteral("Back to list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div class=\"container\">\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <div class=\"container detail-title\">\r\n            <dd class=\"col-sm-12\" style=\"text-align:center\">\r\n                ");
#nullable restore
#line 60 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Details.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <dd class=\"col-sm-12\" style=\"text-align: center;\">\r\n            <img class=\"detail-image\"");
            BeginWriteAttribute("src", " src=\"", 1499, "\"", 1541, 1);
#nullable restore
#line 64 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Details.cshtml"
WriteAttributeValue("", 1505, Html.DisplayFor(model => model.Img), 1505, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </dd>\r\n        <dd class=\"container blog-context\">\r\n            <p class=\"col-sm-12\"> ");
#nullable restore
#line 67 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Details.cshtml"
                             Write(Html.DisplayFor(model => model.BlogContext));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n\r\n<div>\r\n    Comment: \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd46bd3723bbf51da20b8f4b62483144c0003af19844", async() => {
                WriteLiteral("\r\n        <input type=\"text\" name=\"blogid\" id=\"b\" style=\"display:none;\"");
                BeginWriteAttribute("value", " value=\"", 1912, "\"", 1933, 1);
#nullable restore
#line 76 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Details.cshtml"
WriteAttributeValue("", 1920, Model.BlogId, 1920, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        <input type=\"text\" name=\"accid\" style=\"display:none;\" id=\"a\"");
                BeginWriteAttribute("value", " value=\"", 2006, "\"", 2048, 1);
#nullable restore
#line 77 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Details.cshtml"
WriteAttributeValue("", 2014, Context.Session.GetInt32("accId"), 2014, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        <input type=\"text\" name=\"context\" id=\"s\" size=\"100\" height=\"1000\" style=\"padding: 50px 0px;\" required />\r\n        <div style=\"margin-top: 10px;\"><button type=\"submit\" title=\"Search\" class=\"btn btn-primary\">Comment</button></div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 83 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Details.cshtml"
 foreach (var comt in ViewData["cmt"] as IEnumerable<Comment>)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"comment\">\r\n    <div style=\"font-weight: bold;\">");
#nullable restore
#line 86 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Details.cshtml"
                               Write(comt.Account.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"comment-context\">");
#nullable restore
#line 87 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Details.cshtml"
                            Write(comt.Context);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n");
#nullable restore
#line 89 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    const sr = ScrollReveal({
        origin: ""top"",
        distance: ""80px"",
        duration: 2000,
        reset: true,
    });

    sr.reveal("".detail-title"", {});
    sr.reveal("".detail-image"", { delay: 100 });
    sr.reveal("".blog-context"", { delay: 400 });
    sr.reveal("".back-button"", { interval: 100 });
    sr.reveal("".comment-form"", { interval: 100 });
    sr.reveal("".comment"", { delay: 200 });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Final.Business.BusinessObject.Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591