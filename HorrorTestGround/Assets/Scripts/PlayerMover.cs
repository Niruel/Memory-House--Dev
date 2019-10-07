using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(PlayerMotor))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField]
    float speed = 7f;
    [SerializeField]
    float look = 7f;
    [SerializeField]
    float jumpForce = 7f;
    PlayerMotor motor;


    private void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }
    public void Update()
    {
        float _XMov = Input.GetAxisRaw("Horizontal");
        float _ZMov = Input.GetAxisRaw("Vertical");
        float _yMov = Input.GetAxisRaw("Jump");
       

        Vector3 movX = transform.right * _XMov;
        Vector3 mozZ = transform.forward * _ZMov;
        Vector3 moyY = transform.up * _yMov;

        Vector3 movement = (movX + mozZ).normalized * speed;
        motor.Move(movement);

        Vector3 jump = moyY.normalized * jumpForce;
        motor.Jump(jump);

        float yRot = Input.GetAxisRaw("Mouse X");
        Vector3 Rot = new Vector3(0f, yRot, 0)*look;
       
            motor.Rotate(Rot);
        
       

        float xRot = Input.GetAxisRaw("Mouse Y");
        Vector3 cRot = new Vector3(xRot, 0f, 0f) * look;
        
            motor.CRotate(cRot);
        
       
    }


}