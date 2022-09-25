using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject ball;
    public float xOffset, yOffset, zOffset;

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(ball.transform.position);
    }
}
