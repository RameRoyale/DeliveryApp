using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string? login { get; set; }
        public string? password { get; set; }
        public string? type_user { get; set; }
        public static User? currentUser { get; set; }
    }

    public class Product
    {
        [Key]
        public int id_product { get; set; }
        public string? name_product { get; set;}
        public string? description { get; set; }
        public string image { get; set; }
        public int? price { get; set; }
        public static Product? currentProduct { get; set; }
    }
}
