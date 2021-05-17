using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseCountDisplay : MonoBehaviour
{
    public Text houseCountText;

    public Profile profile;

    void Update()
    {
        houseCountText.text = profile.houseCount.ToString();

    }
}
