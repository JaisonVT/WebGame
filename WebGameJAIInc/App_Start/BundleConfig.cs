using System.Web;
using System.Web.Optimization;

namespace WebGameJAIInc
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-2.1.0.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                        "~/Scripts/accordions.js",
                        "~/Scripts/imgfix.min.js",
                        "~/Scripts/mixitup.js",
                        "~/Scripts/scrollreveal.min.js",
                        "~/Scripts/waypoints.min.js",
                        "~/Scripts/jquery.counterup.min.js",
                        "~/Scripts/game.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/popper.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/font-awesome.css",
                      "~/css/templatemo-training-studio.css",
                      "~/css/game.css"));

            bundles.Add(new StyleBundle("~/Content/GlobalInit").Include(
                       "~/Scripts/custom.js"));
        }
    }
}
