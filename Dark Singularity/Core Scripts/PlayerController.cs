using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float movementForce;
    private Vector3 movementDir;

    public float counterMovementForce;
    private Vector3 counterMovement;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        counterMovement = new Vector3(-playerRb.velocity.x * counterMovementForce, 0, -playerRb.velocity.z * counterMovementForce);
       
    }

    private void FixedUpdate()
    {
        playerRb.AddForce(movementDir.normalized * movementForce + counterMovement);
    }
}
