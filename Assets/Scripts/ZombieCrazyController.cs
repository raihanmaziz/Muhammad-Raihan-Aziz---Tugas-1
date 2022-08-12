using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCrazyController : BaseObject
{
    [SerializeField] private ScoreManager scoreManager;
    private Rigidbody2D rig;
    private float timer;
    private int clampBorderOffset = 1;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        timer = 0;
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.3f)
        {
            Move();
            timer = 0;
        }
        ClampObjectIntoView(rig);
    }

    public override void Move()
    {
        _speed = new Vector2(Random.Range(-5f, 5f), -3);
        rig.velocity = _speed;
    }

    void ClampObjectIntoView(Rigidbody2D r)
    {
        Vector2 objectPosition = r.position;
        float frustrumPositionRightX = Camera.main.ViewportToWorldPoint(new Vector2(1, 0)).x;
        // Clamp right
        if (objectPosition.x > frustrumPositionRightX - clampBorderOffset)
        {
            r.velocity = new Vector2(0, r.velocity.y);
            r.position = new Vector2(frustrumPositionRightX - clampBorderOffset, r.position.y);
        }
        float frustrumPositionLeftX = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).x;
        // Clamp left
        if (objectPosition.x < frustrumPositionLeftX + clampBorderOffset)
        {
            r.velocity = new Vector2(0, r.velocity.y);
            r.position = new Vector2(frustrumPositionLeftX + clampBorderOffset, r.position.y);
        }

    }

    public override void Raycasted()
    {
        scoreManager.AddScore();
        Destroy(gameObject);
    }

    public void SetManager(ScoreManager temp)
    {
        scoreManager = temp;
    }
}
