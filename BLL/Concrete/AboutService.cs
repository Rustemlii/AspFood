using AutoMapper;
using BLL.Abstract;
using DAL.Context;
using DAL.Entity;
using DTO.DtoEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class AboutService : BaseService<AboutDto, About, AboutDto>, IAbout
    {
        public AboutService(IMapper mapper, MyContext context) : base(mapper, context)
        {
        }
    }
}
