using System.Web.Optimization;

namespace NickWolf.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
#if !DEBUG
            bundles.UseCdn = true;
            BundleTable.EnableOptimizations = true;
#endif

            bundles.Add(new StyleBundle("~/bundles/bootstrapcss", "//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.css")
                );

            bundles.Add(new StyleBundle("~/bundles/fontawesomcss", "//maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css")
                .Include("~/Content/font-awesome.css")
                );

            bundles.Add(new StyleBundle("~/bundles/commoncss")
                .Include("~/Content/professional.css", new CssRewriteUrlTransform())
                .Include("~/fonts/googleFonts.css")
                );

            bundles.Add(new ScriptBundle("~/bundles/jqueryjs", "//ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js")
                .Include("~/Scripts/jquery-2.2.0.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs", "//maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js")
                .Include("~/Scripts/bootstrap.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/easingjs", "//cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js")
                .Include("~/Scripts/jquery.easing.min.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/classiejs", "//cdnjs.cloudflare.com/ajax/libs/classie/1.0.1/classie.min.js")
                .Include("~/Scripts/classie.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/cbpAnimatedHeaderjs")
                .Include("~/Scripts/cbpAnimatedHeader.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/commonjavascript")
                .Include("~/Scripts/professional.js")
                );
        }
    }
}