using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerReef2 : MonoBehaviour {

    [SerializeField]
    private GameObject reef2;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(1);
        Vector3 temp = transform.position;
        temp.x = Random.Range(-2.9f, 2.9f);
        Instantiate(reef2, temp, Quaternion.identity);
        StartCoroutine(Spawner());
    }
}
