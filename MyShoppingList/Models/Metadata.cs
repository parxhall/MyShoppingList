using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyShoppingList.Models
{
    public class ListMetadata
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id;
        [Required]
        [Display(Name = "Item")]
        public Nullable<int> item_id;
        [Required]
        [Display(Name = "Quantity")]
        public Nullable<int> quantity;
        [Required]
        [Display(Name = "Person")]
        public Nullable<int> person_id;

    }

    public class PersonMetadata
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id;
        [Required]
        [Display(Name = "First Name")]
        public string fname;
        [Display(Name = "Last Name")]
        public string lname;
        [Display(Name = "Shielding")]
        public Nullable<int> shielding_id;
    }

    public class RecipeMetadata
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id;
        [Required]
        [Display(Name = "Name")]
        public string name;
        [Display(Name = "Description")]
        public string description;
    }

    public class ItemMetadata
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id;
        [Required]
        [Display(Name = "Item")]
        public string item1;
        [Required]
        [Display(Name = "Brand")]
        public string brand;
        [Required]
        [Display(Name = "Size")]
        public string size;
    }
}