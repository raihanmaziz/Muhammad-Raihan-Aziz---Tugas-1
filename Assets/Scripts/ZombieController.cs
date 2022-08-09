using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    public Collider2D lifeLine;

    private Rigidbody2D rig;
    public ScoreManager scoreManager;
    public LifeManager lifeManager;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        scoreManager.AddScore();
        Destroy(gameObject);
    }

    public void ResetPosition()
    {
        resetPosition.x = Random.Range(-8, 8);
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 1);
        rig.velocity = speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == lifeLine)
        {
            lifeManager.LossLives();
            Destroy(gameObject);
        }
    }
}
