using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCrazyController : BaseObject
{
    private Rigidbody2D rig;
    private float timer;

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
    }

    public override void Move()
    {
        _speed = new Vector2(Random.Range(-5f, 5f), -3);
        rig.velocity = _speed;
    }
}
