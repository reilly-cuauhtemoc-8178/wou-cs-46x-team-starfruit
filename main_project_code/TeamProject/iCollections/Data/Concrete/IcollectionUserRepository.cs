using iCollections.Data.Abstract;
using iCollections.Models;
using System.Collections.Generic;
using System.Linq;

namespace iCollections.Data.Concrete
{
    public class IcollectionUserRepository : Repository<IcollectionUser>, IIcollectionUserRepository
    {
        public IcollectionUserRepository(ICollectionsDbContext ctx) : base(ctx) {}

        public virtual bool Exists(IcollectionUser user)
        {
            return _dbSet.Any(x => x.AspnetIdentityId == user.AspnetIdentityId 
                && x.FirstName == user.FirstName 
                && x.LastName == user.LastName);
        }

        public virtual IcollectionUser GetIcollectionUserByIdentityId(string identityID)
        {
            return _dbSet.Where(u => u.AspnetIdentityId == identityID).FirstOrDefault();
        }

        
    }
}