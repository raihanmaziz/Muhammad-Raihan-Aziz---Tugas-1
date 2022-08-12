using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapManager : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private LifeManager lifeManager;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            if (hit.collider == null)
            {
                Debug.Log("Hit nothing!");
            }
            else if (hit.collider.gameObject.GetComponent<IRaycastable>() == null)
            {
                Debug.Log("Object not raycastable");
            }
            else
            {
                hit.collider.gameObject.GetComponent<IRaycastable>().Raycasted();
            }
        }
    }

    //public void Raycasted()
    //{
    //    Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

    //    if (hit.collider == null)
    //    {
    //        Debug.Log("Hit nothing!");
    //    }

    //    else
    //    {
    //        if (hit.collider.CompareTag("Human"))
    //        {
    //            lifeManager.LossHuman();
    //            Destroy(hit.collider.gameObject);
    //        }
    //        if (hit.collider.CompareTag("Zombie"))
    //        {
    //            scoreManager.AddScore();
    //            Destroy(hit.collider.gameObject);
    //        }
    //    }
    //}
}
