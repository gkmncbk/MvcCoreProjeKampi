using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
        List<Blog> GetListWithCategoryByWriter(int id);
        //
        List<Blog> GetBlogListWithCategory(int id);
        //List<Blog> GetBlogListLastThree();
        Blog LastBlog();
        //List<Blog> GetBlogOtherListWriter(int WriterID, int BlogID);
        //int GetBlogWriterID(int id);
    }

}
