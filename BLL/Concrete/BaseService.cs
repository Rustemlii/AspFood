using AutoMapper;
using BLL.Abstract;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class BaseService<ReqDto, TEntity, ResDTO> : IBaseService<ReqDto, TEntity, ResDTO> where TEntity : class
    {

        protected readonly IMapper _mapper;
        protected readonly MyContext _context;
        protected readonly DbSet<TEntity> _Dbset;

        public BaseService(IMapper mapper, MyContext context)
        {
            _mapper = mapper;
            _context = context;
            _Dbset = context.Set<TEntity>();
        }

        void Save()
        {
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var ent = _Dbset.Find(id);//Axtarilir
            _Dbset.Remove(ent); //Silinir..
            Save();
        }
        public IEnumerable<ResDTO> GetAll()
        {
            var ent = _Dbset.ToList(); //Liste data elave olunur
            var rsDto = _mapper.Map<List<ResDTO>>(ent); //List DTO-ya kocurulur
            return rsDto;
        }
        public virtual ResDTO GetById(int id)
        {
            var ent = _Dbset.Find(id);// Bazada axtarilir
            var rsDto = _mapper.Map<ResDTO>(ent); // DTO-ya kocurulur
            return rsDto;
        }
        public virtual ResDTO Insert(ReqDto dto)
        {
            var ent = _mapper.Map<TEntity>(dto);//Bazadaki data Klasa kocurulur
            _Dbset.Add(ent);//Bazaya melumat elave olunur
            Save();//Yaddawda saxlanilir
            var rsDto = _mapper.Map<ResDTO>(ent);//DTO-ya kocurulur
            return rsDto;
        }
        public virtual void Update(ReqDto dto)
        {
            var ent = _mapper.Map<TEntity>(dto);//Bazadaki data Klasa kocurulur
            _Dbset.Update(ent);
            Save();
        }

    }
}
