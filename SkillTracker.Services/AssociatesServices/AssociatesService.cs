using SkillTracker.Entities;
using SkillTracker.Repositories;
using System.Collections.Generic;

namespace SkillTracker.Services
{
    public class AssociatesService : EntityService<Associate>, IAssociatesService
    {
        IUnitOfWork unitOfWork;
        IAssociatesRepository associatesRepository;

        public AssociatesService(IUnitOfWork unitOfWork, IAssociatesRepository associatesRepository) : base(unitOfWork, associatesRepository)
        {
            this.unitOfWork = unitOfWork;
            this.associatesRepository = associatesRepository;
        }
        public Associate CreateAssociate(Associate associate)
        {
            return associatesRepository.AddAssociate(associate);
        }

        public IEnumerable<Associate> GetAllAssociates()
        {
            return associatesRepository.GetAllAssociates();
        }

        public Associate GetAssociate(int associate_Id)
        {
            return associatesRepository.GetAssociate(associate_Id);
        }

        public void RemoveAssociate(Associate associate)
        {
            associatesRepository.DeleteAssociate(associate);
        }

        public Associate UpdateAssociate(Associate associate)
        {
            return associatesRepository.UpdateAssociate(associate);
        }
    }
}
