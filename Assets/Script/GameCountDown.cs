using UnityEngine;
using System.Collections;

public class GameCountDown : MonoBehaviour
{
    public GameObject First;   //1번
    public GameObject Second;   //2번
    public GameObject Third;   //3번
    public GameObject Montage;
    public ObjectManager ObjectManager;


    void Start()
    {
        StartCoroutine(GameStart());
    }

    IEnumerator GameStart()
    {
        Montage.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        Montage.SetActive(false);
        Third.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        Third.SetActive(false);
        Second.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        Second.SetActive(false);
        First.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        First.SetActive(false);

        if(ObjectManager != null)
        {
            ObjectManager.Generate();
        }
    }
}