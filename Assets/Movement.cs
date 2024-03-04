using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    void Start()
    {
        
    }
    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x + .05f, transform.position.y);
    }
}
