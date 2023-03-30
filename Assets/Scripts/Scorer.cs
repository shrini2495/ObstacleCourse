using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    // Start is called before the first frame update
    int hits = 0;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {

            hits++;
            Debug.Log("You've Bumped into this thing this many times -->" + hits);
        }
    }
}
