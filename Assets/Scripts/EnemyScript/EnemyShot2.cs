using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot2 : MonoBehaviour {
    [SerializeField]
    private GameObject BlackBullet2;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Shot());
    }


    IEnumerator Shot()
    {
        Vector3 temp = transform.position;
        temp.y += -0.8f;
        float x = Random.Range(0, 10f);
        yield return new WaitForSeconds(x);
        Instantiate(BlackBullet2, temp, Quaternion.identity);
        StartCoroutine(Shot());
    }
}
