using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigations : MonoBehaviour
{
    public void NavigateToMarkerlessMode()
    {
        SceneManager.LoadScene("MarkerLess");
    }
    public void NavigateToMarkerBasedMode()
    {
        SceneManager.LoadScene("MarkerBased");
    }
}
