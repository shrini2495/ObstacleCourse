using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timeelapsed = 3;
    MeshRenderer renderer;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        
    } 

    // Update is called once per frame
    
    void Update()
    {
        if (Time.time > timeelapsed)
        {
            renderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
