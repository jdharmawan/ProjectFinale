using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyDisplay : MonoBehaviour
{
    public Slider slider;
    public Profile profile;

    void Update()
	{
        SetEnergy(profile.energy);
	}

    public void SetMaxEnergy(int energy)
    {
        //slider.maxValue = energy;
        slider.value = energy;
    }

    public void SetEnergy(int energy)
    {
        slider.value = energy;
    }
}
