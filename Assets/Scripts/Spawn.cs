using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Parent;
    public GameObject[] Prefabs;
    public GameObject[] SpawnPoints;
    void Start()
    {
        Instantiate(Prefabs[0], SpawnPoints[0].transform.position, Quaternion.identity, Parent.transform);
    }
}
