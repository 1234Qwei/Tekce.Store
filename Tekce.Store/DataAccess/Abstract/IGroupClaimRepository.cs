using Core.DataAccess;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Core.Entities;

namespace DataAccess.Abstract
{
    public interface IGroupClaimRepository : IEntityRepository<GroupClaim>
    {
        Task<IEnumerable<SelectionItem>> GetGroupClaimsSelectedList(Guid groupId);
        Task BulkInsert(Guid groupId, IEnumerable<GroupClaim> groupClaims);
    }

    public interface IGenericRepository<TEntity> : IEntityRepository<TEntity> where TEntity : BaseEntity,IEntity
    {
    
    }
}