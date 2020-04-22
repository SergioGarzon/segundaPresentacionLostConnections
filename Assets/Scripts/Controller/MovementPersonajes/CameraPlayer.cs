using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public Vector3 distanceCamera;
    private Transform targetPlayer;
    public GameObject objectPlayer;
    [Range (0 , 1)] public float lerpValue;
    public float sensibilidad;



    void Start()
    {
        this.targetPlayer = this.objectPlayer.transform;
    }

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, targetPlayer.position + distanceCamera, lerpValue);
        this.distanceCamera = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensibilidad, Vector3.up) * this.distanceCamera;


        transform.LookAt(this.targetPlayer);
    }

}


