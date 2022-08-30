using Core.DataAccess;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserGroupRepository : IEntityRepository<UserGroup>
    {
        Task<IEnumerable<SelectionItem>> GetUserGroupSelectedList(Guid userId);
        Task<IEnumerable<SelectionItem>> GetUsersInGroupSelectedListByGroupId(Guid groupId);
        Task BulkInsert(Guid userId, IEnumerable<UserGroup> userGroups);
        Task BulkInsertByGroupId(Guid groupId, IEnumerable<UserGroup> userGroups);
    }
}