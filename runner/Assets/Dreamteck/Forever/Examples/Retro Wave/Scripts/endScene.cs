using Dreamteck.Forever;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScene : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Gem"))
        {
            EndScreen.Open();
            Debug.Log("boinga");
        }

        if (other.gameObject.CompareTag("Gem"))
        {
            ScoreScript.scoreValue += 1;
        }
    }
}
