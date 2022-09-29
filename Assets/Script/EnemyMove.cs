using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float Speed = 1.0f;
    public float LimitTime = 3.0f;

    private Vector2 direction = Vector2.zero;
    private float time = 0f;

    void Start(){
        GenerateDirection();
    }

    void Update()
    {
        time += Time.deltaTime;

        if(time >= LimitTime){
            time = 0f;

            GenerateDirection();
        }

        this.transform.Translate(direction * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "sidewall")
        {
          direction *= -1;
        }
    }

    private void GenerateDirection(){
        float randomX = Random.Range(-1.0f, 1.0f);
        float randomY = Random.Range(-1.0f, 1.0f);

        direction = new Vector2(randomX, randomY);
    }
}