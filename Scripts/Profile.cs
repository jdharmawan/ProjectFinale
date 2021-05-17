using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profile : MonoBehaviour
{
    public string playerName;
    public int gold;
    public int energy;
    public int houseCount;
    public int barnCount;
    public int foodCount;
    public int JAChemistry;
    public int SAChemistry;

    private List<BuildingPreset> buildings = new List<BuildingPreset>();

    //public EnergyDisplay energyBar;


    public void PurchaseBuilding (BuildingPreset building)
    {
        gold -= building.cost;
        energy -= 1;

       // energyBar.SetEnergy(energy);

        if (building.displayName == "House")
            houseCount += 1;
        else if (building.displayName == "Barn")
            barnCount += 1;
    }

    //This entire function should have been another Scriptable Object called food. Not applied right now.
    //The conditional functions should be done in a separate class, but not applied now.
    public void PurchaseFood ()
	{
        if (gold > 500)
		{
            gold -= 500;
            foodCount += 1;
        }
        
	}

    public void ConsumeFood()
	{
        if(foodCount > 0)
		{
            energy += 1;
            foodCount -= 1;
        }

    }
}
