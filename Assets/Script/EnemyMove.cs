using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyMove : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public float Speed = 1.0f;
    public float LimitTime = 3.0f;

    private float time = 0f;
    private Vector2 direction = Vector2.zero;
    private RectTransform rectTransform;
    private Collider2D collider;
    private bool isGrab = false;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        collider = GetComponent<Collider2D>();
        SetDirection();
    }

    void Update()
    {
        Move();
        time += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "sidewall")
        {
            direction *= -1;
            time = 0f;
        }
    }

    private void Move()
    {
        if(isGrab)
            return;

        if(time >= LimitTime) 
        {
            time = 0f;
            SetDirection();
        }

        this.transform.Translate(direction * Speed * Time.deltaTime);
    }

    private void SetDirection()
    {
        float randomX = Random.Range(-1.0f, 1.0f);
        float randomY = Random.Range(-1.0f, 1.0f);

        direction = new Vector2(randomX, randomY);
    }

  public void OnBeginDrag(PointerEventData eventData)
  {
      isGrab = true;
      if(collider.tag == "enemy")
      {
          Debug.Log("너는 범인이야!");
      } 
      else 
      {
          Debug.Log("너는 시민이야!");
      }
  }

  public void OnDrag(PointerEventData eventData)
  {
      rectTransform.anchoredPosition += eventData.delta;
  }

  public void OnEndDrag(PointerEventData eventData)
  {
      isGrab = false;
  }
}