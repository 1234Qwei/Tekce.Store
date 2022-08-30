using Core.DataAccess;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserClaimRepository : IEntityRepository<UserClaim>
    {
        Task<IEnumerable<SelectionItem>> GetUserClaimSelectedList(Guid userId);
        Task<IEnumerable<UserClaim>> BulkInsert(Guid userId, IEnumerable<UserClaim> userClaims);
    }
}