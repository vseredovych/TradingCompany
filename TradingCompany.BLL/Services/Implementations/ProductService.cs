using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Services.Abstractions;
using TradingCompany.DAL.Models.Entities.Implementations;
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
        public IEnumerable<ProductDTO> GetAll()
        {
            List<ProductDTO> productsDTO = new List<ProductDTO>();
            foreach (var product in _unitOfWork.ProductsRepository.GetAll())
            {
                ProductDTO ProductDTO = _mapper.Map<Product, ProductDTO>(product);
                productsDTO.Add(ProductDTO);
            }
            return productsDTO;
        }
        public ProductDTO GetById(ulong id)
        {
            Product product = _unitOfWork.ProductsRepository.Get(new ProductFilter() { Id = id });
            ProductDTO ProductDTO = _mapper.Map<Product, ProductDTO>(product);
            return ProductDTO;
        }
        public bool Create(ProductDTO dto)
        {
            try
            {
                Product product = _mapper.Map<ProductDTO, Product>(dto);
                _unitOfWork.ProductsRepository.Create(product);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Update(ProductDTO dto)
        {
            try
            {

                Product product = _mapper.Map<ProductDTO, Product>(dto);
                _unitOfWork.ProductsRepository.Update(product, new ProductFilter() { Id = product.Id });
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Delete(ulong id)
        {
            try
            {
                _unitOfWork.ProductsRepository.Delete(new ProductFilter() { Id = id });
            }
            catch
            {
                return false;
            }
            return true;
        }
        public IEnumerable<string> GetProducts()
        {
            List<string> productNames = new List<string>();
            var products = _unitOfWork.ProductsRepository.GetAll();
            foreach (Product product in products)
            {
                productNames.Add(product.Name);
            }
            return productNames;
        }
    }
}
