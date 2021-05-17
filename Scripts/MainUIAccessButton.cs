using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIAccessButton : MonoBehaviour
{
    public void GoToFarm()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToTavern()
    {
        SceneManager.LoadScene(2);
    }
}
