//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SkillTracker.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Associate
    {
        public Associate()
        {
            this.Associate_Skills = new HashSet<Associate_Skills>();
        }
    
        public int Associate_Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Pic { get; set; }
        public string Status_Green { get; set; }
        public string Status_Blue { get; set; }
        public string Status_Red { get; set; }
        public string Level_1 { get; set; }
        public string Level_2 { get; set; }
        public string Level_3 { get; set; }
        public string Remark { get; set; }
        public string Strength { get; set; }
        public string Weakness { get; set; }
    
        public virtual ICollection<Associate_Skills> Associate_Skills { get; set; }
    }
}
