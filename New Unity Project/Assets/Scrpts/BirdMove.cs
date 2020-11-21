using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed = 5f;
       //to edit variable from the inspector even if it's private:
    [SerializeField]
    private float flapForce = 20f;
       //Use this for initialization
    void Start()
    {
            //Get a reference to the Rigibody
        rb2d = GetComponent<Rigidbody2D>();
            //Go right
        rb2d.velocity = Vector2.right * speed * Time.deltaTime;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.UpArrow))
        {
                //Reset Velocity
            rb2d.velocity = Vector2.right * speed * Time.deltaTime;
                //Add UP force to tjr=e bird
            rb2d.AddForce(Vector2.up * flapForce);
        }
    }
}
