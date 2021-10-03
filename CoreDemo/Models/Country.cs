
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class Country
    {
        [Key]
        public int WriterCityID { get; set; }
        public string CountryName { get; set; }

        // 4 adet ülke içeren list üreten bir metot.
        public static List<Country> GetFakeCountries()
        {
            return new List<Country>()
            {
                new Country() {  WriterCityID= 1, CountryName = "Morocco" },
                new Country() {  WriterCityID= 2, CountryName = "American Samoa" },
                new Country() {  WriterCityID= 3, CountryName = "New Zealand" },
                new Country() {  WriterCityID= 4, CountryName = "Channel Islands" },
            };
        }
    }
}
