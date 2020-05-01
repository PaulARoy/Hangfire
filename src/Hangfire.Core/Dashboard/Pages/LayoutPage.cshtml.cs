#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    
    #line 2 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using System.Globalization;
    
    #line default
    #line hidden
    using System.Linq;
    
    #line 4 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 5 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class LayoutPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");








WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"");


            
            #line 10 "..\..\Dashboard\Pages\LayoutPage.cshtml"
       Write(CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n<head>\r\n    <title>");


            
            #line 12 "..\..\Dashboard\Pages\LayoutPage.cshtml"
      Write(Title);

            
            #line default
            #line hidden
WriteLiteral(" – ");


            
            #line 12 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                Write(DashboardOptions.DashboardTitle.Contains("<") ? "Hangfire Dashboard" : DashboardOptions.DashboardTitle);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta ch" +
"arset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-s" +
"cale=1.0\">\r\n    <meta name=\"robots\" content=\"none\">\r\n");


            
            #line 17 "..\..\Dashboard\Pages\LayoutPage.cshtml"
     if (!DashboardOptions.IgnoreAntiforgeryToken)
    {
        if (!String.IsNullOrWhiteSpace(Context.AntiforgeryHeader))
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral(" <meta name=\"csrf-header\" content=\"");


            
            #line 21 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                            Write(Context.AntiforgeryHeader);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");


            
            #line 22 "..\..\Dashboard\Pages\LayoutPage.cshtml"
        }
        if (!String.IsNullOrWhiteSpace(Context.AntiforgeryToken))
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral(" <meta name=\"csrf-token\" content=\"");


            
            #line 25 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                           Write(Context.AntiforgeryToken);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");


            
            #line 26 "..\..\Dashboard\Pages\LayoutPage.cshtml"
        }
    }

            
            #line default
            #line hidden

            
            #line 28 "..\..\Dashboard\Pages\LayoutPage.cshtml"
       var version = GetType().GetTypeInfo().Assembly.GetName().Version; 

            
            #line default
            #line hidden
WriteLiteral("    <link rel=\"stylesheet\" href=\"");


            
            #line 29 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                            Write(Url.To($"/css{version.Major}{version.Minor}{version.Build}0"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n</head>\r\n    <body>\r\n        <!-- Wrap all page content here -->\r\n        <di" +
"v id=\"wrap\">\r\n\r\n            <!-- Fixed navbar -->\r\n            <div class=\"navba" +
"r navbar-default navbar-fixed-top\">\r\n                <div class=\"");


            
            #line 37 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                        Write(DashboardOptions.UseFullWidth ? "container-fluid" : "container");

            
            #line default
            #line hidden
WriteLiteral(@""">
                    <div class=""navbar-header"">
                        <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                            <span class=""icon-bar""></span>
                            <span class=""icon-bar""></span>
                            <span class=""icon-bar""></span>
                        </button>
                        <a class=""navbar-brand"" href=""");


            
            #line 44 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                                 Write(Url.Home());

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 44 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                                              Write(Html.Raw(DashboardOptions.DashboardTitle));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </div>\r\n                    <div class=\"collapse navbar" +
"-collapse\">\r\n                        ");


            
            #line 47 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                   Write(Html.RenderPartial(new Navigation()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 48 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                         if(@AppPath != null) {

            
            #line default
            #line hidden
WriteLiteral("                            <ul class=\"nav navbar-nav navbar-right\">\r\n           " +
"                     <li>\r\n                                    <a href=\"");


            
            #line 51 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                        Write(AppPath);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                        <span class=\"glyphicon glyphicon-log-" +
"out\"></span>\r\n                                        ");


            
            #line 53 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                   Write(Strings.LayoutPage_Back);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </a>\r\n                                </li>" +
"\r\n                            </ul>\r\n");


            
            #line 57 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                    <!--/.nav-collapse -->\r\n         " +
"       </div>\r\n            </div>\r\n\r\n            <!-- Begin page content -->\r\n  " +
"          <div class=\"");


            
            #line 64 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                    Write(DashboardOptions.UseFullWidth ? "container-fluid" : "container");

            
            #line default
            #line hidden
WriteLiteral("\" style=\"margin-bottom: 20px;\">\r\n                <!-- Error alert when polling fa" +
"ils -->\r\n                ");


            
            #line 66 "..\..\Dashboard\Pages\LayoutPage.cshtml"
           Write(Html.RenderPartial(new ErrorAlert()));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                ");


            
            #line 68 "..\..\Dashboard\Pages\LayoutPage.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div id=\"footer\">\r\n            <d" +
"iv class=\"");


            
            #line 73 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                    Write(DashboardOptions.UseFullWidth ? "container-fluid" : "container");

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                <ul class=\"list-inline credit\">\r\n                    <li>\r\n  " +
"                      <a href=\"https://www.hangfire.io/\" target=\"_blank\" rel=\"no" +
"opener noreferrer\">Hangfire ");


            
            #line 76 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                                                                                          Write($"{version.Major}.{version.Minor}.{version.Build}");

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n");


            
            #line 79 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                     if(DashboardOptions.DisplayStorageConnectionString){

            
            #line default
            #line hidden
WriteLiteral("                    <li>");


            
            #line 80 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                   Write(Storage);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");


            
            #line 81 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <li>");


            
            #line 82 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                   Write(Strings.LayoutPage_Footer_Time);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 82 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                                   Write(Html.LocalTime(DateTime.UtcNow));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li>");


            
            #line 83 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                   Write(String.Format(Strings.LayoutPage_Footer_Generatedms, GenerationTime.Elapsed.TotalMilliseconds.ToString("N")));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        \r\n     " +
"   <div id=\"hangfireConfig\"\r\n             data-pollinterval=\"");


            
            #line 89 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                           Write(DashboardOptions.StatsPollingInterval);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n             data-pollurl=\"");


            
            #line 90 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                       Write(Url.To("/stats"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        </div>\r\n\r\n        <script src=\"");


            
            #line 93 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                Write(Url.To($"/js{version.Major}{version.Minor}{version.Build}0"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n    </body>\r\n</html>\r\n");


        }
    }
}
#pragma warning restore 1591
