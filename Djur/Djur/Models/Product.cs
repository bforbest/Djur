using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Djur.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required()]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sed ex diam. Donec ut eros nec odio vulputate ultrices. Sed sit amet accumsan tellus. Fusce ultrices mauris in sodales vehicula. Duis a leo ut magna ullamcorper mattis eget a leo. Sed turpis mauris, maximus id facilisis eget, accumsan ornare eros. Etiam ut sagittis dolor. Vestibulum molestie dolor sit amet orci ultricies viverra. Donec ut accumsan orci.";
        public string Category { get; set; } = "Others";
    }
}