using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMove : MonoBehaviour
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

        Obj.velocity = new Vector2(IniVel, 0);
    }
}
