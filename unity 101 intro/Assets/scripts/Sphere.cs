using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * moveSpeed;
        if ((transform.position.x > 20) || (transform.position.x < -20))
        {
            moveSpeed *= -1;
        }
    }
}
