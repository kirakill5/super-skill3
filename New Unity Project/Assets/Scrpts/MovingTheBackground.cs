//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTheBackground : MonoBehaviour
{
    

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.position +=2* Vector3.right * GetComponent<SpriteRenderer>().bounds.size.x;
            //This Linemoves the background to the right.
            //We use GetComponent<SpritRenderer>().bouns.size.x get the Backgrouds size
        }
    }

}
 