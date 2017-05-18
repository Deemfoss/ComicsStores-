using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ComicsStores.Models
{
    
    public class Product
    {
        [Required(ErrorMessage = "Заполните все поля")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Заполните все поля")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Заполните все поля")]
        public string Price { get; set; }
        [Required(ErrorMessage = "Заполните все поля")]
        public string Discription { get; set; }
        [Required(ErrorMessage = "Заполните все поля")]
        public string Brand { get;  set; }
        [Required(ErrorMessage = "Заполните все поля")]
    
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Заполните все поля")]
        public string Url { get; set; }
        [Required(ErrorMessage = "Заполните все поля")]
        public int Category { get; set; }
    //   public Category Category { get; set; }
  //public  Purchas Purchas { get; set; }

    }


public class Category
    {
       public int Id { get; set; }
       public string Name { get; set; }
        
       //public  Product Product { get; set; }
    }



}