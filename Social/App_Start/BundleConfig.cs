using System.Web;
using System.Web.Optimization;

namespace Social
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/ng-grid.js",
                "~/Scripts/ui-grid-unstable.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.js"));


            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/App/MyApp.js"));

            bundles.Add(new ScriptBundle("~/bundles/menu").Include(
                "~/App/AngularController/MenuController.js"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/ng-grid.css",
                      "~/Content/ui-grid-unstable.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/ui-bootstrap-csp.css"));


            bundles.Add(new StyleBundle("~/Content/Kendo").Include(
          "~/Content/Kendo/kendo.common.min.css",
          "~/Content/Kendo/kendo.dataviz.default.min.css",
          "~/Content/Kendo/kendo.dataviz.min.css",
          "~/Content/Kendo/kendo.default.min.css",
          "~/Content/Kendo/examples-offline.css"));



            bundles.Add(new ScriptBundle("~/bundles/Kendo").Include(
          "~/Scripts/Kendo/kendo.all.min.js"));



        }
    }
}
