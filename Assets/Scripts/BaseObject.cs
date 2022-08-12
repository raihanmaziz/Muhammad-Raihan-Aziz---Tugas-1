using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseObject : MonoBehaviour, IRaycastable
{
    [SerializeField] protected Vector2 _speed = new Vector2(0,-3);
    public abstract void Move();

    public abstract void Raycasted();
}
