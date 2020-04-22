using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowNegativ : MonoBehaviour
{
    public GameObject _hacker;
    public float  distance;
    public float angle;
    // Update is called once per frame
    
    void Update()
    {
        var playerTransform = _hacker.transform;

        Vector3 targetPosition2 = playerTransform.position + Quaternion.AngleAxis(-angle,Vector3.up) * (-playerTransform.forward) * distance;

        transform.position = targetPosition2;
    }
}
