using AutoMapper;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using Core.Utilities.Results;
using DataAccess.Abstract;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Handlers.Authorizations.Queries
{
    public class LoggedUserQuery : IRequest<IDataResult<UserDto>>
    {      
        public class LoggedUserQueryHandler : IRequestHandler<LoggedUserQuery, IDataResult<UserDto>>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;

            public LoggedUserQueryHandler(IHttpContextAccessor httpContextAccessor, IUserRepository userRepository, IMapper mapper)
            {
                _httpContextAccessor = httpContextAccessor;
                _userRepository = userRepository;
                _mapper = mapper;
            }

            public async Task<IDataResult<UserDto>> Handle(LoggedUserQuery request, CancellationToken cancellationToken)
            {
                var userId = _httpContextAccessor.HttpContext?.User.Claims
            .FirstOrDefault(x => x.Type.EndsWith("nameidentifier"))?.Value;
                if (userId==null)
                {
                    throw new Exception(Messages.UserNotFound);
                }

                var user = _mapper.Map<User, UserDto>(await _userRepository.GetAsync(x => x.Id == new Guid(userId)));


                return new SuccessDataResult<UserDto>(user);
            }
        }
    }
}
