using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastLevel : MonoBehaviour
{
    public void TellMe()
    {
        int social = Random.Range(0, 4);
        if(social == 0)
        {
            Application.OpenURL("https://www.instagram.com/shrit1401");
        }

        else if(social == 1)
        {
            Application.OpenURL("https://shrit1401.itch.io/");
        }

        else if(social == 2)
        {
            Application.OpenURL("https://github.com/Shrit1401/");
        }

        else if (social == 3)
        {
            Application.OpenURL("https://www.snapchat.com/add/shrit1401");
        }

        else if(social == 4)
        {
            Application.OpenURL("www.shritdevelopment.ml");
        }
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game is over dead Person");
    }
}
