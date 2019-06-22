using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBackground : MonoBehaviour
{
    [SerializeField] GameObject bg;

    float timer;
    [SerializeField] float fixedTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;

        if (timer <= 0)
        {
            Instantiate(bg, new Vector2(0, 10), Quaternion.identity);
        }
        timer = fixedTimer;
    }
}
