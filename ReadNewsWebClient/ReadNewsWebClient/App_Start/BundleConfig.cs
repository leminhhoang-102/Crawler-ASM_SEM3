using System.Web;
using System.Web.Optimization;

namespace ReadNewsWebClient
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/assets/js/core/jquery.min.js",
                "~/assets/js/core/popper.min.js",
                "~/assets/js/core/bootstrap-material-design.min.js",
                "~/assets/js/plugins/perfect-scrollbar.jquery.min.js",
                "~/assets/js/plugins/moment.min.js",
                "~/assets/js/plugins/sweetalert2.js",
                "~/assets/js/plugins/jquery.validate.min.js",
                "~/assets/js/plugins/jquery.bootstrap-wizard.js",
                "~/assets/js/plugins/bootstrap-selectpicker.js",
                "~/assets/js/plugins/bootstrap-datetimepicker.min.js",
                "~/assets/js/plugins/jquery.dataTables.min.js",
                "~/assets/js/plugins/bootstrap-tagsinput.js",
                "~/assets/js/plugins/jasny-bootstrap.min.js",
                "~/assets/js/plugins/fullcalendar.min.js",
                "~/assets/js/plugins/jquery-jvectormap.js",
                "~/assets/js/plugins/nouislider.min.js",
                "~/assets/js/plugins/chartist.min.js",
                "~/assets/js/plugins/bootstrap-notify.js",
                "~/assets/js/material-dashboard.js?v=2.1.2" ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-3.5.0.min.js"));

   

            bundles.Add(new StyleBundle("~/bundles/app_styles").Include(
                      "~/Content/Css/animate.css", "~/Content/Css/owl.carousel.css",
                      "~/Content/Css/owl.theme.default.css", "~/Content/Css/style_1.css"));
        }
    }
}
