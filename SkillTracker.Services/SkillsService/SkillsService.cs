using System.Collections.Generic;
using SkillTracker.Entities;
using SkillTracker.Repositories;

namespace SkillTracker.Services
{
    public class SkillsService : EntityService<Skill>, ISkillsService
    {
        IUnitOfWork unitOfWork;
        ISkillsRepository skillsRepository;

        public SkillsService(IUnitOfWork unitOfWork, ISkillsRepository skillsRepository) : base(unitOfWork, skillsRepository)
        {
            this.unitOfWork = unitOfWork;
            this.skillsRepository = skillsRepository;
        }
        public Skill CreateSkill(Skill skill)
        {
            skillsRepository.AddSkill(skill);
            unitOfWork.Commit();
            return skill;
        }

        public IEnumerable<Skill> GetAllSkills()
        {
            return skillsRepository.GetAllSkills();
        }

        public Skill GetSkill(int skill_Id)
        {
            return skillsRepository.GetSkill(skill_Id);
        }

        public void RemoveSkill(Skill skill)
        {
            skillsRepository.DeleteSkill(skill);
            unitOfWork.Commit();
        }

        public Skill UpdateSkill(Skill skill)
        {
            skillsRepository.UpdateSkill(skill);
            unitOfWork.Commit();
            return skill;
        }
    }
}
