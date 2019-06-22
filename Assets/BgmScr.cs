using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmScr : MonoBehaviour
{
    [SerializeField] AudioClip[] otherClip;
    AudioSource audioSource;
    int Rand;
    private static BgmScr instance;

    public static BgmScr Instance{
        get
        {
            return instance;
        }
    }


    void Awake()
    {

        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this.gameObject)
        {
            Destroy(this.gameObject);
            return;
        }
        // If no Player ever existed, we are it.

    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Rand = Random.Range(0, otherClip.Length);
        audioSource.clip = otherClip[Rand];
    }

    // Update is called once per frame
    void Update()
    {

        

        if (!audioSource.isPlaying)
        {
            Rand = Random.Range(0, otherClip.Length);
            audioSource.clip = otherClip[Rand];
            audioSource.Play();
        }
    }
}
