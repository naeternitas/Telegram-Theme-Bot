//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThemeBot
{
    using System;
    using System.Collections.Generic;
    
    public partial class Download
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int ThemeID { get; set; }
        public System.DateTime TimeStamp { get; set; }
    
        public virtual Theme Theme { get; set; }
        public virtual User User { get; set; }
    }
}
