using System.Collections.Generic;

public class Fuel
{
    // private fields
    private float currentFuel;
    private Dictionary<string, float> fuelTypes;
    private Queue<float> recentUsage;

    // public property
    public float CurrentFuel
    {
        get { return currentFuel; }
    }

    // constructor
    public Fuel(float startingFuel)
    {
        currentFuel = startingFuel;
        fuelTypes = new Dictionary<string, float>();
        recentUsage = new Queue<float>();
    }

    // add a fuel type (ex: "Basic" = 10, "Premium" = 25)
    public void AddFuelType(string type, float amount)
    {
        fuelTypes[type] = amount;
    }

    // reduces fuel
    public void Consume(float amount)
    {
        if (currentFuel <= 0)
            return;

        currentFuel -= amount;

        if (currentFuel < 0)
            currentFuel = 0;

        // store last few usages
        recentUsage.Enqueue(amount);

        if (recentUsage.Count > 10)
            recentUsage.Dequeue();
    }

    // increases fuel using a fuel type
    public void Refuel(string type)
    {
        if (fuelTypes.ContainsKey(type))
        {
            currentFuel += fuelTypes[type];
        }
    }
}
