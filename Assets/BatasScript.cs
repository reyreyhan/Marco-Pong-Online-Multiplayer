using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BatasScript : MonoBehaviour
{
    public bool isTeam1;
    public GameObject imageTarget;
    public SpriteRenderer changedSR;
    public Sprite[] mataNomor;
    public int scoreTemp;
    [SerializeField] Camera camera;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        changedSR = imageTarget.GetComponent<SpriteRenderer>();
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnBall()
    {
        Instantiate(ball, new Vector2(0f, 0f), Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        scoreTemp++;
        changeScore();
        spawnBall();
        camera.DOShakePosition(0.5f, 0.5f, 20, 90);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    void changeScore()
    {
        changedSR.sprite = mataNomor[scoreTemp];
    }

}
