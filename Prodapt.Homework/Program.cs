using System;

namespace Prodapt.Homework
{
    public class Purchace
    {
        string purchaceId, paymentType, shippingAddress;
        int quantityOrdered, price, totalBillAmount;
        double calculateBillAmount;
        DateTime dateOfPurchase;

        public Purchace(string purchaceId, string paymentType, string shippingAddress, int quantityOrdered, int totalBillAmount, DateTime dateOfPurchase)
        {
            this.purchaceId = purchaceId;
            this.paymentType = paymentType;
            this.shippingAddress = shippingAddress;
            this.quantityOrdered = quantityOrdered;
            this.dateOfPurchase = dateOfPurchase;
            this.totalBillAmount = totalBillAmount;
        }

        public Purchace()
        {
            
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"PurchaceId:{purchaceId}\nPayment:{paymentType}\nQuantity:{quantityOrdered}\nDate:{dateOfPurchase}\nTotal Amount:{totalBillAmount}");
        }

        public void CalculateBillAmount()
        {
            Console.WriteLine("Enter Purchace Id:");
            purchaceId = Console.ReadLine();

            Console.WriteLine("Enter Payment Type:");
            paymentType = Console.ReadLine();

            Console.WriteLine("Enter Shipping Address:");
            shippingAddress = Console.ReadLine();

            Console.WriteLine("Enter Quantity Ordered:");
            quantityOrdered = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Date:");
            dateOfPurchase = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter Price:");
            price = Convert.ToInt32(Console.ReadLine());

            totalBillAmount = quantityOrdered * price;
            totalBillAmount = (int)Convert.ToDouble(totalBillAmount);
            Console.WriteLine(totalBillAmount);
            
        }
        static void Main(string[] args)
        {
            Purchace obj = new Purchace();
            obj.CalculateBillAmount();
            obj.DisplayDetails();
        }
    }
}
