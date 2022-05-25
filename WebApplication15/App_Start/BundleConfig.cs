using System.Web;
using System.Web.Optimization;

namespace WebApplication15
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));



            bundles.Add(new StyleBundle("~/Content/mycss").Include(
               
"~/plugins/fontawesome-free/css/all.min.css",

"~/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
"~/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
"~/plugins/jqvmap/jqvmap.min.css",
"~/dist/css/adminlte.min.css",
"~/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
"~/plugins/daterangepicker/daterangepicker.css",
"~/plugins/summernote/summernote-bs4.min.css"));



            bundles.Add(new ScriptBundle("~/bundles/myScripts").Include(

"~/plugins/jquery/jquery.min.js",
                "~/plugins/jquery-ui/jquery-ui.min.js",
     "~/plugins/bootstrap/js/bootstrap.bundle.min.js",
                "~/plugins/chart.js/Chart.min.js",
                "~/plugins/sparklines/sparkline.js",
                "~/plugins/jqvmap/jquery.vmap.min.js",
                "~/plugins/jqvmap/maps/jquery.vmap.usa.js",
                "~/plugins/jquery-knob/jquery.knob.min.js",
                "~/plugins/moment/moment.min.js",
                "~/plugins/daterangepicker/daterangepicker.js",
                "~/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                "~/plugins/summernote/summernote-bs4.min.js",
                "~/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                "~/dist/js/adminlte.js",
                "~/dist/js/demo.js",
                "~/dist/js/pages/dashboard.js"


                ));

 



        }
    }
}
