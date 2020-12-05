using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdMove : MonoBehaviour
{
    Rigidbody2D rb2d;
    bool isDead;
    public float speed = 5f;
       //to edit variable from the inspector even if it's private:
    
    //Use this for initialization
    [SerializeField]
    private float flapForce = 20f;

    public GameObject ReplayButton,startButton;

    int score = 0;
    public Text scoreText;
    void Start()
    {
        //Freze time 
        Time.timeScale = 0;

        ReplayButton.SetActive(false);
        //Get a reference to the Rigibody
        rb2d = GetComponent<Rigidbody2D>();
            //Go right
        rb2d.velocity = Vector2.right * speed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        isDead = true;
        rb2d.velocity = Vector2.zero;
        //Set the Replaybutton to active toshow it in the scene.
        ReplayButton.SetActive(true);
        //Change the isDead parameter of the animator to start the Dead animation
        GetComponent<Animator>().SetBool("death", true);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.UpArrow) && !isDead)
        {
                //Reset Velocity
            rb2d.velocity = Vector2.right * speed * Time.deltaTime;
                //Add UP force to tjr=e bird
            rb2d.AddForce(Vector2.up * flapForce);
        }
    }
    
    public void Replay()
    {
        //chaange the scene to the scene 0 in your builde settings
        SceneManager.LoadScene(0);
    }

    public void UnFreeze()
    {
        Time.timeScale = 1;
        startButton.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Score")
        {
            //Increment score
            score++;
            //Show the score in the console
            Debug.Log(score);
            scoreText.text = score.ToString();
        }
    }
}
