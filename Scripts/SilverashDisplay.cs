using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SilverashDisplay : MonoBehaviour
{
    public Slider slider;
    public Profile profile;

    void Update()
    {
        SetChemistry(profile.SAChemistry);
    }

    public void SetMaxEnergy(int energy)
    {
        //slider.maxValue = energy;
        slider.value = energy;
    }

    public void SetChemistry(int chemistry)
    {
        slider.value = chemistry;
    }
}
