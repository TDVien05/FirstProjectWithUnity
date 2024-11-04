using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    float xDirection;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");

        float moveStep = 1.5f * xDirection * Time.deltaTime;

        if((transform.position.x <= -8f && moveStep < 0) || (transform.position.x >= 8f && moveStep > 0))
            return;

        transform.position = transform.position + new Vector3(moveStep, 0, 0);
        
    }
}
