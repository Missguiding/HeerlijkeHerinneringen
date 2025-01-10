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
            CreateMap<Afbeelding, AfbeeldingViewModel>()
                .ForMember(dest => dest.AfbeeldingId, opt => opt.MapFrom(src => src.AfbeeldingId))
                .ForMember(dest => dest.AfbeeldingNaam, opt => opt.MapFrom(src => src.AfbeeldingNaam))
                .ForMember(dest => dest.AfbeeldingUrl, opt => opt.MapFrom(src => src.AfbeeldingUrl))
                .ForMember(dest => dest.ReceptId, opt => opt.MapFrom(src => src.ReceptId));
            CreateMap<AfbeeldingViewModel, Afbeelding>();
            // .ForMember(dest => dest.AfbeeldingId, opt => opt.MapFrom(src => src.AfbeeldingId))
            // .ForMember(dest => dest.AfbeeldingNaam, opt => opt.MapFrom(src => src.AfbeeldingNaam))
            //.ForMember(dest => dest.AfbeeldingUrl, opt => opt.MapFrom(src => src.AfbeeldingUrl))
            //.ForMember(dest => dest.ReceptId, opt => opt.MapFrom(src => src.ReceptId));

            CreateMap<Benodigdheid, BenodigdheidViewModel>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.BenodigdheidId))
               .ForMember(dest => dest.Naam, opt => opt.MapFrom(src => src.BenodigdheidNaam));
            CreateMap<BenodigdheidViewModel, Benodigdheid>()
                .ForMember(dest => dest.BenodigdheidId, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.BenodigdheidNaam, opt => opt.MapFrom(src => src.Naam));

            CreateMap<Chef, ChefViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ChefId))
                .ForMember(dest => dest.VoorNaam, opt => opt.MapFrom(src => src.ChefVoorNaam))
                .ForMember(dest => dest.FamilieNaam, opt => opt.MapFrom(src => src.ChefFamilieNaam));
            CreateMap<ChefViewModel, Chef >()
                .ForMember(dest => dest.ChefId, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.ChefVoorNaam, opt => opt.MapFrom(src => src.VoorNaam))
                .ForMember(dest => dest.ChefFamilieNaam, opt => opt.MapFrom(src => src.FamilieNaam));

            CreateMap<Ingredient, IngredientViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IngredientId))
              .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.IngredientName));
            CreateMap<IngredientViewModel, Ingredient>()
                 .ForMember(dest => dest.IngredientId, opt => opt.MapFrom(src => src.Id))
              .ForMember(dest => dest.IngredientName, opt => opt.MapFrom(src => src.Name));

            CreateMap<MenuGang, MenuGangViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.MenuGangId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.MenuGangName));
            CreateMap<MenuGangViewModel, MenuGang>()
                .ForMember(dest => dest.MenuGangId, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.MenuGangName, opt => opt.MapFrom(src => src.Name));


            CreateMap<ReceptBenodigdheid, ReceptBenodigdheidViewModel>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ReceptBenodigdheidId))
                .ForMember(dest => dest.Hoeveelheid, opt => opt.MapFrom(src => src.Hoeveelheid))
                .ForMember(dest => dest.Benodigdheid, opt => opt.MapFrom(src => src.Benodigdheid));
            CreateMap<ReceptBenodigdheidViewModel, ReceptBenodigdheid>();


            CreateMap<ReceptIngredient, ReceptIngredientViewModel>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ReceptIngredientId))
                .ForMember(dest => dest.Eenheid, opt => opt.MapFrom(src => src.Eenheid))
                .ForMember(dest => dest.Hoeveelheid, opt => opt.MapFrom(src => src.Hoeveelheid))
                .ForMember(dest => dest.NaamIngredient, opt => opt.MapFrom(src => src.Ingredient));
            CreateMap<ReceptIngredientViewModel, ReceptIngredient>();

            CreateMap<ReceptStap, ReceptStapViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ReceptStapId))
               .ForMember(dest => dest.Volgorde, opt => opt.MapFrom(src => src.Volgorde))
               .ForMember(dest => dest.Beschrijving, opt => opt.MapFrom(src => src.Beschrijving));
            CreateMap<ReceptStapViewModel, ReceptStap>();


            //AutoMapper haalt de juiste eigenschappen van recept op.
            CreateMap<Recept, ReceptViewModel>()
     .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ReceptId))
    .ForMember(dest => dest.ChefVoorNaam, opt => opt.MapFrom(src => src.Chef.ChefVoorNaam))
    .ForMember(dest => dest.ChefFamilieNaam, opt => opt.MapFrom(src => src.Chef.ChefFamilieNaam))
    .ForMember(dest => dest.MenuGang, opt => opt.MapFrom(src => src.MenuGang.MenuGangName))
    .ForMember(dest => dest.Temperatuur, opt => opt.MapFrom(src => src.Temperatuur.TemperatuurName))
    .ForMember(dest => dest.TypeGerecht, opt => opt.MapFrom(src => src.TypeGerecht.TypeGerechtName))
    .ForMember(dest => dest.Titel, opt => opt.MapFrom(src => src.Titel))  
    .ForMember(dest => dest.Afbeeldingen, opt => opt.MapFrom(src => src.Afbeeldingen))
    .ForMember(dest => dest.ReceptStaps, opt => opt.MapFrom(src => src.ReceptStaps))
    .ForMember(dest => dest.ReceptIngredients, opt => opt.MapFrom(src => src.ReceptIngredients))
    .ForMember(dest => dest.ReceptBenodigdheids, opt => opt.MapFrom(src => src.ReceptBenodigdheids));


            CreateMap<ReceptViewModel, Recept>()
                .ForPath(dest => dest.ReceptId, opt => opt.MapFrom(src => src.Id))
    .ForPath(dest => dest.Chef.ChefVoorNaam, opt => opt.MapFrom(src => src.ChefVoorNaam))
    .ForPath(dest => dest.Chef.ChefFamilieNaam, opt => opt.MapFrom(src => src.ChefFamilieNaam))
    .ForPath(dest => dest.MenuGang.MenuGangName, opt => opt.MapFrom(src => src.MenuGang))
    .ForPath(dest => dest.Temperatuur, opt => opt.MapFrom(src => src.Temperatuur))
    .ForPath(dest => dest.TypeGerecht.TypeGerechtName, opt => opt.MapFrom(src => src.TypeGerecht))
    .ForPath(dest => dest.Titel, opt => opt.MapFrom(src => src.Titel))
    .ForPath(dest => dest.Afbeeldingen, opt => opt.MapFrom(src => src.Afbeeldingen))
    .ForPath(dest => dest.ReceptStaps, opt => opt.MapFrom(src => src.ReceptStaps))
    .ForPath(dest => dest.ReceptIngredients, opt => opt.MapFrom(src => src.ReceptIngredients))
    .ForPath(dest => dest.ReceptBenodigdheids, opt => opt.MapFrom(src => src.ReceptBenodigdheids));


            CreateMap<Temperatuur, TemperatuurViewModel>()
                .ForMember(dest => dest.TemperatuurId, opt => opt.MapFrom(src => src.TemperatuurId))
               .ForMember(dest => dest.TemperatuurName, opt => opt.MapFrom(src => src.TemperatuurName));
            CreateMap<TemperatuurViewModel, Temperatuur>();

            CreateMap<TypeGerecht, TypeGerechtViewModel>();
            CreateMap<TypeGerechtViewModel, TypeGerecht>();
        }
    }
}
