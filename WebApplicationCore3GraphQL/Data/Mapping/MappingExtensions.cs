using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Transport;
using WebApplicationCore3GraphQL.Infra.Data.Models;

namespace Data.Mapping
{
	public static class MappingExtensions
	{
		public static IMapper Mapper { get; }
		static MappingExtensions()
		{
			Mapper = new MapperConfiguration(cfg => {
				cfg.AddExpressionMapping();
				cfg.AddProfile<MappingProfile>();
			})
				.CreateMapper();
		}

		public static AcademyIncome1CBGU ToModel(this AcademyIncome1CBGUDbo entity)
		{
			return entity == null ? null : Mapper.Map<AcademyIncome1CBGU>(entity);
		}

		public static AcademyIncome1CBGUDbo ToEntity(this AcademyIncome1CBGU model)
		{
			return model == null ? null : Mapper.Map<AcademyIncome1CBGUDbo>(model);
		}

		public static AcademyIncome1CBGU ToModel(this AcademyIncome1CBGUDto dto)
		{
			return dto == null ? null : Mapper.Map<AcademyIncome1CBGU>(dto);
		}

		public static AcademyIncome1CBGUDto ToTransport(this AcademyIncome1CBGU model)
		{
			return model == null ? null : Mapper.Map<AcademyIncome1CBGUDto>(model);
		}

		public static AcademyIncome1CBGUDto ToTransport(this AcademyIncome1CBGUDbo dbo)
		{
			return dbo == null ? null : Mapper.Map<AcademyIncome1CBGUDto>(dbo);
		}
	}
}
