using System.Web;
using System.Web.Optimization;

namespace deshboard
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryLib").Include(
                        "~/Scripts/jquery-1.9.1.js",
                        "~/Scripts/jquery-migrate-1.0.0.js",
                        "~/Scripts/jquery-ui-1.10.0.custom.js",
                        "~/Scripts/jquery.ui.touch-punch.js",
                        "~/Scripts/modernizr.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/jquery.cookie.js",
                        "~/Scripts/fullcalendar.js",
                        "~/Scripts/jquery.dataTables.js",
                        "~/Scripts/excanvas.js",
                        "~/Scripts/jquery.flot.js",
                        "~/Scripts/jquery.flot.pie.js",
                        "~/Scripts/jquery.flot.stack.js",
                        "~/Scripts/jquery.flot.resize.js",
                        "~/Scripts/jquery.chosen.js",
                        "~/Scripts/jquery.uniform.js",
                        "~/Scripts/jquery.cleditor.js",
                        "~/Scripts/jquery.noty.js",
                        "~/Scripts/jquery.elfinder.js",
                        "~/Scripts/jquery.raty.js",
                        "~/Scripts/jquery.iphone.toggle.js",
                        "~/Scripts/jquery.uploadify-3.1.js",
                        "~/Scripts/jquery.gritter.js",
                        "~/Scripts/jquery.imagesloaded.js",
                        "~/Scripts/jquery.masonry.js",
                        "~/Scripts/jquery.knob.modified.js",
                        "~/Scripts/jquery.sparkline.js",
                        "~/Scripts/counter.js",
                        "~/Scripts/retina.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryLibPosLoad").Include("~/Scripts/custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/bootstrap-responsive.css",
                        "~/Content/style.css",
                        "~/Content/style-responsive.css",
                        "~/Content/halflings.css"));
        }
    }
}