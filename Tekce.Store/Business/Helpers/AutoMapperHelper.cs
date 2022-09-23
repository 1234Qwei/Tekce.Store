using AutoMapper;
using Castle.Core.Configuration;
using Core.DataAccess.EntityFramework;
using Core.Entities;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;

namespace Business.Helpers
{
    public class AutoMapperHelper : Profile
    {
        public AutoMapperHelper()
        {
            CreateMap<User, UserDto>().ReverseMap() ;
        }
    }




    //public class BaseDtoResolver<TSource, TTarget> : IValueResolver<TSource, TTarget, TTarget> where TSource : BaseEntity, IEntity where TTarget: BaseDto
    //{
    //    private IUserRepository userRepository;


    //    public BaseDtoResolver(IConfiguration configuration, IUserRepository userRepository)
    //    {
    //        this.userRepository = userRepository;
    //    }

    //    //public TTarget Resolve(TSource source, TTarget destination, TTarget destMember, ResolutionContext context)
    //    //{
    //    //    var listIds = new List<Guid?> {source.CreatedBy,source.ChangedBy }.Where(a=>a.HasValue).Select(a=>a.Value).Distinct();
    //    //    var userIds = userRepository.GetList(x => listIds.Contains(x.Id));
    //    //    return destination;
    //    //}
    //}
}