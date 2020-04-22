using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public CharacterController controlerPlayer;

    public float horizontalMove;
    public float verticalMove;
    public float speed;

    public Camera camara;

    private Vector3 playerInput;
    private Vector3 camaraForward;
    private Vector3 camRight;
    private Vector3 movePlayer;

    void Start()
    {
        this.controlerPlayer = GetComponent<CharacterController>();
        this.verticalMove = 0;
        this.horizontalMove = 0;
    }

    void Update()
    {
        this.horizontalMove = Input.GetAxis("Horizontal");
        this.verticalMove = Input.GetAxis("Vertical");

        this.playerInput = new Vector3(this.horizontalMove, 0, this.verticalMove);
        this.playerInput = Vector3.ClampMagnitude(this.playerInput, 1);

        DirectionCamara();

        this.movePlayer = playerInput.x * camRight + playerInput.z * camaraForward;

        this.controlerPlayer.transform.LookAt(this.controlerPlayer.transform.position + movePlayer);

        this.controlerPlayer.Move(this.movePlayer * speed * Time.deltaTime);
    }

    private void DirectionCamara()
    {
        camaraForward = camara.transform.forward;
        camRight = camara.transform.right;

        camaraForward.y = 0;
        camRight.y = 0;

        camaraForward = camaraForward.normalized;
        camRight = camRight.normalized;
    }
}

