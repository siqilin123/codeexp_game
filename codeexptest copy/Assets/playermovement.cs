using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody2D rb;

    public void FixedUpdate()
    {
        //Vector2 direction = Vector2.up * variableJoystick.Vertical + Vector2.right * variableJoystick.Horizontal;
        //rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode2D.Impulse);
        rb.velocity = new Vector2(variableJoystick.Horizontal * 10f + Input.GetAxis("Horizontal") * 10f, variableJoystick.Vertical * 10f + Input.GetAxis("Vertical")*10f);
    }
}
