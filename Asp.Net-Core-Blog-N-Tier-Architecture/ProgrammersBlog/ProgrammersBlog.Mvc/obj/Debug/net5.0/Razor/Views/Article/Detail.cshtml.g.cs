#pragma checksum "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3ac4480bf9e9788bd6abb216bff676f64bd077c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Detail), @"mvc.1.0.view", @"/Views/Article/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ac4480bf9e9788bd6abb216bff676f64bd077c", @"/Views/Article/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Article_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammersBlog.Entities.Dtos.ArticleDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/userImages/defaultUser.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-contact comment_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("commentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
  

    Layout = "_ArticleLayout";
    ViewBag.Title = Model.Article.Title;
    ViewBag.Description = Model.Article.SeoDescription;
    ViewBag.Author = Model.Article.SeoAuthor;
    ViewBag.Tags = Model.Article.SeoTags;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""blog_area single-post-area section-padding"">
      <div class=""container"">
         <div class=""row"">
            <div class=""blog_left_sidebar"">
            <div class=""col-lg-8 posts-list"">
            
               <div class=""single-post"">
                  <div class=""feature-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3ac4480bf9e9788bd6abb216bff676f64bd077c6055", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 649, "~/img/", 649, 6, true);
#nullable restore
#line 20 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
AddHtmlAttributeValue("", 655, Model.Article.Thumbnail, 655, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  </div>\r\n                  <div class=\"blog_details\">\r\n                     <h2>");
#nullable restore
#line 23 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                    Write(Model.Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     </h2>\r\n                     <ul class=\"blog-info-link mt-3 mb-4\">\r\n                            <li><a href=\"#\"><i class=\"fa fa-user\"></i> ");
#nullable restore
#line 26 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                                                                  Write(Model.Article.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li><a href=\"#\"><i class=\"fa fa-comments\"></i>");
#nullable restore
#line 27 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                                                                     Write(Model.Article.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" yorum</a></li>\r\n                     </ul>\r\n\r\n                    \r\n                     <p class=\"excert\">\r\n                            ");
#nullable restore
#line 32 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                       Write(Html.Raw(Model.Article.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     </p>\r\n                  <hr />\r\n                        <p class=\"text-center\"> Okunma Sayısı :<span class=\"badge badge-info\">");
#nullable restore
#line 35 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                                                                                         Write(Model.Article.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>  Yorum Sayısı :<span class=\"badge badge-info\"> ");
#nullable restore
#line 35 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                                                                                                                                                                         Write(Model.Article.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></p>\r\n               </div>\r\n               <div class=\"navigation-top\">\r\n                  <div class=\"d-sm-flex justify-content-between text-center\">\r\n              \r\n                     <ul class=\"social-icons\">\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1789, "\"", 1828, 1);
#nullable restore
#line 41 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
WriteAttributeValue("", 1796, Model.Article.User.FacebookLink, 1796, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1904, "\"", 1942, 1);
#nullable restore
#line 42 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
WriteAttributeValue("", 1911, Model.Article.User.TwitterLink, 1911, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fab fa-twitter""></i></a></li>
                                
                        
                     </ul>
                  </div>
         
               </div>
               <div class=""blog-author"">
                  <div class=""media align-items-center"">
                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3ac4480bf9e9788bd6abb216bff676f64bd077c12135", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2264, "~/img/", 2264, 6, true);
#nullable restore
#line 51 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
AddHtmlAttributeValue("", 2270, Model.Article.User.Picture, 2270, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                     <div class=\"media-body\">\r\n                        <a href=\"#\">\r\n                           <h4>");
#nullable restore
#line 54 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                          Write(Model.Article.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                        </a>\r\n                            <p>");
#nullable restore
#line 56 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                          Write(Model.Article.User.About);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                     </div>\r\n                  </div>\r\n               </div>\r\n                   \r\n               <div class=\"comments-area\">\r\n                        <h4>");
#nullable restore
#line 62 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                       Write(Model.Article.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Comments</h4>\r\n                \r\n");
#nullable restore
#line 64 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                         foreach(var comment in Model.Article.Comments  )
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                              <div class=""comment-list"">
                     <div class=""single-comment justify-content-between d-flex"">
                        <div class=""user justify-content-between d-flex"">
                           <div class=""thumb"">
                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3ac4480bf9e9788bd6abb216bff676f64bd077c15748", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                           </div>\r\n                           <div class=\"desc\">\r\n                              <p class=\"comment\">\r\n                               ");
#nullable restore
#line 74 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                          Write(comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                              </p>
                              <div class=""d-flex justify-content-between"">
                                 <div class=""d-flex align-items-center"">
                                    <h5>
                                       <a href=""#""> ");
#nullable restore
#line 79 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                                               Write(comment.CreatedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                    </h5>
                                    <p class=""date"">December 4, 2017 at 3:12 pm </p>
                                 </div>
                                 <div class=""reply-btn"">
                                    <a href=""#"" class=""btn-reply text-uppercase"">reply</a>
                                 </div>
                              </div>
                           </div>
                        </div>
                     </div>
                  </div>
");
#nullable restore
#line 91 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               </div>\r\n               <div class=\"comment-form\">\r\n                  <h4>Bir Yorum Ekle</h4>\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3ac4480bf9e9788bd6abb216bff676f64bd077c18898", async() => {
                WriteLiteral(@"
                     <div class=""row"">
                        <div class=""col-12"">
                           <div class=""form-group"">
                              <textarea class=""form-control w-100"" name=""comment"" id=""comment"" cols=""30"" rows=""9""
                                 placeholder=""Write Comment""></textarea>
                           </div>
                        </div>
                        <div class=""col-sm-6"">
                           <div class=""form-group"">
                              <input class=""form-control"" name=""name"" id=""name"" type=""text"" placeholder=""Name"">
                           </div>
                        </div>
                        <div class=""col-sm-6"">
                           <div class=""form-group"">
                              <input class=""form-control"" name=""email"" id=""email"" type=""email"" placeholder=""Email"">
                           </div>
                        </div>
                        <div class=""col-12"">
               ");
                WriteLiteral(@"            <div class=""form-group"">
                              <input class=""form-control"" name=""website"" id=""website"" type=""text"" placeholder=""Website"">
                           </div>
                        </div>
                     </div>
                     <div class=""form-group"">
                        <button type=""submit"" class=""button button-contactForm btn_1 boxed-btn"">Gönder</button>
                     </div>
                  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
               </div>
                    
                   
              
            </div>
                
             
                </div>
            </div>
           
        </div>
       
      </div>
   </section>
   <!--================ Blog Area end =================-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammersBlog.Entities.Dtos.ArticleDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
