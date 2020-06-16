using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBullet : MonoBehaviour {

    [SerializeField]
    private GameObject BlackBullet;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Shot());
    }

    IEnumerator Shot()
    {
        Vector3 temp = transform.position;
        temp.y += 0.8f;
        yield return new WaitForSeconds(0.2f);
        Instantiate(BlackBullet, temp, Quaternion.identity);
        StartCoroutine(Shot());
    }
}
