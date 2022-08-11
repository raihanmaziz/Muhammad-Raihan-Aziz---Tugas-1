using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeLineController : MonoBehaviour
{
    [SerializeField] private LifeManager lifeManager;
    [SerializeField] private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Zombie"))
        {
            lifeManager.LossLives();
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Human"))
        {
            scoreManager.AddScore();
            Destroy(collision.gameObject);
        }
    }
}
