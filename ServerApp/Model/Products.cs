using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ServerApp.Model
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }



        public string name { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string imageUrl { get; set; }

    }
}
