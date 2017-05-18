using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ComicsStores.Models
{
    public class User
    {
              public string Id { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
        
    }

    public class Log
    {
     [Required]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}