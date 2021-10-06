
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

        // 4 adet ülke içeren list üreten bir metot.
        public static List<CityViewModel> GetCityList()
        {
            return new List<CityViewModel>()
            {
                new CityViewModel() {  CityID= 1, CityName = "Ankara" },
                new CityViewModel() {  CityID= 2, CityName = "İstanbul" },
                new CityViewModel() {  CityID= 3, CityName = "Bursa" },
                new CityViewModel() {  CityID= 4, CityName = "İzmir" },
            };
        }
    }
}
