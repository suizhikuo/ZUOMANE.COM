using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcApplicationTest.Models;

namespace MvcApplicationTest.Controllers
{
    public class ArticleCategoriesController : Controller
    {
        private LocalHostDB db = new LocalHostDB();

        // GET: ArticleCategories
        public async Task<ActionResult> Index()
        {
            return View(await db.ArticleCategories.ToListAsync());
        }

        // GET: ArticleCategories/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticleCategory articleCategory = await db.ArticleCategories.FindAsync(id);
            if (articleCategory == null)
            {
                return HttpNotFound();
            }
            return View(articleCategory);
        }

        // GET: ArticleCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticleCategories/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Name,Description,SortNum,IsDelete,RecordStatus,CreateUser,CreateDatetime,LastUpdateUser,LastUpdateDatetime")] ArticleCategory articleCategory)
        {
            if (ModelState.IsValid)
            {
                db.ArticleCategories.Add(articleCategory);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(articleCategory);
        }

        // GET: ArticleCategories/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticleCategory articleCategory = await db.ArticleCategories.FindAsync(id);
            if (articleCategory == null)
            {
                return HttpNotFound();
            }
            return View(articleCategory);
        }

        // POST: ArticleCategories/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Name,Description,SortNum,IsDelete,RecordStatus,CreateUser,CreateDatetime,LastUpdateUser,LastUpdateDatetime")] ArticleCategory articleCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(articleCategory).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(articleCategory);
        }

        // GET: ArticleCategories/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticleCategory articleCategory = await db.ArticleCategories.FindAsync(id);
            if (articleCategory == null)
            {
                return HttpNotFound();
            }
            return View(articleCategory);
        }

        // POST: ArticleCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ArticleCategory articleCategory = await db.ArticleCategories.FindAsync(id);
            db.ArticleCategories.Remove(articleCategory);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
