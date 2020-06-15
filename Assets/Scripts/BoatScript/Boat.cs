using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour {

    public float Boatspeed;
    private Rigidbody2D mybody;
    


    // Use this for initialization
    void Awake() {
        mybody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        BoatMovement();
    }

    void BoatMovement()
    {
        float xAxis = Input.GetAxisRaw("Horizontal") * Boatspeed;
        float yAxis = Input.GetAxisRaw("Vertical") * Boatspeed;
        mybody.velocity = new Vector2(xAxis, yAxis);
    }

   
}
