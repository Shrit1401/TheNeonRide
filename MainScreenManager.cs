using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScreenManager : MonoBehaviour
{
    public Toggle toggle;

    private void Update()
    {
        if(toggle.isOn == true)
        {
            FindObjectOfType<AudioManager>().UnMute();
        }

        else if (toggle.isOn == false)
        {
            FindObjectOfType<AudioManager>().Mute();
        }
    }

    public void StartPlaying(){
		SceneManager.LoadScene("Level01basic");
    }


    public void Quit(){
		Application.Quit();
		Debug.Log("Game is over dead person");
    }
}
