
namespace Encapsulation;

internal class BeerEncapsulator
{

    public int AvailableCapsules
    {
        get => _avalaibleCapsules;
        set
        {
            if (value > 0)
                _avalaibleCapsules = value;
        }
    }

    public int AvailableBottles
    {
        get => _avalaibleBottles;
        set
        {
            if (value > 0)
                _avalaibleBottles = value;
        }
    }

    public double AvailableBeerVolume
    {
        get => _avalaibleBeerVolume;
        private set
        {
            if (value > 0)
                _avalaibleBeerVolume = value;
        }
    }

    public void AddBeer(double volume)
    {
        AvailableBeerVolume += volume;
    }

    public int ProduceEncapsulatedBeerBottles(int numBottles)
    {
        int bottlesProduced = 0;

        double requiredBeerVolume = numBottles * 33;

        if (AvailableBottles >= numBottles && AvailableCapsules >= numBottles && AvailableBeerVolume >= requiredBeerVolume)
        {
            bottlesProduced = numBottles;
            AvailableBeerVolume -= requiredBeerVolume;
            AvailableBottles -= numBottles;
            AvailableCapsules -= numBottles;
            Console.WriteLine($"{numBottles} bottles of beer produced and encapsulated.");
        }
        else Console.WriteLine("Insufficient components to produce the requested number of bottles.");

        return bottlesProduced;
    }

    // représente en centilitres le volume de bière disponible dans la machine :
    private double _avalaibleBeerVolume;

    // représente le nombre de bouteilles disponibles :
    private int _avalaibleBottles;

    // représente le nombre de capsules disponibles :
    private int _avalaibleCapsules;
}
