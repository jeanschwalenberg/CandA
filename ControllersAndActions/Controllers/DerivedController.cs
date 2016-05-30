using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers {
    public class DerivedController : Controller {

        public ActionResult Index() {
            ViewBag.Message = "Hello from the DerivedController Index method";
            return View("MyView");
        }

        public ActionResult ProduceOutput() {
            return Redirect("/Basic/Index");
        }

        //SLIGHTLY NEWER - more succinct - replaced with Redirect
        /*public ActionResult ProduceOutput() {
            return new RedirectResult("/Basic/Index");
        }*/

        //OLD - handwritten - replaced with built-in RedirectResult Object
        /*public void ProduceOutput() {
            if (Server.MachineName == "TINY") {
                Response.Redirect("/Basic/Index");
            } else {
                Response.Write("Controller: Derived, Action: ProduceOutput");
            }*/
        }
    }
