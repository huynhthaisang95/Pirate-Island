using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPath : MonoBehaviour {

    public Path thePath;
    public float speed = 1f;
    private Transform _targetPoint;

	// Use this for initialization
	void Start () {
        if (thePath == null)
            return;

        transform.position = thePath.getPointAt(0).position;
        _targetPoint = thePath.getNextPoint ();
	}
	
	// Update is called once per frame
	void Update () {
        if (thePath == null)
            return;
        transform.position = Vector3.MoveTowards(transform.position,_targetPoint.position,speed * Time.deltaTime);

        var distanceTarget = (transform.position - _targetPoint.position).sqrMagnitude;
        if (distanceTarget < 0.1f)
        {
            //di chuyen toi diem tiep theo
            _targetPoint = thePath.getNextPoint();
        }
	}
}
