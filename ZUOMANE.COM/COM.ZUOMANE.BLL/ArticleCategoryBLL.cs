using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using COM.ZUOMANE.DAL;
using COM.ZUOMANE.Models;
using System.Data.Entity;

namespace COM.ZUOMANE.BLL
{
	public class ArticleCategoryBLL
	{
		/// <summary>
		/// 数据库上下文
		/// </summary>
		private DAL.COMZUOMANEDatabaseContext db = new DAL.COMZUOMANEDatabaseContext();

		public IList<Models.ArticleCategory> GetAll()
		{
			return db.ArticleCategories.ToList();
		}

		public ArticleCategory Find(int id)
		{
			return db.ArticleCategories.Find(id);
		}

		public void Create(ArticleCategory articlecategory)
		{
			db.ArticleCategories.Add(articlecategory);
			db.SaveChanges();
		}

		public void Edit(ArticleCategory articlecategory)
		{
			db.Entry(articlecategory).State = EntityState.Modified;
			db.SaveChanges();
		}

		public void Delete(int id)
		{
			ArticleCategory articlecategory = db.ArticleCategories.Find(id);
			db.ArticleCategories.Remove(articlecategory);
			db.SaveChanges();
		}

		public void Dispose()
		{
			db.Dispose();
		}
	}
}
