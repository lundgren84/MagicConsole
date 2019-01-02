using System.Web;
using System.Web.Optimization;

namespace MagicConsole
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/main").Include(
               "~/Scripts/js/navigation.js"));

            bundles.Add(new ScriptBundle("~/bundles/vendor").Include(
               "~/assets/vendor/jquery/jquery.js",
               "~/assets/vendor/jquery-browser-mobile/jquery.browser.mobile.js",
               "~/assets/vendor/bootstrap/js/bootstrap.js",
               "~/assets/vendor/nanoscroller/nanoscroller.js",
               "~/assets/vendor/bootstrap-datepicker/js/bootstrap-datepicker.js",
               "~/assets/vendor/magnific-popup/magnific-popup.js",
               "~/assets/vendor/jquery-placeholder/jquery.placeholder.js",
               "~/assets/vendor/select2/select2.js",
               "~/assets/vendor/jquery-datatables/media/js/jquery.dataTables.js",
               "~/assets/vendor/jquery-datatables-bs3/assets/js/datatables.js",
               "~/assets/javascripts/tables/examples.datatables.editable.js", 
               "~/assets/vendor/jquery-autosize/jquery.autosize.js",
               "~/assets/vendor/bootstrap-fileupload/bootstrap-fileupload.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/theme").Include(
                "~/assets/javascripts/theme.js",
                "~/assets/javascripts/theme.custom.js",
                "~/assets/javascripts/theme.init.js"));

            bundles.Add(new ScriptBundle("~/bundles/codeeditor").Include(
                "~/assets/vendor/codemirror/lib/codemirror.js",
                "~/assets/vendor/codemirror/addon/selection/active-line.js",
                "~/assets/vendor/codemirror/addon/edit/matchbrackets.js",
                "~/assets/vendor/codemirror/mode/javascript/javascript.js",
                "~/assets/vendor/codemirror/mode/xml/xml.js",
                "~/assets/vendor/codemirror/mode/htmlmixed/htmlmixed.js",
                "~/assets/vendor/codemirror/mode/css/css.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
