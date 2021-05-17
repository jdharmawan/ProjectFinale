using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarnCountDisplay : MonoBehaviour
{
    public Text barnCountText;

    public Profile profile;

    void Update()
    {
        barnCountText.text = profile.barnCount.ToString();

    }
}
