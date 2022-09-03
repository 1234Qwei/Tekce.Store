using System.Collections.Generic;
using System.Linq;
using Tekce.TableFilter.Models;

namespace Tekce.TableFilter.Core
{
    public interface ITableFilterManager<out TEntity>
    {
        void MultipleOrderDataSet(TableFilterModel tableFilterPayload);
        void SingleOrderDataSet(TableFilterModel tableFilterPayload);
        void FilterDataSet(string key, TableFilterContext value);
        void FiltersDataSet(string key, IEnumerable<TableFilterContext> values);
        void ExecuteFilter();
        IQueryable<TEntity> GetResult();
    }
}