using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadOnLand : MonoBehaviour
{
    public CarController cc;

    private void Update()
    {
        if(cc == null)
        {
            this.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D hitinfo)
    {
        if (hitinfo.CompareTag("lr"))
        {
            //nothing
        }
        else 
        {
            cc.Dead();
        }
    }
}
