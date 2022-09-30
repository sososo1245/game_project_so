using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Grabbable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Vector2 prevPosition;
    private GameObject target;
    private EnemyMove targetScript;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        prevPosition = rectTransform.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        // prevPosition = eventData.position;
        Vector2 point = Input.mousePosition;
        RaycastHit2D hit = Physics2D.Raycast(point, Vector2.zero);

        if(hit) {
            
          if(hit.collider != null)
          {
            target = hit.collider.gameObject;
            Debug.Log(target);
          }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        // Vector2 offset = eventData.position - prevPosition;
        // prevPosition = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
    }

    // void Update()
    // {
    //   if(Input.GetMouseButton(0)){ 
    //     Vector2 point = Input.mousePosition;

    //     if(!target){
    //       RaycastHit2D hit = Physics2D.Raycast(point, Vector2.zero);

    //       if(hit.collider != null)
    //       {
    //         target = hit.collider.gameObject;
    //         EnemyMove targetScript = target.GetComponent<EnemyMove>();
    //         if(targetScript)
    //             targetScript.enabled = false;

    //         if(hit.collider.tag == "enemy"){
    //           Debug.Log("너는 범인이야!");
    //         } else{
    //           Debug.Log("너는 시민이야!");
    //         }
    //       }
    //     }
    //   } else {
    //     if(target) {
    //       EnemyMove targetScript = target.GetComponent<EnemyMove>();
    //       if(targetScript)
    //             targetScript.enabled = true;
    //     }
    //     target = null;
    //   }

    //   if(target){
    //     Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //     target.transform.position = new Vector3(point.x, point.y, 0);
    //   }
    // }
}
