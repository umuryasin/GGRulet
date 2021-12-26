using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody2D Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        Rigidbody.AddForce(new Vector2(500, 0));


    }

    // Update is called once per frame
    void Update()
    {
        float ballX = Rigidbody.transform.position.x;
        float ballY = Rigidbody.transform.position.y;

        float forceX = 0 - ballX;
        float forceY = 0 - ballY;

        Rigidbody.AddForce(new Vector2(forceX, forceY));
        
    }
}
