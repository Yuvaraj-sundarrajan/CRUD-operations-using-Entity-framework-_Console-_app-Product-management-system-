namespace Ef_Productmanagement
{
    public class Delete{
       public void RemoveData()
{
    using (var context = new ProductContext())
    {
    
        
        Console.Write("Enter the Product Id :");
        int  isbnToRemove = Convert.ToInt32(Console.ReadLine());

        
        var ProductToRemove = context.Productdetails.FirstOrDefault(b => b.ProductID == isbnToRemove);

        if (ProductToRemove != null)
        {
       
            Console.WriteLine($"Removing Product - id: {ProductToRemove.ProductID}, Product name: {ProductToRemove.ProductName}");

     
            context.Productdetails.Remove(ProductToRemove);

            
            context.SaveChanges();

            Console.WriteLine("Removal successful!");
        }
        else
        {
            Console.WriteLine($"Product id is {isbnToRemove} not found.");
        }
    }
}


    }

}