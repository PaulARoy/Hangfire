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
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
    using Hangfire;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class ScheduledJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");







            
            #line 7 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
  
    Layout = new LayoutPage(Strings.ScheduledJobsPage_Title);

    int from, perPage;

    int.TryParse(Query("from"), out from);
    int.TryParse(Query("count"), out perPage);

    var monitor = Storage.GetMonitoringApi();
    var pager = new Pager(from, perPage, monitor.ScheduledCount());
    var scheduledJobs = monitor.ScheduledJobs(pager.FromRecord, pager.RecordsPerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3 jobs-sidebar\">\r\n        ");


            
            #line 22 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
   Write(Html.JobsSidebar());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <h1 class=\"page-header\">");


            
            #line 25 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                           Write(Strings.ScheduledJobsPage_Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n\r\n");


            
            #line 27 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
         if (pager.TotalPageCount == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-info\">\r\n                ");


            
            #line 30 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
           Write(Strings.ScheduledJobsPage_NoJobs);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 32 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"js-jobs-list\">\r\n                <div class=\"btn-toolbar b" +
"tn-toolbar-top\">\r\n");


            
            #line 37 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                     if (!IsReadOnly)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button class=\"js-jobs-list-command btn btn-sm btn-primar" +
"y\"\r\n                                data-url=\"");


            
            #line 40 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                     Write(Url.To("/jobs/scheduled/enqueue"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                data-loading-text=\"");


            
            #line 41 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                              Write(Strings.Common_Enqueueing);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                disabled=\"disabled\">\r\n                        " +
"    <span class=\"glyphicon glyphicon-play\"></span>\r\n                            " +
"");


            
            #line 44 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                       Write(Strings.ScheduledJobsPage_EnqueueNow);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </button>\r\n");


            
            #line 46 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                    }

            
            #line default
            #line hidden

            
            #line 47 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                     if (!IsReadOnly)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button class=\"js-jobs-list-command btn btn-sm btn-defaul" +
"t\"\r\n                                data-url=\"");


            
            #line 50 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                     Write(Url.To("/jobs/scheduled/delete"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                data-loading-text=\"");


            
            #line 51 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                              Write(Strings.Common_Deleting);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                data-confirm=\"");


            
            #line 52 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                         Write(Strings.Common_DeleteConfirm);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                disabled=\"disabled\">\r\n                        " +
"    <span class=\"glyphicon glyphicon-remove\"></span>\r\n                          " +
"  ");


            
            #line 55 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                       Write(Strings.Common_DeleteSelected);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </button>\r\n");


            
            #line 57 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");


            
            #line 58 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
               Write(Html.PerPageSelector(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"table-responsive\">\r\n     " +
"               <table class=\"table\">\r\n                        <thead>\r\n         " +
"                   <tr>\r\n");


            
            #line 65 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                 if (!IsReadOnly)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <th class=\"min-width\">\r\n                     " +
"                   <input type=\"checkbox\" class=\"js-jobs-list-select-all\"/>\r\n   " +
"                                 </th>\r\n");


            
            #line 70 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <th class=\"min-width\">");


            
            #line 71 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                                 Write(Strings.Common_Id);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th>");


            
            #line 72 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                               Write(Strings.ScheduledJobsPage_Table_Enqueue);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th>");


            
            #line 73 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                               Write(Strings.Common_Job);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"align-right\">");


            
            #line 74 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                                   Write(Strings.ScheduledJobsPage_Table_Scheduled);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n");


            
            #line 77 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                         foreach (var job in scheduledJobs)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <tr class=\"js-jobs-list-row ");


            
            #line 79 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                                    Write(!job.Value.InScheduledState ? "obsolete-data" : null);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 79 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                                                                                            Write(job.Value.InScheduledState ? "hover" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");


            
            #line 80 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                 if (!IsReadOnly)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <td>\r\n");


            
            #line 83 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                         if (job.Value.InScheduledState)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <input type=\"checkbox\" class=\"js-jobs" +
"-list-checkbox\" name=\"jobs[]\" value=\"");


            
            #line 85 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                                                                                                 Write(job.Key);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n");


            
            #line 86 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n");


            
            #line 88 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <td class=\"min-width\">\r\n                         " +
"           ");


            
            #line 90 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                               Write(Html.JobIdLink(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 91 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                     if (!job.Value.InScheduledState)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <span title=\"");


            
            #line 93 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                                Write(Strings.Common_JobStateChanged_Text);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"glyphicon glyphicon-question-sign\"></span>\r\n");


            
            #line 94 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </td>\r\n                                <td class=" +
"\"min-width\">\r\n                                    ");


            
            #line 97 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                               Write(Html.RelativeTime(job.Value.EnqueueAt));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </td>\r\n                                <td clas" +
"s=\"word-break\">\r\n                                    ");


            
            #line 100 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                               Write(Html.JobNameLink(job.Key, job.Value.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </td>\r\n                                <td clas" +
"s=\"align-right\">\r\n");


            
            #line 103 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                     if (job.Value.ScheduledAt.HasValue)
                                    {
                                        
            
            #line default
            #line hidden
            
            #line 105 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                   Write(Html.RelativeTime(job.Value.ScheduledAt.Value));

            
            #line default
            #line hidden
            
            #line 105 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                                                                                       
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </td>\r\n                            </tr>\r\n");


            
            #line 109 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </table>\r\n                </div>\r\n\r\n                ");


            
            #line 113 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
           Write(Html.Paginator(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 115 "..\..\Dashboard\Pages\ScheduledJobsPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
