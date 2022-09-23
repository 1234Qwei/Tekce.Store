using AutoMapper;
using Business.BusinessAspects;
using Core.Aspects.Autofac.Caching;
using Core.Entities;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Tekce.TableFilter.Models;

namespace Business.Handlers.Users.Queries
{
    public class GetUserDataSource : IRequest<IDataResult<DataSourceResult<User>>>
    {
        TableFilterModel Filter { get; set; }
        public class GetUserDataSourceHandler : IRequestHandler<GetUserDataSource, IDataResult<DataSourceResult<User>>>
        {
            private readonly IUserRepository _userRepository;
            private readonly IMapper mapper;

            public GetUserDataSourceHandler(IUserRepository userRepository, IMapper mapper)
            {
                _userRepository = userRepository;
                this.mapper = mapper;
            }

            [SecuredOperation(Priority = 1)]
            [CacheAspect(10)]
            public async Task<IDataResult<DataSourceResult<User>>> Handle(GetUserDataSource request, CancellationToken cancellationToken)
            {
                var list = await _userRepository.DataSourceAsync(request.Filter);
                return new SuccessDataResult<DataSourceResult<User>>(list);
            }
        }

    }
}
