#pragma checksum "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4acfc48ba380907588b4681e01f19468e1edf46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Areas\Admin\Views\_ViewImports.cshtml"
using ImtahanLast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Areas\Admin\Views\_ViewImports.cshtml"
using ImtahanLast.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4acfc48ba380907588b4681e01f19468e1edf46", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c3ba7715a07e7fdb92717a5bfbbbd10cd1794e9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Areas\Admin\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">
    <nav class=""navbar-custom-menu navbar navbar-expand-lg m-0"">
        <div class=""sidebar-toggle-icon"" id=""sidebarCollapse"">
            sidebar toggle<span></span>
        </div><!--/.sidebar toggle icon-->
        <div class=""d-flex flex-grow-1"">
            <ul class=""navbar-nav flex-row align-items-center ml-auto"">
                <li class=""nav-item dropdown quick-actions"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" data-toggle=""dropdown"">
                        <i class=""typcn typcn-th-large-outline""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <div class=""nav-grid-row row"">
                            <a href=""#"" class=""icon-menu-item col-4"">
                                <i class=""typcn typcn-cog-outline d-block""></i>
                                <span>Settings</span>
                            </a>
                            <a href=""#"" class=""ico");
            WriteLiteral(@"n-menu-item col-4"">
                                <i class=""typcn typcn-group-outline d-block""></i>
                                <span>Users</span>
                            </a>
                            <a href=""#"" class=""icon-menu-item col-4"">
                                <i class=""typcn typcn-puzzle-outline d-block""></i>
                                <span>Components</span>
                            </a>
                            <a href=""#"" class=""icon-menu-item col-4"">
                                <i class=""typcn typcn-chart-bar-outline d-block""></i>
                                <span>Profits</span>
                            </a>
                            <a href=""#"" class=""icon-menu-item col-4"">
                                <i class=""typcn typcn-time d-block""></i>
                                <span>New Event</span>
                            </a>
                            <a href=""#"" class=""icon-menu-item col-4"">
                                <i c");
            WriteLiteral(@"lass=""typcn typcn-edit d-block""></i>
                                <span>Tasks</span>
                            </a>
                        </div>
                    </div>
                </li><!--/.dropdown-->
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""chat.html""><i class=""typcn typcn-messages""></i></a>
                </li>
                <li class=""nav-item dropdown notification"">
                    <a class=""nav-link dropdown-toggle badge-dot"" href=""#"" data-toggle=""dropdown"">
                        <i class=""typcn typcn-bell""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <h6 class=""notification-title"">Notifications</h6>
                        <p class=""notification-text"">You have 2 unread notification</p>
                        <div class=""notification-list"">
                            <div class=""media new"">
                                <div class=""img-use");
            WriteLiteral("r\"><img src=\"assets/dist/img/avatar.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3155, "\"", 3161, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                <div class=""media-body"">
                                    <h6>Congratulate <strong>Socrates Itumay</strong> for work anniversaries</h6>
                                    <span>Mar 15 12:32pm</span>
                                </div>
                            </div><!--/.media -->
                            <div class=""media new"">
                                <div class=""img-user online""><img src=""assets/dist/img/avatar2.png""");
            BeginWriteAttribute("alt", " alt=\"", 3652, "\"", 3658, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                <div class=""media-body"">
                                    <h6><strong>Joyce Chua</strong> just created a new blog post</h6>
                                    <span>Mar 13 04:16am</span>
                                </div>
                            </div><!--/.media -->
                            <div class=""media"">
                                <div class=""img-user""><img src=""assets/dist/img/avatar3.png""");
            BeginWriteAttribute("alt", " alt=\"", 4126, "\"", 4132, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                <div class=""media-body"">
                                    <h6><strong>Althea Cabardo</strong> just created a new blog post</h6>
                                    <span>Mar 13 02:56am</span>
                                </div>
                            </div><!--/.media -->
                            <div class=""media"">
                                <div class=""img-user""><img src=""assets/dist/img/avatar4.png""");
            BeginWriteAttribute("alt", " alt=\"", 4604, "\"", 4610, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                <div class=""media-body"">
                                    <h6><strong>Adrian Monino</strong> added new comment on your photo</h6>
                                    <span>Mar 12 10:40pm</span>
                                </div>
                            </div><!--/.media -->
                        </div><!--/.notification -->
                        <div class=""dropdown-footer""><a href=""#"">View All Notifications</a></div>
                    </div><!--/.dropdown-menu -->
                </li><!--/.dropdown-->
                <li class=""nav-item dropdown user-menu"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" data-toggle=""dropdown"">
                        <!--<img src=""assets/dist/img/user2-160x160.png"" alt="""">-->
                        <i class=""typcn typcn-user-add-outline""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <div class=""dropdown-heade");
            WriteLiteral(@"r d-sm-none"">
                            <a href=""#"" class=""header-arrow""><i class=""icon ion-md-arrow-back""></i></a>
                        </div>
                        <div class=""user-header"">
                            <div class=""img-user"">
                                <img src=""assets/dist/img/avatar-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5961, "\"", 5967, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div><!-- img-user -->
                            <h6>Naeem Khan</h6>
                            <span><a href=""cdn-cgi/l/email-protection.html"" class=""__cf_email__"" data-cfemail=""9cf9e4fdf1ecf0f9dcfbf1fdf5f0b2fff3f1"">[email&#160;protected]</a></span>
                        </div><!-- user-header -->
                        <a href=""#"" class=""dropdown-item""><i class=""typcn typcn-user-outline""></i> My Profile</a>
                        <a href=""#"" class=""dropdown-item""><i class=""typcn typcn-edit""></i> Edit Profile</a>
                        <a href=""#"" class=""dropdown-item""><i class=""typcn typcn-arrow-shuffle""></i> Activity Logs</a>
                        <a href=""#"" class=""dropdown-item""><i class=""typcn typcn-cog-outline""></i> Account Settings</a>
                        <a href=""page-signin.html"" class=""dropdown-item""><i class=""typcn typcn-key-outline""></i> Sign Out</a>
                    </div><!--/.dropdown-menu -->
                </li>
            </ul><!");
            WriteLiteral(@"--/.navbar nav-->
            <div class=""nav-clock"">
                <div class=""time"">
                    <span class=""time-hours""></span>
                    <span class=""time-min""></span>
                    <span class=""time-sec""></span>
                </div>
            </div><!-- nav-clock -->
        </div>
    </nav><!--/.navbar-->
    <!--Content Header (Page header)-->
    <div class=""content-header row align-items-center m-0"">
        <nav aria-label=""breadcrumb"" class=""col-sm-4 order-sm-last mb-3 mb-sm-0 p-0 "">
            <ol class=""breadcrumb d-inline-flex font-weight-600 fs-13 bg-white mb-0 float-sm-right"">
                <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Forms</a></li>
                <li class=""breadcrumb-item active"">Select</li>
            </ol>
        </nav>
        <div class=""col-sm-8 header-title p-0"">
            <div class=""media"">
                <div class=""header-icon text-success ");
            WriteLiteral(@"mr-3""><i class=""typcn typcn-puzzle-outline""></i></div>
                <div class=""media-body"">
                    <h1 class=""font-weight-bold"">Fixed Layout</h1>
                    <small>From now on you will start your activities.</small>
                </div>
            </div>
        </div>
    </div>
    <!--/.Content Header (Page header)-->
    <div class=""body-content"">
        <div class=""card mb-4"">
            <div class=""card-header"">
                <div class=""d-flex justify-content-between align-items-center"">
                    <div>
                        <h6 class=""fs-17 font-weight-600 mb-0"">Project status</h6>
                    </div>
                    <div class=""text-right"">
                        <div class=""actions"">
                            <a href=""#"" class=""action-item""><i class=""ti-reload""></i></a>
                            <div class=""dropdown action-item"" data-toggle=""dropdown"">
                                <a href=""#"" class=""action-item""><i c");
            WriteLiteral(@"lass=""ti-more-alt""></i></a>
                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <a href=""#"" class=""dropdown-item"">Refresh</a>
                                    <a href=""#"" class=""dropdown-item"">Manage Widgets</a>
                                    <a href=""#"" class=""dropdown-item"">Settings</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
            </div>
        </div>
    </div><!--/.body content-->
</div><!--/.main content-->");
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