using SkillTracker.Entities;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace SkillTracker.Repositories
{
    public class SkillsRepository : GenericRepository<Skill>, ISkillsRepository
    {
        public SkillsRepository(DbContext context)
           : base(context) { }

        public Skill AddSkill(Skill skill)
        {
            Add(skill);
            return skill;
        }

        public void DeleteSkill(Skill skill)
        {
            Delete(skill);
        }

        public IEnumerable<Skill> GetAllSkills()
        {
           return  GetAll();
        }

        public Skill GetSkill(int skill_Id)
        {
            return FindBy(sk => sk.Skill_Id == skill_Id)
                .FirstOrDefault();
        }

        public Skill UpdateSkill(Skill skill)
        {
            Update(skill);
            return skill;
        }
    }
}
