using AutoMapper;
using BookStore_API.Data;
using BookStore_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Author, AuthorDTO>()
                .ReverseMap();
            CreateMap<Author, AuthorCreateDTO>()
                .ReverseMap();
            //.ForMember(ad => ad.Firstname, opt=>opt.MapFrom(a => a.Firstname))
            //.ForMember(ad => ad.Lastname, opt => opt.MapFrom(a => a.Lastname))
            //.ForMember(ad => ad.Bio, opt => opt.MapFrom(a => a.Bio));
            CreateMap<Author, AuthorUpdateDTO>()
                .ReverseMap();
            CreateMap<Book, BookDTO>()
                .ReverseMap();
            CreateMap<Book, BookCreateDTO>()
                .ReverseMap();
            CreateMap<Book, BookUpdateDTO>()
                .ReverseMap();
        }
    }
}
