using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using COM.ZUOMANE.Models;

namespace COM.ZUOMANE.Portal.Areas.Admin.Controllers
{
	public class ArticleCategoryController : Controller
	{
		private BLL.ArticleCategoryBLL articleCategoryBLL = new BLL.ArticleCategoryBLL();

		//
		// GET: /ArticleCategory/

		public ActionResult Index()
		{
			return View(articleCategoryBLL.GetAll());
		}

		//
		// GET: /ArticleCategory/Details/5

		public ActionResult Details(int id = 0)
		{
			ArticleCategory articlecategory = articleCategoryBLL.Find(id);
			if (articlecategory == null)
			{
				return HttpNotFound();
			}
			return View(articlecategory);
		}

		//
		// GET: /ArticleCategory/Create

		public ActionResult Create()
		{
			return View();
		}

		//
		// POST: /ArticleCategory/Create

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(ArticleCategory articlecategory)
		{
			if (ModelState.IsValid)
			{
				articleCategoryBLL.Create(articlecategory);

				return RedirectToAction("Index");
			}

			return View(articlecategory);
		}

		//
		// GET: /ArticleCategory/Edit/5

		public ActionResult Edit(int id = 0)
		{
			ArticleCategory articlecategory = articleCategoryBLL.Find(id);
			if (articlecategory == null)
			{
				return HttpNotFound();
			}
			return View(articlecategory);
		}

		//
		// POST: /ArticleCategory/Edit/5

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(ArticleCategory articlecategory)
		{
			if (ModelState.IsValid)
			{
				articleCategoryBLL.Edit(articlecategory);
				return RedirectToAction("Index");
			}
			return View(articlecategory);
		}

		//
		// GET: /ArticleCategory/Delete/5

		public ActionResult Delete(int id = 0)
		{
			ArticleCategory articlecategory = articleCategoryBLL.Find(id);
			if (articlecategory == null)
			{
				return HttpNotFound();
			}
			return View(articlecategory);
		}

		//
		// POST: /ArticleCategory/Delete/5

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			articleCategoryBLL.Delete(id);
			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			articleCategoryBLL.Dispose();
			base.Dispose(disposing);
		}
	}
}