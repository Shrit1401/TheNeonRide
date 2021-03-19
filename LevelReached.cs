using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReached : MonoBehaviour
{

    public GameObject LevelComplete;
    public GameObject Rider;

    private void Start()
    {
        LevelComplete.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D hitinfo)
    {
        if (hitinfo.gameObject == Rider)
        {
            FindObjectOfType<AudioManager>().Play("Level");
            LevelComplete.SetActive(true);
        }
    }
}
