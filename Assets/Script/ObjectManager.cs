using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject BlueSquarePrefab;
    public GameObject RedSquarePrefab;
    public GameObject GreenSqurePrefab;
    public GameObject EnemyPrefab;

    GameObject[] BlueSquare;
    GameObject[] RedSquare;
    GameObject[] GreenSqure;

    GameObject[] targetPool;
    GameObject Enemy;

    void Start()
    {   
        BlueSquare = new GameObject[10];
        RedSquare = new GameObject[10];
        GreenSqure = new GameObject[10];
        Enemy = new GameObject();
    }

    public void Generate()
    {
        for (int index = 0; index < BlueSquare.Length; index++)
        {
            BlueSquare[index] = Instantiate(BlueSquarePrefab);
            BlueSquare[index].transform.SetParent(this.transform);
            BlueSquare[index].GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;
        }
        for (int index = 0; index < RedSquare.Length; index++)
        {
            RedSquare[index] = Instantiate(RedSquarePrefab);
            RedSquare[index].transform.SetParent(this.transform);
            RedSquare[index].GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;
        }
        for (int index = 0; index < GreenSqure.Length; index++)
        {
            GreenSqure[index] = Instantiate(GreenSqurePrefab);
            GreenSqure[index].transform.SetParent(this.transform);
            GreenSqure[index].GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;
        }
        Enemy = Instantiate(EnemyPrefab);
        Enemy.transform.SetParent(this.transform);
        Enemy.GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;
    }
}