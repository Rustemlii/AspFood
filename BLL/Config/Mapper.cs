using AutoMapper;
using DAL.Entity;
using DTO.DtoEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Config
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<AboutDto, About >();
            CreateMap<About, AboutDto>();

            CreateMap< CategoryDto, Category >();
            CreateMap<Category, CategoryDto>();

            CreateMap<ContactDto, Contact >();
            CreateMap<Contact, ContactDto>();

            CreateMap<CustomerDto,Customer > ();
            CreateMap<Customer, CustomerDto>();

            CreateMap<MenuDto, Menu >();
            CreateMap<Menu, MenuDto>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(x => x.Category.Name));
          

            CreateMap<MessageDto, Message >();
            CreateMap<Message, MessageDto>();
        }
    }
}
