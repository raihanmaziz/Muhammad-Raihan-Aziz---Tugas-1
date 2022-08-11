using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapManager : MonoBehaviour, IRaycastable
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private LifeManager lifeManager;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Raycasted();
        }
    }

    public void Raycasted()
    {
        Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

        if (hit.collider == null)
        {
            Debug.Log("Hit nothing!");
        }

        else
        {
            if (hit.collider.CompareTag("Human"))
            {
                lifeManager.LossHuman();
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider.CompareTag("Zombie"))
            {
                scoreManager.AddScore();
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
