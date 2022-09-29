using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbable : MonoBehaviour
{
    private Ray2D ray;
    private RaycastHit2D hit;
    private GameObject target = null;

    void Start()
    {
    }

    void Update()
    {
      if(Input.GetMouseButton(0)){
        Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(!target){
          RaycastHit2D hit = Physics2D.Raycast(point, Vector2.zero);

          if(hit.collider != null)
          {
            target = hit.collider.gameObject;
            EnemyMove targetScript = target.GetComponent<EnemyMove>();
            if(targetScript)
                targetScript.enabled = false;

            if(hit.collider.tag == "enemy"){
              Debug.Log("너는 범인이야!");
            } else{
              Debug.Log("너는 시민이야!");
            }
          }
        }
      } else {
        if(target) {
          EnemyMove targetScript = target.GetComponent<EnemyMove>();
          if(targetScript)
                targetScript.enabled = true;
        }
        target = null;
      }

      if(target){
        Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.transform.position = new Vector3(point.x, point.y, 0);
      }
    }
}
