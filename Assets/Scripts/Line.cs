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
        float xDirection = Input.GetAxisRaw("Horizontal");
        float yDirection = Input.GetAxisRaw("Vertical");

        float moveSpeed = 5.0f;
        float xMoveStep = moveSpeed * xDirection * Time.deltaTime;
        float yMoveStep = moveSpeed * yDirection * Time.deltaTime;

        // Horizontal boundary check
        if ((transform.position.x <= -8f && xMoveStep < 0) || (transform.position.x >= 8f && xMoveStep > 0))
            return;
        // Vertical boundary check
        if ((transform.position.y <= -3f && yMoveStep < 0) || (transform.position.y >= 4f && yMoveStep > 0))
            return;
        

        transform.position = transform.position + new Vector3(xMoveStep, yMoveStep, 0);
        
    }
}
