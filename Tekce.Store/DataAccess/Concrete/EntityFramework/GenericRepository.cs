using Core.DataAccess.EntityFramework;
using Core.Entities;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class GenericRepository<TEntity> : EfEntityRepositoryBase<User, ProjectDbContext> where TEntity : BaseEntity, IEntity
    {
        public GenericRepository(ProjectDbContext context) : base(context)
        {
        }
    }


}
