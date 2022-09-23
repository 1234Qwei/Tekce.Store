using System.Collections.Generic;

namespace Core.Entities
{
    public class DataSourceResult<TEntity>where TEntity:IEntity
    {
        public IEnumerable<TEntity> Data{ get; set; }
        public int Total{ get; set; }





    }
}
