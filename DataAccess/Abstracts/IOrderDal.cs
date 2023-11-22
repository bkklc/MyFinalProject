using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IOrderDal : IEntityRepository<Order>
    {
    }
}
