using DapperProject.Dtos.ProductDtos;
using DapperProject.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> ProductList()
        {
            var values=await _productService.GetAllProductAsync();
            return View(values);
        }


        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productService.GetAllProductWithCategoryAsync();
            return View(values);
        }

        public async Task<IActionResult> ProductListWithCategoryProcedure()
        {
            var values = await _productService.GetAllProductWithCategoryProcAsync();
            return View(values);
        }


        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateProductAsync(createProductDto);
            return RedirectToAction("ProductList");
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productService.DeleteProductAsync(id);
            return RedirectToAction("ProductList");
        }



        public async Task<IActionResult> UpdateProduct(int id)
        {
            var value=await _productService.GetByIdProductAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProductAsync(updateProductDto);
            return RedirectToAction("ProductList");
        }

        public async Task<IActionResult> ProductCount()
        {
            int value= await _productService.GetProductCountAsync();
            ViewBag.a = value;
            return View();
        }
    }
}
