using SkillTracker.Entities;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace SkillTracker.Repositories
{
    public class AssociatesRepository : GenericRepository<Associate>, IAssociatesRepository
    {
        public AssociatesRepository(DbContext context)
           : base(context) { }
        public Associate AddAssociate(Associate associate)
        {
            Add(associate);
            return associate;
        }

        public void DeleteAssociate(Associate associate)
        {
            Delete(associate);
        }

        public IEnumerable<Associate> GetAllAssociates()
        {
            return GetAll();
        }

        public Associate GetAssociate(int associate_id)
        {
            return FindBy(a => a.Associate_Id == associate_id)
               .FirstOrDefault();
        }

        public Associate UpdateAssociate(Associate associate)
        {
            Update(associate);
            return associate;
        }
    }
}
