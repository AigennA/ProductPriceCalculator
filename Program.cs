namespace ProductPricecalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Price Calculator");
            Console.WriteLine("How many products do you wanna buy?");
            var totalProducts = int.Parse(Console.ReadLine());

            Console.WriteLine("How much do you wanna pay for each product");
            var price = int.Parse(Console.ReadLine());

            Console.WriteLine("How much is the VAT in procent?"); //Asking to user
            var vat = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            if (vat <= 0)
            {
                totalPrice = CalculatePrice(totalProducts, price);
            }
            else
            {
                totalPrice = CalculatePrice(totalProducts, price, vat);
            }
            Console.WriteLine($"Total price inc. VAT:{totalPrice} kr");

            //Lagt till default-parameter för moms
        }

        private static double CalculatePrice(
            int totalProducts,
            int price,
            double vat = 0.20)
        {
            var totalPrice = (totalProducts) * (1 + vat);
            return totalPrice;
        }
        //Visar totalprice
    }
}
