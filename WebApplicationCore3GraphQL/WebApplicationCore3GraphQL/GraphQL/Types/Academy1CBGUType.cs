using Domain.Models;
using GreenDonut;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore3GraphQL.GraphQL.Types
{
    public class Academy1CBGUType : ObjectType<Academy1CBGU>
    {
        protected override void Configure(IObjectTypeDescriptor<Academy1CBGU> descriptor)
        {
            descriptor.Field(a => a.ID).Type<NonNullType<IdType>>();
            descriptor.Field(a => a.Name).Type<StringType>().Authorize(new[] { "GroupAdmin", "GroupMember" }); ; 

            //descriptor.Field(a => a.Name).Type<Academy1CBGU>().Resolver(ctx =>
            //{
            //    IAcademy1CBGURepository repository = ctx.Service<IAcademy1CBGURepository>();
            //    IDataLoader<Guid, Academy1CBGU> dataLoader = ctx.BatchDataLoader<Guid, Academy1CBGU>(
            //        "Academy1CBGUById", repository.GetAcademy1CBGUsAsync);
            //    return dataLoader.LoadAsync(ctx.Parent<Academy1CBGU>().ID);
            //});
        }
    }
}
