#pragma checksum "E:\Example\.NetCore-Project\NewsSystem.Admin\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02bde1ceef96ba911776108a9ab19a0834937c36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Header.cshtml", typeof(AspNetCore.Views_Shared__Header))]
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
#line 1 "E:\Example\.NetCore-Project\NewsSystem.Admin\Views\_ViewImports.cshtml"
using NewsSystem.Admin;

#line default
#line hidden
#line 2 "E:\Example\.NetCore-Project\NewsSystem.Admin\Views\_ViewImports.cshtml"
using NewsSystem.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02bde1ceef96ba911776108a9ab19a0834937c36", @"/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"550a21293b3ee522415058c5645c5b2b5a89f101", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 13593, true);
            WriteLiteral(@"
<nav class=""header-site"">
                <div class=""container-fluid"">
                    <!-- Page title and breadcrumb navigation -->
                    <div class=""page-title"">
                        <h4><a href=""#"" id=""toggle-menu""><i class=""typcn typcn-th-menu""></i></a> <span>DASHBOARD PAGE</span></h4>
                        <nav>
                            <a href=""#"">Dashboard</a>
                            <span class=""typcn typcn-chevron-right""></span>
                            <a href=""#"">Page title</a>
                        </nav>
                    </div>
                    <!-- /Page title and breadcrumb navigation -->
                    <!-- Header navigation / icons -->
                    <ul class=""header-nav navbar-right"">
                        <!-- Messages -->
                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown""><span class=""typcn typcn-messages""></span></a>
                  ");
            WriteLiteral(@"          <span class=""badge"">3</span>
                            <div class=""dropdown-menu panel panel-messages dropdown-arrow pull-right"">
                                <div class=""panel-heading"">MESSAGES <span class=""badge pull-right bg-orange"">NEW</span></div>
                                <div class=""panel-body scrollbox"">
                                    <ul class=""chat"">
                                        <li class=""left clearfix"">
                                            <a href=""#"">
                                                <span class=""chat-img pull-left"">
                                                    <img src=""placeholders/user1.jpg"" alt=""User Avatar"" class=""img-circle"">
                                                </span>
                                                <div class=""chat-body clearfix"">
                                                    <div class=""header"">
                                                        <strong class=""primary-font");
            WriteLiteral(@""">Jon Bateman</strong>
                                                        <small class=""pull-right text-muted"">
                                                            <span class=""glyphicon glyphicon-time""></span>12 mins ago
                                                        </small>
                                                    </div>
                                                    <p>
                                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibend...
                                                    </p>
                                                </div>
                                            </a>
                                        </li>
                                        <li class=""left clearfix"">
                                            <a href=""#"">
                                                <span class=""chat-img pull-left"">
                                                 ");
            WriteLiteral(@"   <img src=""placeholders/user2.jpg"" alt=""User Avatar"" class=""img-circle"">
                                                </span>
                                                <div class=""chat-body clearfix"">
                                                    <div class=""header"">
                                                        <strong class=""primary-font"">Sam Smalls</strong>
                                                        <small class=""pull-right text-muted"">
                                                            <span class=""glyphicon glyphicon-time""></span>12 mins ago
                                                        </small>
                                                    </div>
                                                    <p>
                                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibend...
                                                    </p>
                                        ");
            WriteLiteral(@"        </div>
                                            </a>
                                        </li>
                                        <li class=""left clearfix"">
                                            <a href=""#"">
                                                <span class=""chat-img pull-left"">
                                                    <img src=""placeholders/user1.jpg"" alt=""User Avatar"" class=""img-circle"">
                                                </span>
                                                <div class=""chat-body clearfix"">
                                                    <div class=""header"">
                                                        <strong class=""primary-font"">The Flash</strong>
                                                        <small class=""pull-right text-muted"">
                                                            <span class=""glyphicon glyphicon-time""></span>12 mins ago
                                             ");
            WriteLiteral(@"           </small>
                                                    </div>
                                                    <p>
                                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibend...
                                                    </p>
                                                </div>
                                            </a>
                                        </li>
                                        <li class=""left clearfix"">
                                            <a href=""#"">
                                                <span class=""chat-img pull-left"">
                                                    <img src=""placeholders/user2.jpg"" alt=""User Avatar"" class=""img-circle"">
                                                </span>
                                                <div class=""chat-body clearfix"">
                                                    <div class=""head");
            WriteLiteral(@"er"">
                                                        <strong class=""primary-font"">Bruce Nolan</strong>
                                                        <small class=""pull-right text-muted"">
                                                            <span class=""glyphicon glyphicon-time""></span>12 mins ago
                                                        </small>
                                                    </div>
                                                    <p>
                                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibend...
                                                    </p>
                                                </div>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                                <footer class=""panel-footer text-center"">
           ");
            WriteLiteral(@"                         <a href=""#"">View all messages</a>
                                </footer>
                            </div>
                        </li>
                        <!-- /Messages -->
                        <!-- Notifications -->
                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown""><span class=""typcn typcn-bell""></span></a>
                            <div class=""dropdown-menu panel panel-notifications dropdown-arrow pull-right"">
                                <div class=""panel-heading"">NOTIFICATIONS</div>
                                <div class=""panel-body scrollbox"">
                                    <ul>
                                        <li>
                                            <a href=""#"">
                                                <div class=""clearfix"">
                                                    <span class=""pull-left"">
                               ");
            WriteLiteral(@"                         <i class=""typcn typcn-heart bg-red""></i>
                                                        New likes
                                                    </span>
                                                    <span class=""badge badge-gray pull-right"">22</span>
                                                </div>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <div class=""clearfix"">
                                                    <span class=""pull-left"">
                                                        <i class=""typcn typcn-user bg-blue""></i>
                                                        New users
                                                    </span>
                                                    <span class=""badge badge-gray pull-righ");
            WriteLiteral(@"t"">6</span>
                                                </div>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <div class=""clearfix"">
                                                    <span class=""pull-left"">
                                                        <i class=""typcn typcn-image bg-green""></i>
                                                        New pictures
                                                    </span>
                                                    <span class=""badge badge-gray pull-right"">125</span>
                                                </div>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
          ");
            WriteLiteral(@"                                      <div class=""clearfix"">
                                                    <span class=""pull-left"">
                                                        <i class=""typcn typcn-heart bg-orange""></i>
                                                        New likes
                                                    </span>
                                                    <span class=""badge badge-gray pull-right"">22</span>
                                                </div>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <div class=""clearfix"">
                                                    <span class=""pull-left"">
                                                        <i class=""typcn typcn-user bg-purple""></i>
                                           ");
            WriteLiteral(@"             New users
                                                    </span>
                                                    <span class=""badge badge-gray pull-right"">6</span>
                                                </div>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <div class=""clearfix"">
                                                    <span class=""pull-left"">
                                                        <i class=""typcn typcn-image bg-yellow""></i>
                                                        New pictures
                                                    </span>
                                                    <span class=""badge badge-gray pull-right"">125</span>
                                                </div>
                                  ");
            WriteLiteral(@"          </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </li>
                        <!-- /Notifications -->
                        <!-- Profile -->
                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown""><img src=""placeholders/avatar.jpg"" alt=""User avatar""></a>
                            <ul class=""dropdown-menu dropdown-arrow pull-right"">
                                <li><a href=""#""><span class=""typcn typcn-edit""></span> Edit profile</a></li>
                                <li><a href=""#""><span class=""typcn typcn-cog""></span> Settings</a></li>
                                <li><a href=""#""><span class=""typcn typcn-contacts""></span> Contacts</a></li>
                                <li class=""divider""></li>
                                <li><a href=""#""><span class=""");
            WriteLiteral(@"typcn typcn-power""></span> Sign out</a></li>
                            </ul>
                        </li>
                        <!-- /Profile -->
                    </ul>
                    <!-- /Header navigation / icons -->
                </div>
            </nav>");
            EndContext();
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