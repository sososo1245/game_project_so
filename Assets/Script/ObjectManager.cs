using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject BlueCirclePrefab;
    public GameObject RedCirclePrefab;
    public GameObject GreenSqurePrefab;
    public GameObject EnemyPrefab;

    GameObject[] BlueCircle;
    GameObject[] RedCircle;
    GameObject[] GreenSqure;

    GameObject[] targetPool;
    GameObject Enemy;


<<<<<<< HEAD
    void Start()
    {   
=======
    void Awake()
    {
>>>>>>> 13b93d0a0fce4fff483e6929bb8aab4e4d550c38
        BlueCircle = new GameObject[10];
        RedCircle = new GameObject[10];
        GreenSqure = new GameObject[10];
        Enemy = new GameObject();

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
        Enemy = Instantiate(EnemyPrefab);
    }
}