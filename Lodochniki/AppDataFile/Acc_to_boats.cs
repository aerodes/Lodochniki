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
    
    public partial class Acc_to_boats
    {
        public int fit_id { get; set; }
        public int accessory_id { get; set; }
        public int boat_id { get; set; }
    
        public virtual Accessory Accessory { get; set; }
        public virtual Boat Boat { get; set; }
    }
}