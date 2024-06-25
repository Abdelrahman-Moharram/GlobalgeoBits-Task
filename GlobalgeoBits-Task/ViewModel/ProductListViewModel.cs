using GlobalgeoBits_Task.Models;

namespace GlobalgeoBits_Task.ViewModel
{
    public class ProductListViewModel
    {
        public List<Product>? Products { get; set; }
        public int? Page {  get; set; }
        public int? TotalPages { get; set; }

        public int? size { get; set; }
    }
}
