//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TracNghiemOnline.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class quests_of_test
    {
        public int ID { get; set; }
        public int test_code { get; set; }
        public int id_question { get; set; }
        public Nullable<System.DateTime> timestamps { get; set; }
    
        public virtual test test { get; set; }
        public virtual question question { get; set; }
    }
}
