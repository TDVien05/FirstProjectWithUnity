using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Control m_gc;
    public void start()
    {
        m_gc = FindObjectOfType<Control>;
    }

    private void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.CompareTag("Player")) {

            m_gc.increamentScore();

            Debug.Log("Cham gia do");
        } 
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("DeadZone"))
        {
            Debug.Log("Game over!");
        }
    }

}
