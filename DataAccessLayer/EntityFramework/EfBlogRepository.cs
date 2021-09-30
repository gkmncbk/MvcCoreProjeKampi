using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetBlogListWithCategory(int id)
        {
            using (var c = new Context())
                return c.Blogs.Where(x => x.CategoryID == id).ToList();
        }

        public List<Blog> GetBlogOtherListWriter(int WriterID, int BlogID)
        {
            using (var c = new Context())
                return c.Blogs.Where(x => x.WriterID == WriterID && x.BlogID!=BlogID).ToList();
        }

        public int GetBlogWriterID(int id)
        {
            using (var c = new Context())
                return c.Blogs.Where(x => x.BlogID == id).FirstOrDefault().WriterID;
        }

        public List<Blog> GetListWithCategory()
        {
            using (var c = new Context())
                return c.Blogs.Include(x => x.Category).ToList();
        }

        public Blog LastBlog()
        {
            using (var c = new Context())
                return c.Blogs.OrderBy(u => u.BlogID).LastOrDefault();
        }
    }
}
