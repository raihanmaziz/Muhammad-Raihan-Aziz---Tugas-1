using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : BaseObject
{
    [SerializeField] private LifeManager lifeManager;
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
       Move();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Move()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = _speed;
    }

    public override void Raycasted()
    {
        lifeManager.LossHuman();
        Destroy(gameObject);
    }

    public void SetManager(LifeManager temp)
    {
        lifeManager = temp;
    }
}
