using System.Web.Optimization;

namespace Xvolt.Web
{
    public class BundlesConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            SetupJqueryBundle(bundles);
            SetupSiteBundle(bundles);
        }

        private static void SetupJqueryBundle(BundleCollection bundles)
        {
            // Javascript
            var scripts = new[] 
            { 
                "~/Scripts/jquery-{version}.js", 
                "~/Scripts/jquery.metrojs.js" 
            };

            bundles.Add(new ScriptBundle("~/bundles/jquery-script").Include(scripts));

            // CSS/Styles
            var styles = new[] 
            { 
                "~/Styles/jquery.metrojs.css" 
            };

            bundles.Add(new StyleBundle("~/bundles/jquery-style").Include(styles));
        }

        private static void SetupSiteBundle(BundleCollection bundles)
        {
            // Javascript
            var scripts = new[] 
            { 
                "~/Scripts/site.js"
            };

            bundles.Add(new ScriptBundle("~/bundles/site-script").Include(scripts));

            // CSS/Styles
            var styles = new[] 
            { 
                "~/Styles/site.css",
                "~/Styles/background.css", 
                "~/Styles/Home/index.css", 
            };

            bundles.Add(new StyleBundle("~/bundles/site-style").Include(styles));
        }
    }
}