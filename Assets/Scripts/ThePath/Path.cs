using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour {
    public Transform[] listPoint;

    public int starAt = 0;
    public int distanceMove = 1;
    public void OnDrawGizmos()
    {
        if (listPoint == null || listPoint.Length < 2)
            return;
        for (int i = 1; i < listPoint.Length; i++)
        {
            Gizmos.DrawLine(listPoint[i - 1].position, listPoint[i].position);
        }
    }

    public Transform getPointAt(int p)
    {
        return listPoint[p];
    }

    public Transform getNextPoint()
    {
        if (starAt == 0)
            distanceMove = 1;
        starAt += distanceMove;
        return listPoint[starAt];
    }
}
