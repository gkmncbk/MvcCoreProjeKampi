using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
        List<Blog> GetList();
        Blog GetById(int id);
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListWriter(int id);
        //
        List<Blog> GetBlogListWithCategory(int id);
        List<Blog> GetBlogListLastThree();
        Blog LastBlog();
        //List<Blog> GetBlogOtherListWriter(int WriterID,int BlogID );
        //int GetBlogWriterID(int id);

    }
}
