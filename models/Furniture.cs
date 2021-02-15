namespace csharp1.Models
{
  class Furniture
  {
    public float Price { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }


    public Furniture(float price, string name, int quantity)
    {
      Price = price;
      Name = name;
      Quantity = quantity;
    }
  }
}