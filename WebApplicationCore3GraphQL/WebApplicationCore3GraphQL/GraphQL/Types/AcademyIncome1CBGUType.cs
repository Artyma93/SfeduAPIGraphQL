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
    public class AcademyIncome1CBGUType : ObjectType<AcademyIncome1CBGU>
    {
        protected override void Configure(IObjectTypeDescriptor<AcademyIncome1CBGU> descriptor)
        {
            descriptor.Field(a => a.ID).Type<NonNullType<IdType>>().Description("Это айдишник");
            descriptor.Field(a => a.AcademyСategory).Type<StringType>().Description("Это название поля Академия в 1С БГУ");
            descriptor.Field(a => a.KindOfActivityСategory).Type<StringType>();
            descriptor.Field(a => a.BudgetSPСategory).Type<StringType>();
            descriptor.Field(a => a.BudgetIndicator).Type<DecimalType>();
            descriptor.Field(a => a.EstimateIndicator).Type<DecimalType>();
            descriptor.Field(a => a.CashIncomeIndicator).Type<DecimalType>();
            descriptor.Field(a => a.DifferenceFromEstimateIndicator).Type<DecimalType>();
            descriptor.Field(a => a.FormationDateReport).Type<DateTimeType>();
            descriptor.Field(a => a.ReportDate).Type<DateTimeType>();
            descriptor.Field(a => a.ReportPeriodStartDate).Type<DateTimeType>();
            descriptor.Field(a => a.ReportPeriodEndDate).Type<DateTimeType>();


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
