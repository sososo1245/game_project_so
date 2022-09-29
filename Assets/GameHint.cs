using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHint : MonoBehaviour
{
    public GameObject Hint; // 힌트 이미지
    public Button btnHint; // 힌트 보기 버튼
    // Start is called before the first frame update
    void Start()
    {
        Hint.SetActive(true); //시작할 때 힌트 보이게

        if (Input.GetMouseButton(0))
        {
            Hint.SetActive(false);

            btnHint.onClick.AddListener(ShowHint);
        }

        void ShowHint()
        {
            Hint.SetActive(true);
            Invoke("HideHint", 2);

        }

        // Update is called once per frame
        void HideHint()
        {
            Hint.SetActive(false);
        }
    }
}