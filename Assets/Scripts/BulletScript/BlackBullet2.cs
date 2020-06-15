using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBullet2 : MonoBehaviour {

    public float Bulletspeed;
    private Rigidbody2D mybody;


    // Use this for initialization
    void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mybody.velocity = new Vector2(0f, -Bulletspeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            if (GamePlayController.instance == true)
            {
                GamePlayController.instance.BoatDiedShowPanel();
            }
            else
            {
                GamePlayController2.instance.BoatDiedShowPanel();
            }
        }
        

        if (collision.tag == "Border")
        {
            Destroy(gameObject);
        }

    }
}
