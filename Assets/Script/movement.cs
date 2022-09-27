using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "right")
            Physics2D.gravity = new Vector2(9.8f,0);
        if (coll.gameObject.tag == "botoom")
            Physics2D.gravity = new Vector2(0, -9.8f);
        if (coll.gameObject.tag == "left")
            Physics2D.gravity = new Vector2(-9.8f, 0);
    }
}
