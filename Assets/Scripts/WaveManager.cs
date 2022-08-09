using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public int wave;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void AddWave()
    {
        wave += 1;
    }
}
