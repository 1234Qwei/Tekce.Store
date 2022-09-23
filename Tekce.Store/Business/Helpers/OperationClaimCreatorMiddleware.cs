﻿using Business.BusinessAspects;
using Business.Fakes.Handlers.Authorizations;
using Business.Fakes.Handlers.OperationClaims;
using Business.Fakes.Handlers.UserClaims;
using Core.Utilities.IoC;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Business.Helpers
{
    public static class OperationClaimCreatorMiddleware
    {
        public static async Task UseDbOperationClaimCreator(this IApplicationBuilder app)
        {
            var mediator = ServiceTool.ServiceProvider.GetService<IMediator>();
            foreach (var operationName in GetOperationNames())
            {
                await mediator.Send(new CreateOperationClaimInternalCommand
                {
                    ClaimName = operationName
                });
            }

            var operationClaims = (await mediator.Send(new GetOperationClaimsInternalQuery())).Data;
            var user = await mediator.Send(new RegisterUserInternalCommand
            {
                
                FirstName = "System",
                LastName= "Admin",
                Password = "tekce2021.",
                Email = "admin@tekcee.com",
                Id=System.Guid.Empty
            });
            await mediator.Send(new CreateUserClaimsInternalCommand
            {
                UserId = System.Guid.Empty,
                OperationClaims = operationClaims
            });
        }

        private static IEnumerable<string> GetOperationNames()
        {
            var assemblies = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x =>
                    // runtime generated anonmous type'larin assemblysi olmadigi icin null cek yap
                    x.Namespace != null && x.Namespace.StartsWith("Business.Handlers") &&
                    (x.Name.EndsWith("Command") || x.Name.EndsWith("Query")));

            return (from assembly in assemblies
                    from nestedType in assembly.GetNestedTypes()
                    from method in nestedType.GetMethods()
                    where method.CustomAttributes.Any(u => u.AttributeType == typeof(SecuredOperation))
                    select assembly.Name).ToList();
        }
    }
}
