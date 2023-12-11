namespace Ef_Productmanagement{
    public class Create{
        public void InsertData()
    {
      using(var context = new ProductContext())
      {
        
        context.Database.EnsureCreated();
        Console.WriteLine("Enter Product ID :");
        int pid =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Product Name :");
        string pname = Console.ReadLine();
        Console.WriteLine("Enter the Product Quantity :");
        string pq = Console.ReadLine();
        Console.WriteLine("Enter the Product price :");
        string pp= Console.ReadLine();
        context.Productdetails.Add(new Product
        {
          ProductID=pid,
          ProductName=pname,
          ProductQuantity=pq,
          ProductPrice=pp
        });
    
        context.SaveChanges();
      }
    }
        
    }

}