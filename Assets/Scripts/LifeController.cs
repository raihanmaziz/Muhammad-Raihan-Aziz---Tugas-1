using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LifeController : MonoBehaviour
{
    public TextMeshProUGUI lives;

    public LifeManager manager;

    // Update is called once per frame
    private void Update()
    {
        lives.text = manager.lives.ToString();
    }
}
