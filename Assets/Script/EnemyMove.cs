using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public GameObject BlueCirclePrefab;
    public GameObject RedCirclePrefab;
    public GameObject GreenSqurePrefab;
    


    public float nextMove;//행동지표를 결정할 변수
    public float max;
    public float min;
    public float speed = 1.0f;
    private Transform target;
    private float multiple;
    private float toward;
    private float direction;
    private Vector2 moving;
    [SerializeField] private float downspeed;




    // Start is called before the first frame update
    void Awake()
    {
        //rigid = GetComponent<Rigidbody2D>();
        //transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        //nextMove = Random.Range(-2.0f, 2.0f);
        //multiple = Random.Range(max, min);

        Invoke("Think", 0);
    }




    // Update is called once per frame
    void Update()
    {
        Vector2 pos = this.transform.position;
        pos += moving * Time.deltaTime;
        this.transform.position = pos; 


    }

    void Think()
    {

        moving = new Vector2(Random.Range(-5f, +5f), Random.Range(downspeed, 0f));
        Invoke("Think", 3);//재귀

        
    }

    private void OnTriggeStay2D(Collider2D coll)
    {
        if (coll.tag == "sidewall")
        {
            moving.x *= -1.0f;
            Debug.Log("coll");
        }


    }

    private void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "sidewall")
        {
            moving.x *= -1.0f;
           
        }

        Debug.Log("coll");

    }


}