using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI wave;

    [SerializeField] private WaveManager waveManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wave.text = waveManager.wave.ToString();
    }
}
