//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarDrobeMvcProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Top
    {
        public int TopID { get; set; }
        public string TopName { get; set; }
        public string TopPhoto { get; set; }
        public int TypeID { get; set; }
        public string Color { get; set; }
        public int SeasonID { get; set; }
        public string Occasion { get; set; }
    
        public virtual Season Season { get; set; }
        public virtual Type Type { get; set; }
    }
}
