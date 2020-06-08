using GuitarShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using Model.EF;
using System.Configuration;
using GuitarShop.Common;
using System.IO;

namespace GuitarShop.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(MESSAGE contact)
        {
            if (ModelState.IsValid)
            {
                string content = System.IO.File.ReadAllText(Server.MapPath("~/Views/Home/MessageEmail.html"));

                content = content.Replace("{{CustomerName}}", contact.Name);
                content = content.Replace("{{Email}}", contact.Email);
                content = content.Replace("{{Title}}", contact.Title);
                content = content.Replace("{{Message}}", contact.Message_Content);

                var toEmail = ConfigurationManager.AppSettings["ToEmailAddress"].ToString();

                new MailHelper().SendMail(toEmail, contact.Title, content);

                ContactDAO contactDAO = new ContactDAO();

                var result = contactDAO.Insert(contact);

                if (result > 0)
                {
                    return Json(new { result = true, data = PartialViewToString("ContactForm", new MESSAGE()) });
                }
                else
                {
                    ModelState.AddModelError("", "Đã xảy ra lỗi, gửi không thành công!");
                }
            }
            return PartialView("ContactForm", contact);
        }

        //Render PartialView as Json
        private string PartialViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (StringWriter writer = new StringWriter())
            {
                ViewEngineResult vResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                ViewContext vContext = new ViewContext(this.ControllerContext, vResult.View, ViewData, new TempDataDictionary(), writer);
                vResult.View.Render(vContext, writer);
                return writer.ToString();
            }
        }
    }
}