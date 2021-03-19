using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouchDie : MonoBehaviour
{
    public CarController cc;

    private void OnTriggerEnter2D(Collider2D hitinfo)
    {
        if(hitinfo.CompareTag("Player"))
        {
            cc.Dead();
        }
    }
}
