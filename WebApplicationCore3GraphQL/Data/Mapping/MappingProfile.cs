using AutoMapper;
using Data.Models;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Transport;

namespace Data.Mapping
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // BGU - BGUDbo
            this.CreateMap<Academy1CBGU, Academy1CBGUDbo>()
                .ReverseMap();

            this.CreateMap<AcademyIncome1CBGU, AcademyIncome1CBGUDbo>()
                .ReverseMap();

            // BGU - BGUDto
            this.CreateMap<AcademyIncome1CBGU, AcademyIncome1CBGUDto>()
                .ReverseMap();

            this.CreateMap<Academy1CBGU, Academy1CBGUDto>()
                .ReverseMap();

            // BGUDbo - BGUDto
            this.CreateMap<AcademyIncome1CBGUDbo, AcademyIncome1CBGUDto>()
                .ReverseMap();

            this.CreateMap<AcademyIncome1CBGUDbo, AcademyIncome1CBGUDto>()
                .ReverseMap();
        }
    }
}
