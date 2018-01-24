using System.Web.Optimization;

namespace Godeltech.Mastery.Web.DigitalLibrary
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            /*Styles*/
            var oleoFont = "https://fonts.googleapis.com/css?family=Oleo+Script:400,700";

            bundles.Add(new StyleBundle("~/bundles/defaultStyles").Include(
                         "~/Content/bootstrap.css",
                         "~/Content/font-awesome.min.css," +
                         "~/Content/Custom/layout.css"));

            bundles.Add(new StyleBundle("~/bundles/OleoFont", oleoFont));

            bundles.Add(new StyleBundle("~/bundles/multiselect-styles").Include(
                     "~/Content/Multiselect/*.css"));

            bundles.Add(new StyleBundle("~/bundles/adminstyles").Include(
                     "~/Content/adminPage.css"));

            /*Scripts*/
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.unobtrusive-ajax.js"));

            bundles.Add(new ScriptBundle("~/bundles/smartmenu").Include(
                        "~/Scripts/jquery.smartmenus.js",
                        "~/Scripts/jquery.smartmenus.bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                         "~/Scripts/jquery.validate.unobtrusive.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/multiselect-scripts").Include(
                      "~/Scripts/Multiselect/*.js"));

            var jQueryUI = "http://code.jquery.com/ui/1.11.4/jquery-ui.js";
            bundles.Add(new ScriptBundle("~/bundles/ui", jQueryUI));

            BundleTable.EnableOptimizations = true;

        }
    }
}