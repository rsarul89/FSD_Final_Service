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
    
    public partial class Skill
    {
        public Skill()
        {
            this.Associate_Skills = new HashSet<Associate_Skills>();
        }
    
        public int Skill_Id { get; set; }
        public string Skill_Name { get; set; }
    
        public virtual ICollection<Associate_Skills> Associate_Skills { get; set; }
    }
}
