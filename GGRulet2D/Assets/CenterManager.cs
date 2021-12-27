using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterManager : MonoBehaviour
{

    public float InitialRotVel=100;
    public float Deceleration = 0.1f;

    private Rigidbody2D Rigidbody;
    private float RotVel;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        Rigidbody.angularVelocity = InitialRotVel;
        RotVel = InitialRotVel;
    }

    // Update is called once per frame
    void Update()
    {
        RotVel = Mathf.Max(RotVel - Deceleration,0);
        Rigidbody.angularVelocity = RotVel;
    }
}
