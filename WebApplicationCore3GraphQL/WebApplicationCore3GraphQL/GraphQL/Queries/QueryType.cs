using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore3GraphQL.GraphQL.Types;
//using HotChocolate.Types.Filters;


namespace WebApplicationCore3GraphQL.GraphQL.Queries
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(t => t.GetAcademy1CBGUs(default))
                .Type<NonNullType<ListType<Academy1CBGUType>>>()
                .UsePaging<Academy1CBGUType>()
                .UseFiltering()
                .UseSorting()
                //.UseSelection()
                ;


            //descriptor.Field(t => t.GetAcademyIncome1CBGUs(default, default))
            descriptor.Field(t => t.GetAcademyIncome1CBGUs(default))
                //.Name("GetAcademyIncome1CBGUs2222")
                .Type<NonNullType<ListType<AcademyIncome1CBGUType>>>()
                //.Argument("academyС", a => a.Type<StringType>())
                //.UseSelection<AcademyIncome1CBGUType>()
                //.UseSelection()
                .UsePaging<AcademyIncome1CBGUType>()
                .UseFiltering()
                .UseSorting()
                ;

            //descriptor.Field("academy")
            //    .Argument("academyId", a => a.Type<NonNullType<IntType>>())
            //    .Type<NonNullType<ListType<NonNullType<AcademyIncome1CBGUType>>>>()

            //    ;

            //descriptor.Field(t => t.GetAcademyIncome1CBGU(default))
            //    .Type<NonNullType<AcademyIncome1CBGUType>>()
            //    .UseFiltering()
            //    ;
        }
    }
}
