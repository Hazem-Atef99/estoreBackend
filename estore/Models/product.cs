using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace estore.Models
{
    public class product
    {
        [Key]
        public int productID { get; set; }
        public string productName { get; set; }
        public string price { get; set; }
        public string discount { get; set; }
        [NotMapped]
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string ImageName { get; set; }
        public string productDescription { get; set; }
        public string category { get; set; }
        public Boolean isAddedToCart { get; set; }
        public Boolean isAddedToCheckout { get; set; }
        public Boolean inConfomation { get; set; }

        public Boolean isSlider { get; set; }
        public Boolean isCategory { get; set; }
        public Boolean isLatestProduct { get; set; }
        public Boolean isBestProduct { get; set; }
        public Boolean isBestCollection { get; set; }
        public Boolean isLatestOffer { get; set; }
        public Boolean isgallery { get; set; }
      


    }
}
