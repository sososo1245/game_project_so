using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousemove : MonoBehaviour
{
    private Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0.0f));
            this.transform.position = mousePos;
        }


    }
}
