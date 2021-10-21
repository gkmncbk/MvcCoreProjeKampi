using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface IBlogService: IGenericService<Blog>
    {
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListWriter(int id);


        // Fazla eklenen-silinecek
        List<Blog> GetBlogListWithCategory(int id);
        //List<Blog> GetBlogListLastThree();
        Blog LastBlog();
        //List<Blog> GetBlogOtherListWriter(int WriterID,int BlogID );
        //int GetBlogWriterID(int id);

    }
}
