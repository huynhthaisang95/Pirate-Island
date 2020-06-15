using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Enemy : MonoBehaviour {


	//private Rigidbody2D myBody;


	// Use this for initialization
	/*void Awake () {
		myBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		myBody.velocity = new Vector2 (0f, -EnemySpeed);
	}*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
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
    }
}
