using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControtr : MonoBehaviour
{

    public GameObject ball;
    public float spawnTime;
    float m_spawnTime;

    int m_score;
    bool m_isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if(m_spawnTime <= 0)
        {
            spawnBall();
            m_spawnTime = spawnTime;
        }
    }

    public void spawnBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-7, 7), 6);
        if(ball != null)
        {
            Instantiate(ball, spawnPos, Quaternion.identity);
        }
    }

    public void setScore(int score)
    {
        m_score = score;
    }

    public int getScore()
    { 
        return m_score; 
    }   

    public void increamentScore()
    {
        m_score++;
    }

    public bool isGameOver()
    {
          return m_isGameOver;
    }

    public void setGameOver(bool isGameOver)
    {
        m_isGameOver = isGameOver;
    }
}
