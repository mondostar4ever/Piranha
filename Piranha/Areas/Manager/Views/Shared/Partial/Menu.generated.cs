﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Shared.Partial
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha.Web;
    
    #line 1 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
    using Piranha.WebPages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Shared/Partial/Menu.cshtml")]
    public partial class Menu : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Menu()
        {
        }
        public override void Execute()
        {
WriteLiteral("<ul");

WriteLiteral(" class=\"menu\"");

WriteLiteral(">\r\n");

            
            #line 3 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
    
            
            #line default
            #line hidden
            
            #line 3 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
     foreach (var group in Manager.Menu) {
        if (group.HasAccess()) {
            var items = group.ItemsForUser() ;

            
            #line default
            #line hidden
WriteLiteral("            <li");

            
            #line 6 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
           Write(group.IsActive() ? " class=selected" : "");

            
            #line default
            #line hidden
WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 233), Tuple.Create("\"", 289)
            
            #line 6 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
, Tuple.Create(Tuple.Create("", 240), Tuple.Create<System.Object, System.Int32>(Url.Action(items[0].Action, items[0].Controller)
            
            #line default
            #line hidden
, 240), false)
);

WriteLiteral(">");

            
            #line 6 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
                                                                                                                   Write(group.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 7 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("    <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 341), Tuple.Create("\"", 380)
            
            #line 9 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
, Tuple.Create(Tuple.Create("", 348), Tuple.Create<System.Object, System.Int32>(Url.Action("logout", "account")
            
            #line default
            #line hidden
, 348), false)
);

WriteLiteral(">");

            
            #line 9 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
                                              Write(Piranha.Resources.Global.MenuLogout);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n</ul>\r\n");

        }
    }
}
#pragma warning restore 1591