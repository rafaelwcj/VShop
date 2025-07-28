using AutoMapper;
using EcommerceMicroservice.DTOs;
using EcommerceMicroservice.Models;
using EcommerceMicroservice.Repositories;

namespace EcommerceMicroservice.Services
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsEntity = await _productRepository.GetAll();
            return _mapper.Map<IEnumerable<ProductDTO>>(productsEntity);
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var productsEntity = await _productRepository.GetById(id);
            return _mapper.Map<ProductDTO>(productsEntity);
        }

        public async Task AddProduct(ProductDTO productDTO)
        {
            var productEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.Create(productEntity);
        }

        public async Task UpdateProduct(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
