using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Services.Abstractions;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.UnitOfWork;

namespace TradingCompany.BLL.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper) { 
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<ProductDTO> GetProducts()
        {
            _unitOfWork.ProductsRepository.GetAll();
            return new List<ProductDTO>();
        }
    }
}
