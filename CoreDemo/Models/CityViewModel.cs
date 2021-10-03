using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class CityViewModel
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }
      

    }

}
