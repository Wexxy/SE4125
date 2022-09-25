using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private float xInput;
    private float zInput;
    public Rigidbody ball;
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal"); 
        zInput = Input.GetAxis("Vertical");  
    }

    void FixedUpdate()
    {
        ball.AddForce(new Vector3(xInput, 0, zInput)*speed);
    }
}
