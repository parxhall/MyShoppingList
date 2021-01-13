using System;
using System.ComponentModel.DataAnnotations;

namespace MyShoppingList.Models
{
    [MetadataType(typeof(ListMetadata))]
    public partial class LIST
    {
    }

    [MetadataType(typeof(PersonMetadata))]
    public partial class PERSON
    {
    }

    [MetadataType(typeof(RecipeMetadata))]
    public partial class RECIPE
    {
    }

    [MetadataType(typeof(ItemMetadata))]
    public partial class ITEM
    {
    }

}