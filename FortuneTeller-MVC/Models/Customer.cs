//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FortuneTeller_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int MonthID { get; set; }
        public int ColorID { get; set; }
        public int Siblings { get; set; }
    
        public virtual Color Color { get; set; }
        public virtual Month Month { get; set; }
    }
}