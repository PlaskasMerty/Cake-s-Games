using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    public GameObject Parent;
    public GameObject[] Prefabs;
    public GameObject[] SpawnPoints;
    public float TimeSpawn;
    public int KOLVO;
    private int i = 1;

    void Start()
    {
        StartCoroutine(SpawnCD());
    }
    

    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(Prefabs[Random.Range(0, Prefabs.Length)], SpawnPoints[Random.Range(0, SpawnPoints.Length)].transform.position, Quaternion.identity, Parent.transform);
        if (i < KOLVO)
        {
            StartCoroutine(SpawnCD());
            i++;
        }
    }

    void Update()
    {
        if (i == KOLVO)
        {
            if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }

}
