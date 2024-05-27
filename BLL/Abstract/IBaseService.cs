using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IBaseService<ReqDTO,TEntity,ResDto>
    {
        IEnumerable<ResDto> GetAll();
        ResDto GetById(int id);
        ResDto Insert(ReqDTO dto);
        void Update(ReqDTO dto);
        void Delete(int id);
    }
}
