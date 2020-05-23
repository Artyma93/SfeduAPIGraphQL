//using AutoMapper;
//using Data.Models;
//using Domain.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Transport;

//namespace WebApplicationCore3GraphQL.GraphQL.Mapping
//{
//	static class MappingExtensions
//	{
//		static MappingExtensions()
//		{
//			Mapper = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>())
//				.CreateMapper();
//		}

//		internal static IMapper Mapper { get; }

//		public static AcademyIncome1CBGU ToModel(this AcademyIncome1CBGUDto dto)
//		{
//			return dto == null ? null : Mapper.Map<AcademyIncome1CBGU>(dto);
//		}

//		public static AcademyIncome1CBGUDto ToTransport(this AcademyIncome1CBGU model)
//		{
//			return model == null ? null : Mapper.Map<AcademyIncome1CBGUDto>(model);
//		}

//		public static AcademyIncome1CBGUDto ToTransport(this AcademyIncome1CBGUDbo dbo)
//		{
//			return dbo == null ? null : Mapper.Map<AcademyIncome1CBGUDto>(dbo);
//		}
//	}
//}
