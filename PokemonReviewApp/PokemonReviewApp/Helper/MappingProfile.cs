using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
    public class MappingProfile :Profile
    {
        public MappingProfile() 
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<PokemonDto, Pokemon>();
            
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
            
            CreateMap<Review, ReviewDto>();
            CreateMap<ReviewDto,Review>();
            
            CreateMap<Reviewer, ReviewerDto>();
            CreateMap<ReviewerDto, Reviewer>();
            
            CreateMap<Owner, OwnerDto>();
            CreateMap<OwnerDto, Owner>();
        }
    }
}
