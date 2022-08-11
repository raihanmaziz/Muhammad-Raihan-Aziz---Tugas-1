using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    [SerializeField] private LifeManager lifeManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void AddScore()
    {
        if (lifeManager.isOver)
        {
            Debug.Log("Game already over!");
        }
        else
        {
            score += 10;
        }
    }
}