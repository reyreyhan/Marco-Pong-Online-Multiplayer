using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBendaLangit : MonoBehaviour
{
    [SerializeField] GameObject[] bendaLangit;

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

        if(timer <= 0)
        {
            int randobj = Random.RandomRange(0, 4);
            float random = Random.RandomRange(0, 8);
            
                Instantiate(bendaLangit[randobj], new Vector2(random, 6), Quaternion.identity);
            
            timer = Random.RandomRange(0.3f,2f);
        }
    }

}
