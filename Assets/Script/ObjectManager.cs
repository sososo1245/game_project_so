using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject BlueCirclePrefab;
    public GameObject RedCirclePrefab;
    public GameObject GreenSqurePrefab;

    GameObject[] BlueCircle;
    GameObject[] RedCircle;
    GameObject[] GreenSqure;

    GameObject[] targetPool;


    void Awake()
    {

        BlueCircle = new GameObject[10];
        RedCircle = new GameObject[10];
        GreenSqure = new GameObject[10];

        Generate();



    }

    void Generate()
    {
        for (int index = 0; index < BlueCircle.Length; index++)
        {
            BlueCircle[index] = Instantiate(BlueCirclePrefab);
        }
        for (int index = 0; index < RedCircle.Length; index++)
        {
            RedCircle[index] = Instantiate(RedCirclePrefab);
        }
        for (int index = 0; index < GreenSqure.Length; index++)
        {
            GreenSqure[index] = Instantiate(GreenSqurePrefab);
        }
    }

    public GameObject MakeObj(string type)
    {
        switch(type)
        {
            case "BlueCircle":
                targetPool = BlueCircle;
                break;
            case "RedCircle":
                targetPool = RedCircle;
                break;
            case "GreenSqure":
                targetPool = GreenSqure;
                break;

        }

        for (int index = 0; index < BlueCircle.Length; index++)
        {

            if (!targetPool[index].activeSelf)
            {
                targetPool[index].SetActive(true);


            }
        }

        return null;     

           
        

    }
}