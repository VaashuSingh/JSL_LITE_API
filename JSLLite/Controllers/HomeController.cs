using ESCommon;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Globalization;

namespace JSL_LITE.Controllers
{
    public class HomeController : Controller
    {

        string ConnectionString = ConfigurationManager.ConnectionStrings["ConString1"].ToString();
        private string WebApi = clsMain.MyString(System.Configuration.ConfigurationManager.AppSettings["WebApi"]);


        public ActionResult Index()
        {
            return View();
        }


        //[HttpGet]
        ////public ActionResult Login(FormCollection frm)
        ////{
        ////    string UserName = frm["UserName"];
        ////    string Pwd = frm["Pwd"];
        //public ActionResult Login(string UserName, string Pwd)
        //{
        //    //string UserName = UserName1;
        //    //string Pwd = Pwd1;

        //    try
        //    {
        //        HttpClient client = new HttpClient();
        //        client.BaseAddress = new Uri(WebApi + "api/Values/GetLogin");

        //        // Add an Accept header for JSON format.
        //        client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/json"));

        //        // List data response.
        //        HttpResponseMessage response = client.GetAsync("?UserId=" + UserName + "&Pwd=" + Pwd).Result;  // Blocking call!

        //        if (response.IsSuccessStatusCode)
        //        {
        //            var dataObjects = response.Content.ReadAsAsync<IEnumerable<User>>().Result;
        //            string ReturnPwd = "";
        //            bool isValidUser = false;

        //            foreach (var d in dataObjects)
        //            {

        //                Session["UserName"] = d.Name;
        //                Session["Code"] = d.Code;


        //                isValidUser = true;
        //                ReturnPwd = d.Pwd;
        //            }

        //            if (isValidUser)
        //            {
        //                if (clsMain.MyLen(ReturnPwd) > 0)
        //                {

        //                    return RedirectToAction("Index", "Home");


        //                }
        //                else
        //                {
        //                    return RedirectToAction("ChangePassword", "User");
        //                }
        //            }
        //            else
        //            {
        //                ViewBag.Error = "User Name Password Not Valid";
        //                return View();
        //            }
        //        }
        //        else
        //        {
        //            ViewBag.Error = "User Name Password Not Valid";
        //            return View();
        //        }
        //    }

        //    catch (Exception ex)
        //    {

        //        ViewBag.Error = ex.ToString();
        //        return View();
        //    }

        //    return View();
        //}
    }
}
