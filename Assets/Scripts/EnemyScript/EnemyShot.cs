using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour {


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
        yield return new WaitForSeconds(2f);
        Instantiate(BlackBullet2, temp, Quaternion.identity);
        StartCoroutine(Shot());
    }
}
