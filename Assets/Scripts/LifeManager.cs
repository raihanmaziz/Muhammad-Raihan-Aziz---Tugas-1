using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    public int lives;
    public GameObject gameOver;
    public bool isOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LossLives()
    {
        if (isOver)
        {
            Debug.Log("Game already over!");
        }
        else
        {
            lives -= 1;
            if (lives == 0)
            {
                GameOver();
            }
        }
    }

    public void LossHuman()
    {
        lives = 0;
        GameOver();
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        isOver = true;
    }
}
