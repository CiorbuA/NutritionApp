﻿using System.Web;
using System.Web.Optimization;

namespace NutritionApp
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

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/customjs").Include(
                        virtualPath: "~/Scripts/custom/food.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrapcss").Include(
                      "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/fullcalendarcss").Include(
                     "~/Content/fullcalendar.css"));

            bundles.Add(new StyleBundle("~/Content/customcss").Include(
                     "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/fullcalendarjs").Include(
                "~/Scripts/lib/jquery-ui.min.js",
                "~/Scripts/moment.min.js",
                "~/Scripts/fullcalendar.min.js"));


        }
    }
}
