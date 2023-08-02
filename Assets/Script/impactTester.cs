using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impactTester : MonoBehaviour
{
    //We want this script to handle COLLISIONS and TRIGGER detection!
    //When our object impacts another, we want to PRINT TEXT

    //first, collisions...

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ouch!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

        //Destroy object
        Destroy(collision.gameObject);
    }

    //Next, triggers...


}

