﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MelodyShop.DataAccessLayer
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;

  public partial class Cart
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Cart()
    {
      this.DataToOrders = new HashSet<DataToOrder>();
    }

    public int id { get; set; }

    public int productId { get; set; }

    [Display(Name = "Ilość")]
    public int quantity { get; set; }

    [Display(Name = "Cena")]
    public decimal? price { get; set; }

    public virtual Product Product { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<DataToOrder> DataToOrders { get; set; }
  }
}
