using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontKnow : MonoBehaviour
{
    public Rigidbody2D Obj;
    public float IniVel;
    float Vel;
    float X;

    void Update()
    {
        X = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {

        Obj.AddForce(transform.right * IniVel, ForceMode2D.Impulse);
    }
}
