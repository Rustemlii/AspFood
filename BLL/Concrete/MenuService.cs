using AutoMapper;
using BLL.Abstract;
using DAL.Context;
using DAL.Entity;
using DTO.DtoEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class MenuService : BaseService<MenuDto, Menu, MenuDto>, IMenu
    {
        public MenuService(IMapper mapper, MyContext context) : base(mapper, context)
        {
        }

        public IEnumerable<MenuDto> GetCategoryInclude()
        {
            var values = _Dbset.Include(x => x.Category).ToList();
            var sendDto=_mapper.Map<IEnumerable<MenuDto>>(values);
            return sendDto;
        }
    }
}
