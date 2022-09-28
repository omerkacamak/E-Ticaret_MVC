using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.Abstract
{
    public interface IOrderDetailService : IGenericService<OrderDetail>
    {
        List<OrderDetail> getListWithProducts1(Expression<Func<OrderDetail, bool>> filter);
    }
}
