using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{
    private Vector3 vel = Vector3.zero;
    private Vector3 rot = Vector3.zero;
    private Vector3 cRot = Vector3.zero;
    private Vector3 jumpForce = Vector3.zero;
  

    [SerializeField]
    Camera playerCam;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
      
    }

    public void Move(Vector3 _vel)
    {
        vel = _vel;
    }
    public void Jump(Vector3 _jumpVel)
    {
        jumpForce = _jumpVel;
    }
    public void Rotate(Vector3 _rot)
    {
        rot = _rot;
    }
    public void CRotate(Vector3 _cRot)
    {
        cRot = _cRot;
    }
    private void FixedUpdate()
    {
        MovePlayer();
        RotatePlayer();
        JumpPlayer();

      
    }
    void MovePlayer()
    {
        if (vel != Vector3.zero)
        {
            rb.MovePosition(rb.position + vel * Time.fixedDeltaTime);
        }
    }
    void RotatePlayer()
    {
        if (rot != Vector3.zero)
        {
            rb.MoveRotation(rb.rotation * Quaternion.Euler(rot));
        }
        if(playerCam!=null )
        {
            playerCam.transform.Rotate(-cRot);
        }
    }
    void JumpPlayer()
    {
        if (jumpForce != Vector3.zero)
        {
            rb.MovePosition(rb.position + jumpForce * Time.fixedDeltaTime);
        }
    }
   
       
    
}