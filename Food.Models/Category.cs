using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Food.Models
{
    public class Category
    {
        [Key] //Identify CategoryId as a Primary Key
        public int CategoryId { get; set; }

        [Required] //Identify Name as a required attribute
        [Display(Name="Category Name")] 
        public string Name { get; set; }

        [Required] //Identify Name as a required attribute
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }

    }
}
