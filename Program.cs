namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeerEncapsulator beerEncapsulator = new BeerEncapsulator();
            beerEncapsulator.AvailableBottles = 5;
            beerEncapsulator.AvailableCapsules = 5;
            
            beerEncapsulator.AddBeer(33f);


            int qtyBottle = beerEncapsulator.ProduceEncapsulatedBeerBottles(1);

            Console.WriteLine("Capsule Quantity available : " + beerEncapsulator.AvailableCapsules);
            Console.WriteLine("Beer Quantity available : " + beerEncapsulator.AvailableBeerVolume);
            Console.WriteLine("Bottle Quantity available : " + qtyBottle);



        }
    }
}
