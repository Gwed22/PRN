#pragma checksum "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "085f1fce6b2e78a08dcf265b4ae22fbca5fc692a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
using Final.Business.BusinessObject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
using Final.Lib.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"085f1fce6b2e78a08dcf265b4ae22fbca5fc692a", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd3475373e418e124edde1b363012f411f4ae9f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Final.Business.BusinessObject.Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("a"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/blog/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("a-sort"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SortByDateAsc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SortByDateDsc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SortByNameAsc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SortByNameDsc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-primary btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "HOME";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://unpkg.com/scrollreveal""></script>

<style type=""text/css"">
    .head {
        text-align: center;
    }

    .title {
        background-color: gray;
        color: white;
        padding: 10px 0px;
        margin-left: 10px;
        margin-top: 10px;
    }

    .a {
        color: white !important;
    }

    .link {
        color: red;
    }

    .mucluc {
        margin-left: 20px;
        font-size: 16px;
        
    }

    .search {
        text-align: right;
    }

    .a-sort {
        color: black !important;
    }
    li {
        list-style: none;
    }

    style >
    * {
        font-family: Cambria, Cochin, Georgia, Times, Times New Roman, serif;
    }

    .header-title {
        text-align: center;
        font-size: 36px;
    }

    .header-subtitle {
        font-size: 16px;
        margin-left: 10px;
    }

    .image-blog {
        border-radius: 5%;
        box-shadow: 5px 5px 0.8px grey;
        width: 240px");
            WriteLiteral(@";
        margin: 0px;
        padding: 0px;
    }

    .title {
        font-size: 24px;
        font-weight: bold;
    }

    .view-button {
        margin-top: 10px;
        border: 1px solid black;
        border-radius: 10%;
        background-color: cornflowerblue;
        width: 60px;
        height: 40px;
        display: inline-block;
    }
    
   
    .sort-button{
        text-decoration: none;
        border-radius: 10%;
        background-color: royalblue;
        color:white;
        margin: 1.5% 0 1% 1%;    
        padding: 0.5% 1%;
        border:none;
        transition: 1s;
    }

    .sort-button:hover {
            background-color: darkblue;
        }
</style>
<h1 class=""head"">BLOG OF GROUP2</h1>
<div class=""container search"">
    <div class=""row"">
        <div class=""col-sm-12"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "085f1fce6b2e78a08dcf265b4ae22fbca5fc692a10400", async() => {
                WriteLiteral("\r\n                <input type=\"text\" name=\"query\" id=\"s\" size=\"20\" height=\"25\" required />\r\n                <button type=\"submit\" title=\"Search\" class=\"btn btn-primary\">Search</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container title\">\r\n    <div class=\"row\">\r\n        \r\n        <div class=\" mucluc\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "085f1fce6b2e78a08dcf265b4ae22fbca5fc692a12686", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 119 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
         foreach (var cate in ViewData["cate"] as IEnumerable<Category>)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"header-subtitle\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "085f1fce6b2e78a08dcf265b4ae22fbca5fc692a14150", async() => {
#nullable restore
#line 121 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
                                                                                     Write(Html.DisplayFor(catec => cate.CateName));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2750, "~/blog/Index?id=", 2750, 16, true);
#nullable restore
#line 121 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 2766, cate.CateId, 2766, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 122 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<button class=\"sort-button\" onclick=\"showSort()\">Sort</button>\r\n<ul class=\"sort\" id=\"sort\" style=\"display:none\">\r\n    <li class=\"clm\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "085f1fce6b2e78a08dcf265b4ae22fbca5fc692a16348", async() => {
                WriteLiteral("Sort Date Ascending");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n    <li class =\"clm\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "085f1fce6b2e78a08dcf265b4ae22fbca5fc692a17628", async() => {
                WriteLiteral("Sort Date Descending");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n    <li class=\"clm\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "085f1fce6b2e78a08dcf265b4ae22fbca5fc692a18908", async() => {
                WriteLiteral("Sort Name Ascending");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n    <li class=\"clm\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "085f1fce6b2e78a08dcf265b4ae22fbca5fc692a20187", async() => {
                WriteLiteral("Sort Name Descending");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n</ul>\r\n<h1>");
#nullable restore
#line 132 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 137 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td style=\"width: 240px; margin: 0px;\">\r\n                    <div><img style=\"width: 100%;\"");
            BeginWriteAttribute("src", " src=\"", 3631, "\"", 3677, 2);
#nullable restore
#line 141 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3637, Html.DisplayFor(modelItem => item.Img), 3637, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3676, "", 3677, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                </td>\r\n                <td>\r\n                    <div style=\"font-size: 24px; font-weight: bold;\">");
#nullable restore
#line 144 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
                                                                Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <br>\r\n                    <div style=\"color: gray\">");
#nullable restore
#line 146 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.Cate.CateName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <br>\r\n                    <div style=\"color: gray\">");
#nullable restore
#line 148 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.DatePost));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <br>\r\n                    ");
#nullable restore
#line 150 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Decs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "085f1fce6b2e78a08dcf265b4ae22fbca5fc692a24021", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 153 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
                                                                      WriteLiteral(item.BlogId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 156 "E:\PRN211\PRNFinal\Final.WebAppUser\Views\Blog\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<script>
    var sort = document.getElementById('sort')
    function showSort() {
        if (sort.style.display === 'none') {
            sort.style.display = 'block'
        } else {
            sort.style.display = 'none'
        }
    }

    const sr = ScrollReveal({
        origin: ""left"",
        distance: ""80px"",
        duration: 2000,
        reset: true,
    });
    const sv = ScrollReveal({
        origin: ""top"",
        duration: 2000
        
    });

    
    sr.reveal("".table"", { delay: 100 });
    sr.sv("".clm"", { delay: 100 });


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Final.Business.BusinessObject.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591