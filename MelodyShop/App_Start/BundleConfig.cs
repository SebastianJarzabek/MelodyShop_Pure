using System.Web.Optimization;

namespace MelodyShop
{
  public class BundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/MelodyShop").Include(
                  "~/Scripts/jquery-{version}.js",
                  "~/Scripts/jquery.validate*",
                  "~/Scripts/jquery-ui.js",
                  "~/Scripts/jquery-bootstrap.js",
                  "~/Scripts/jquery-respond.js",
                  "~/Scripts/knockout-{version}.js"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                  "~/Scripts/modernizr-*"));

      bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css"));

      BundleTable.EnableOptimizations = true;
    }
  }
}
