using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private float xInput;
    private float zInput;
    public AudioSource[] sounds;
    public AudioSource win;
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

    void Awake() //before game start
    {
        ball = GetComponent<Rigidbody>();
        sounds = GetComponents<AudioSource>();
        win = sounds[0];
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Trap")
        {
            string currentScene = SceneManager.GetActiveScene().name; 

			SceneManager.LoadScene(currentScene);
            
        }
        else if(collision.gameObject.tag == "Finish")
        {
            win.Play();
        }
    }
}
