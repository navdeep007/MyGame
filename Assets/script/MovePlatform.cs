using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour {

    public float minX = 0;
    public float maxX = 0;
    public float minY = 0;
    public float maxY = 0;

    Rigidbody2D rigidBody2d;

    void Start()
    {
        rigidBody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {

        if (minX != maxX)
        {
            if (transform.position.x < minX)
            {
                rigidBody2d.velocity = Vector2.right;
            }
            else if (transform.position.x > maxX)
            {
                rigidBody2d.velocity = Vector2.left;
            }
        }

	}
}
