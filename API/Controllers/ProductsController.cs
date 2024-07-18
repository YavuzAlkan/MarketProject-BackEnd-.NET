using ApplicationCore.DTO_s.ProductDTO;
using ApplicationCore.Entities.Abstract;
using ApplicationCore.Entities.Concrete;
using AutoMapper;
using DataAccess.Services.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        [HttpGet("GetProducts")]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productRepository.GetFilteredListAsync
                (
                select: x => new GetProductDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    CategoryName=x.Category.Name,
                    Price = x.Price,
                    Quantity = x.Quantity,
                    CreatedDate = x.CreatedDate,
                    Status = x.Status,
                    UpdatedDate = x.UpdatedDate,
                    
                },
                    where: x => x.Status != Status.Passive,
                    orderBy: x => x.OrderByDescending(z => z.CreatedDate)
               );
            return Ok( products );
        }
        [HttpGet("GetProductById")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product= await _productRepository.GetByIdAsync(id);
            var dto = _mapper.Map<GetProductDTO>(product);
            if(dto is not null)
                return Ok( dto );
            return NotFound("Bu ID ye sahip bir ürün kaydı bulunmamaktadır.");
        }
        [HttpPost("CreateProduct")]
        public  async Task<IActionResult> CreateProduct([FromForm]CreateProductDTO dto)
        {
            if (dto == null)
            {
                return BadRequest("Bir şeyler ters gitti!!");
            }
            if ( await _productRepository.AnyAsync(x => x.Name == dto.Name))
            {
                return BadRequest("Bu isimde bir ürün var.Lütfen farklı bir isim giriniz!");
            }
            var product=_mapper.Map<Product>(dto);
            await _productRepository.AddAsync(product);
            return Ok($"Ürün başarıyla eklenmiştir! \n {product.Name} \n {product.Price} \n {product.Quantity} ");
        }
        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([FromForm]UpdateProductDTO updateProductDTO)
        {
            if( updateProductDTO == null)
            {
                return BadRequest("Bir şeyler ters gitti!!");
            }
            if(await _productRepository.AnyAsync(x=>x.Name == updateProductDTO.Name && x.Id != updateProductDTO.Id))
            {
                return BadRequest("Bu isimde bir ürün var.Lütfen farklı bir isim giriniz!!");
            }
            if(! await _productRepository.AnyAsync(z=>z.Id==updateProductDTO.Id && z.Status != Status.Passive))
            {
                return NotFound("Bu ID'ye sahip bir ürün bulunamadı!");
            }
            var entity = await _productRepository.GetByIdAsync(updateProductDTO.Id);
            var product = _mapper.Map<Product>(updateProductDTO);
            product.CreatedDate=entity.CreatedDate;
           await _productRepository.UpdateAsync(product);
            return Ok($"Kategori güncellenmiştir!\nKategori Bilgileri: \n {product.Name} \n {product.Price} \n {product.Quantity}");

        }
        [HttpDelete("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Bir şeyler ters gitti!!");
            }
            var product=await _productRepository.GetByIdAsync(id);
            if (product is null)
            {
                return NotFound("Aranan ürün bulunamadı!");
            }
           await _productRepository.DeleteAsync(product);
            return Ok("Ürün silinmiştir");
        }
    }
}
