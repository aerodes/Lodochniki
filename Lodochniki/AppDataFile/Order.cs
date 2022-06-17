//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lodochniki.AppDataFile
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Contract = new HashSet<Contract>();
        }
    
        public int Order_ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Salesperson_ID { get; set; }
        public Nullable<int> Customer_ID { get; set; }
        public Nullable<int> Boat_ID { get; set; }
        public string DeliveryAddress { get; set; }
        public string City { get; set; }
    
        public virtual Boat Boat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contract { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Order_details Order_details { get; set; }
        public virtual Sales_person Sales_person { get; set; }
    }
}
