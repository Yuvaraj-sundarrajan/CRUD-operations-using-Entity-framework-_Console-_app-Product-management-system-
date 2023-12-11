namespace Ef_Productmanagement
{
    public class Update
    {
        public void UpdateData()
        {
            using (var context = new ProductContext())
            {

                Console.Write("Enter your ProductID ");
                int Productid = Convert.ToInt32(Console.ReadLine());

                var ProductToUpdate = context.Productdetails.FirstOrDefault(b => b.ProductID == Productid);

                if (ProductToUpdate != null)
                {
                    Console.WriteLine("Updating  values into the tables: ");
                    Console.WriteLine("What you want to update");
                    Console.WriteLine("1.Name \n 2.Quality\n 3.Price");
                    int updatechoice = Convert.ToInt32(Console.ReadLine());
                    switch (updatechoice)
                    {
                        case 1:
                            Console.WriteLine($"Current Name: {ProductToUpdate.ProductName}");
                            Console.Write("Enter new Product Name : ");
                            string newname = Console.ReadLine();
                            ProductToUpdate.ProductName = newname;
                            break;
                        case 2:
                            
                            Console.WriteLine($"Current Domain: {ProductToUpdate.ProductQuantity}");
                            Console.Write("Enter new  Product Quantity: ");
                            string newQuantity = Console.ReadLine();
                            ProductToUpdate.ProductQuantity = newQuantity;
                            break;
                        case 3:
                            Console.WriteLine($"Current Location: {ProductToUpdate.ProductPrice}");
                            Console.Write("Enter new Price: ");
                            string newPrice = Console.ReadLine();
                            ProductToUpdate.ProductPrice = newPrice;
                            break;

                    }
                    context.SaveChanges();
                }

                else
                {
                    Console.WriteLine($"Product Id {Productid} not found.");
                }
            }
        }



    }

}