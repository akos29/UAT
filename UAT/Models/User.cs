//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UAT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Modules = new HashSet<Module>();
            this.TestCases = new HashSet<TestCas>();
            this.TestDatas = new HashSet<TestData>();
        }
    
        public int uId { get; set; }
        public string UName { get; set; }
        public string Organization { get; set; }
        public string Department { get; set; }
        public string Previlage { get; set; }
    
        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<TestCas> TestCases { get; set; }
        public virtual ICollection<TestData> TestDatas { get; set; }
    }
}