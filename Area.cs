//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Area
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public int CityId { get; set; }
        public string Pincode { get; set; }
    
        public virtual City City { get; set; }
    }
}
