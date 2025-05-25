namespace BaiTapLab3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;  // Tránh cảnh báo CS8618
        public int Price { get; set; }
    }
}
