using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AutoMapper;
using HeerlijkeHerinneringen.Data.Models;
using HeerlijkeHerinneringen.Libraries.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HeerlijkeHerinneringen.Libraries.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //AutoMapper haalt de juiste eigenschappen van recept op.
            CreateMap<Recept, ReceptViewModel>()
                .ForMember(dest => dest.Chef, opt => opt.MapFrom(src => src.Chef.ChefNaam))
                .ForMember(dest => dest.MenuGang, opt => opt.MapFrom(src => src.MenuGang.MenuGangName))
                .ForMember(dest => dest.Temperatuur, opt => opt.MapFrom(src => src.Temperatuur.TemperatuurName))
                .ForMember(dest => dest.TypeGerecht, opt => opt.MapFrom(src => src.TypeGerecht.TypeGerechtName))
                .ForMember(dest => dest.Titel, opt => opt.MapFrom(src => src.Titel))
                .ForMember(dest => dest.Afbeelding, opt => opt.MapFrom(src => src.Afbeelding))
                .ForMember(dest => dest.ReceptStaps, opt => opt.MapFrom(src => src.ReceptStaps))
                .ForMember(dest => dest.Benodigdheids, opt => opt.MapFrom(src => src.Benodigdheids));
            CreateMap<ReceptViewModel, Recept>();

            CreateMap<ReceptStap, ReceptStapViewModel>()
                .ForMember(dest => dest.Volgorde, opt => opt.MapFrom(src => src.Volgorde))
                .ForMember(dest => dest.Volgorde, opt => opt.MapFrom(src => src.Beschrijving));
            CreateMap<ReceptStapViewModel, ReceptStap>();

            CreateMap<Benodigdheid, BenodigdheidViewModel>()
                .ForMember(dest => dest.Naam, opt => opt.MapFrom(src => src.Naam));
            CreateMap<BenodigdheidViewModel, Benodigdheid>();

            CreateMap<Ingredient, IngredientViewModel>();
            CreateMap<IngredientViewModel, Ingredient>();

            CreateMap<Chef, ChefViewModel>();
            CreateMap<ChefViewModel, Chef>();
        }
    }
}
