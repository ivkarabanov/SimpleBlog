using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace JustBlog.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            var jqueryBundle = new ScriptBundle("~/jquery", "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.2.min.js")
                .Include("~/scripts/jquery-1.8.2.min.js"); ;

            bundles.Add(jqueryBundle);

            var jqueryValBundle = new ScriptBundle("~/jqueryval", "http://ajax.aspnetcdn.com/ajax/jquery.validate/1.10.0/jquery.validate.min.js")
                                           .Include("~/scripts/jquery.validate.js");
            bundles.Add(jqueryValBundle);

            // jquery unobtrusive validation library
            var jqueryUnobtrusiveValBundle = new ScriptBundle("~/jqueryunobtrusiveval", "http://ajax.aspnetcdn.com/ajax/mvc/3.0/jquery.validate.unobtrusive.min.js")
                                                .Include("~/scripts/jquery.validate2.js");
            bundles.Add(jqueryUnobtrusiveValBundle);

            // application script bundle
            var layoutJsBundle = new ScriptBundle("~/js").Include("~/scripts/app.js");
            bundles.Add(layoutJsBundle);

            // css bundle
            var layoutCssBundle = new StyleBundle("~/css").Include("~/Content/themes/simple/style.css");
            bundles.Add(layoutCssBundle);

            var loginCssBundle = new StyleBundle("~/Content/themes/simple/admin").Include("~/Content/themes/simple/admin.css");
            bundles.Add(loginCssBundle);

            // jQuery UI library bundle
            var jqueryUIBundle = new ScriptBundle("~/jqueryui", "http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.1/jquery-ui.min.js").Include("~/scripts/jquery-ui.min.js");
            bundles.Add(jqueryUIBundle);

            // CSS bundle
            var manageCssBundle = new StyleBundle("~/scripts/jquery.jqGrid-4.4.3/css/bundle").Include("~/scripts/jquery.jqGrid-4.4.3/css/ui.jqgrid.css");
            bundles.Add(manageCssBundle);

            // jQuery UI library CSS bundle
            var jqueryUICssBundle =
            new StyleBundle("~/Content/themes/simple/jquery-ui-1.9.2.custom/css/sunny/bundle").Include("~/Content/themes/simple/jquery-ui-1.9.2.custom/css/sunny/jquery-ui-1.9.2.custom.min.css");
            bundles.Add(jqueryUICssBundle);

            // tinyMCE library bundle
            var tinyMceBundle = new ScriptBundle("~/scripts/tinymce/js").Include("~/scripts/tinymce/tinymce.js");
            bundles.Add(tinyMceBundle);

            // Other scripts
            var manageJsBundle = new ScriptBundle("~/manage/js").Include("~/scripts/jquery.jqGrid-4.4.3/js/jquery.jqGrid.min.js").Include("~/scripts/jquery.jqGrid-4.4.3/js/i18n/grid.locale-ru.js").Include("~/scripts/admin.js");
            bundles.Add(manageJsBundle);
        }
    }
}