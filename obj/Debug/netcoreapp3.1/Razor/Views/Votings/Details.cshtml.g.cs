#pragma checksum "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5803f8d752bb0bf0a4d1323e7a1c6f6f08dd73fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Votings_Details), @"mvc.1.0.view", @"/Views/Votings/Details.cshtml")]
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
#line 1 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\_ViewImports.cshtml"
using Birthday;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\_ViewImports.cshtml"
using Birthday.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
using Birthday.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5803f8d752bb0bf0a4d1323e7a1c6f6f08dd73fe", @"/Views/Votings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"151a3a76f9d0651ca0c04db7d63a96c0319fec40", @"/Views/_ViewImports.cshtml")]
    public class Views_Votings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Birthday.ViewModels.DetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ChooseGift", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    <h4 class=\"votingCenter\">Birthday Gift Voting</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-3\">\n            ");
#nullable restore
#line 13 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Voting.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-7\">\n            ");
#nullable restore
#line 16 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Voting.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-3\">\n            ");
#nullable restore
#line 19 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CelebratorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-7\">\n            ");
#nullable restore
#line 22 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
       Write(Html.DisplayFor(model => model.CelebratorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-3\">\n            ");
#nullable restore
#line 25 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Voting.VotingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-7\">\n            ");
#nullable restore
#line 28 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Voting.VotingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n");
#nullable restore
#line 32 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
 if (!Model.AlreadyVoted && Model.Voting.VotingStatus)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5803f8d752bb0bf0a4d1323e7a1c6f6f08dd73fe6844", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 34 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Gift;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 35 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>Voting is not active or you already voted</div>\n");
#nullable restore
#line 39 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section>\n    <h4 class=\"votingCenter\">Voting Results</h4>\n");
#nullable restore
#line 43 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
      
        foreach (ResultsViewModel rvm in Model.Results)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <section class=\"results\">\n                <div>");
#nullable restore
#line 47 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
                Write(rvm.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                <div>");
#nullable restore
#line 48 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
                Write(rvm.GiftName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            </section>\n");
#nullable restore
#line 50 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
        }
        foreach (ApplicationUser rvm in Model.DidNotVote)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <section class=\"results\">\n                <div>");
#nullable restore
#line 54 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"
                Write(rvm.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                <div>No Vote</div>\n            </section>\n");
#nullable restore
#line 57 "C:\Users\bgbur\OneDrive\Desktop\New folder (2)\BirthdayGift-master\Birthday\Views\Votings\Details.cshtml"

        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5803f8d752bb0bf0a4d1323e7a1c6f6f08dd73fe10873", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Birthday.ViewModels.DetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
