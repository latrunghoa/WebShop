using System.Web;
using System.Web.Optimization;

namespace WebShop_Random
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

         //   < script src = "js/jquery.min.js" ></ script >
 
         //< script src = "js/bootstrap.min.js" ></ script >
  
         // < script src = "js/slick.min.js" ></ script >
   
         //  < script src = "js/nouislider.min.js" ></ script >
    
         //   < script src = "js/jquery.zoom.min.js" ></ script >
     
         //    < script src = "js/main.js" ></ script >

            bundles.Add(new ScriptBundle("~/bundles/js_them1").Include(
                      "~/Scripts/js/jquery.scrollUp.min.js",
                      "~/Scripts/js/bootstrap.min.js",
                      "~/Scripts/js/jquery.js",
                      "~/Scripts/js/price-range.js",
                      "~/Scripts/js/jquery.prettyPhoto.js",
                      "~/Scripts/js/main.js",
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css_them1").Include(
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/prettyPhoto.css",
                      "~/Content/css/css/price-range.css",
                      "~/Content/css/animate.css",
                      "~/Content/css/main.css",
                      "~/Content/css/responsive.css",
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/site.css"));

            //< link href = "https://fonts.googleapis.com/css?family=Montserrat:400,500,700" rel = "stylesheet" >

            //   < link type = "text/css" rel = "stylesheet" href = "css/slick.css" />

            // < link type = "text/css" rel = "stylesheet" href = "css/slick-theme.css" />


            //      < !--nouislider-- >

            //      < link type = "text/css" rel = "stylesheet" href = "css/nouislider.min.css" />


            //           < !--Font Awesome Icon -->

            //           < link rel = "stylesheet" href = "css/font-awesome.min.css" >


            //              < !--Custom stlylesheet-- >

            //              < link type = "text/css" rel = "stylesheet" href = "css/style.css" />
        }
    }
}
