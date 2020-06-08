using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using GuitarShop.Models;
using PagedList;

namespace GuitarShop.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult SearchResult(string searchText, int? page)
        {
			var pageNumber = page ?? 1;
            var productDAO = new ProductDAO();

            ViewBag.searchText = searchText;

            var model = productDAO.SearchProduct(searchText);

			if(model.Count == 0)
			{
				ViewBag.SearchResultOverview = "Không tìm thấy sản phẩm nào!";
				return View(model.OrderBy(x => x.Id).ToPagedList(pageNumber, 12));
			}

			ViewBag.SearchResultOverview = "Kết quả tìm kiếm cho '"+searchText+"': " + model.Count() + " sản phẩm.";

			return View(model.OrderBy(x => x.Id).ToPagedList(pageNumber, 12));
        }
    }
}