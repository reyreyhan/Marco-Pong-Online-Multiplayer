using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource sfx;
    

    // Start is called before the first frame update
    void Start()
    {
        sfx = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)|| Input.GetMouseButtonDown(1))
        {
            PlaySFX();
        }
    }

    public void PlaySFX()
    {
        sfx.Play();
    }
}
