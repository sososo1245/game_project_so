using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbable : MonoBehaviour
{
    private Vector2 mousePos;
    private float length;

    // Start is called before the first frame update
    void Start()
    {
        length = this.GetComponent<CircleCollider2D>().radius;

    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0.0f));
            if (Vector2.Distance(mousePos , this.transform.position) < length)
            this.transform.position = mousePos;
            
        }
    }


    // Update is called once per frame

    private void OnTriggerStay2D(Collider2D mouse)
    {
        if (mouse.gameObject.tag == "Player")
        {
            this.transform.position = mouse.transform.position;
            Debug.Log(this.transform.position);
            Debug.Log(mouse.transform.position);
        }
    }
    
}
