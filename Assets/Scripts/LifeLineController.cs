using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeLineController : MonoBehaviour
{
    public Collider2D zombie;
    public ZombieController zombieController;
    public Collider2D human;
    public HumanController humanController;

    public LifeManager lifeManager;
    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

/*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == zombie)
        {
            zombieController.ResetPosition();
            lifeManager.LossLives();
        }
        if (collision == human)
        {
            humanController.ResetPosition();
            scoreManager.AddScore();
        }
    }
*/
}
