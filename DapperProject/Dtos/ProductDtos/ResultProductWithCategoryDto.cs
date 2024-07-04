namespace DapperProject.Dtos.ProductDtos
{
    public class ResultProductWithCategoryDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
    }
}
