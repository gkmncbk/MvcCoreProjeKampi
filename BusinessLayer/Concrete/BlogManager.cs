using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }


        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetListWithCategoryByWriterBm(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }
        public Blog TGetById(int id)
        {
            return _blogDal.GetById(id);
        }
        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }
        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }
        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetListAll().OrderByDescending(x => x.BlogID).Take(3).ToList();
        }

        //public List<Blog> GetBlogListWithCategory(int id)
        //{
        //    return _blogDal.GetBlogListWithCategory(id);

        //}
        public List<Blog> GetBlogListWithCategory(int id)
        {
            //throw new NotImplementedException();
            return _blogDal.GetBlogListWithCategory(id);
        }

        public Blog LastBlog()
        {
            return _blogDal.LastBlog();
        }
        public List<Blog> GetBlogListWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }
        //public List<Blog> GetBlogOtherListWriter(int WriterID, int BlogID)
        //{
        //    return _blogDal.GetBlogOtherListWriter(WriterID,BlogID);
        //}

        //public int GetBlogWriterID(int id)
        //{
        //    return _blogDal.GetBlogWriterID(id);
        //}

        //public List<Blog> GetBlogListLastThree()
        //{
        //    return _blogDal.GetBlogListLastThree();
        //}



        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }


    }
}
