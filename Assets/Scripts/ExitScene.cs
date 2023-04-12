using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitOnClick()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }
}
