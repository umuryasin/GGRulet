using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterManager : MonoBehaviour
{
    private Rigidbody2D Rigidbody;
    private float rotationVel = 15;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        Rigidbody.angularVelocity = rotationVel;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody.angularVelocity = rotationVel;
    }
}
