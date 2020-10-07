using Dreamteck.Forever;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScene : MonoBehaviour
{
    

    private void OnCollisionStay(Collision collision)
    {
        EndScreen.Open();
    }

    public void OnCollisionEnter(Collision collision)
    {
        EndScreen.Open();
        Debug.Log("boing");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Gem"))
        {
            EndScreen.Open();
            Debug.Log("boinga");
        }
    }
}
