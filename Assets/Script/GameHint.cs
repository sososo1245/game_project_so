using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHint : MonoBehaviour
{
    public GameObject Hint; // 힌트 이미지

    private IEnumerator coroutine;
    
    public void OnClickHintButton()
    {
        if (coroutine == null)
        {
            coroutine = ShowHint();
        }
        
        StartCoroutine(coroutine);
    }

    IEnumerator ShowHint()
    {
        Hint.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        Hint.SetActive(false);
    }
}