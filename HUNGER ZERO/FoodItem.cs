//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HUNGER_ZERO
{
    using System;
    using System.Collections.Generic;
    
    public partial class FoodItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FoodItem()
        {
            this.FoodItem1 = new HashSet<FoodItem>();
        }
    
        public System.Guid FoodItemId { get; set; }
        public System.Guid CollectRequestId { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string ExpiryDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodItem> FoodItem1 { get; set; }
        public virtual FoodItem FoodItem2 { get; set; }
    }
}
