using SmartPro.Core.DataAccess;
using SmartPro.Entities.Concrete;
using SmartPro.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.DataAccess.Abstraction
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDto> GetProductDtos();
    }
}
