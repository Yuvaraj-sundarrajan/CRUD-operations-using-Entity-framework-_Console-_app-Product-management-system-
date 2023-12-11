using System.Text;

namespace Ef_Productmanagement
{
    public class Read
    {
        public void PrintData()
        {

            using (var context = new ProductContext())
            {


                foreach (var Productdetails in context.Productdetails)
                {
                    var data = new StringBuilder();
                    data.AppendLine($"Product ID: {Productdetails.ProductID}");
                    data.AppendLine($"Product Name: {Productdetails.ProductName}");
                    data.AppendLine($"Product Quantity: {Productdetails.ProductQuantity}");
                    data.AppendLine($"Product Price: {Productdetails.ProductPrice}");

                    Console.WriteLine(data.ToString());
                }
            }

      


        }

    }


}


