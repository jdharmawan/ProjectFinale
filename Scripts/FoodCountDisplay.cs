using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodCountDisplay : MonoBehaviour
{
    public Text foodCountText;

    public Profile profile;

    void Update()
    {
        foodCountText.text = profile.foodCount.ToString();

    }
}
