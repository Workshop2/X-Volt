using System.Web.Optimization;

namespace Xvolt.Web
{
    public class BundlesConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            SetupJquery(bundles);
        }

        private static void SetupJquery(BundleCollection bundles)
        {
            // Javascript
            var jqueryScript = new[] 
            { 
                "~/Scripts/jquery-{version}.js", 
                "~/Scripts/jquery.metrojs.js" 
            };

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(jqueryScript));

            // CSS/Styles
            var jqueryStyles = new[] 
            { 
                "~/Styles/jquery.metrojs.css" 
            };

            bundles.Add(new StyleBundle("~/bundles/jquery-style").Include(jqueryStyles));
        }
    }
}