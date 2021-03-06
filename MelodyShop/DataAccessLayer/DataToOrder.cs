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

  public partial class DataToOrder
  {
    public int id { get; set; }

    [Display(Name = "Imię")]
    public string name { get; set; }

    [Display(Name = "Nazwisko")]
    public string surname { get; set; }

    [Display(Name = "Email")]
    public string email { get; set; }

    [Display(Name = "Numer Telefonu")]
    public string phoneNumber { get; set; }

    [Display(Name = "Ulica")]
    public string street { get; set; }

    [Display(Name = "Numer domu")]
    public string hoseNumber { get; set; }

    [Display(Name = "Kod pocztowy")]
    public string postalCode { get; set; }

    [Display(Name = "Miasto")]
    public string city { get; set; }

    [Display(Name = "Kraj")]
    public string country { get; set; }

    [Display(Name = "Uwagi do zamówienia")]
    public string messageToOrder { get; set; }

    public int cartId { get; set; }

    public virtual Cart Cart { get; set; }
  }
}
