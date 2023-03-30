using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour

   
{

    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

   void MovePlayer()
    {
        float Zvalue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float Xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(Xvalue, 0, Zvalue);
    }
}
