using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldDisplay : MonoBehaviour
{
    public Text goldText;

    public Profile profile;

    void Update()
    {
        goldText.text = profile.gold.ToString();

    }
}
