using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BatasShake : MonoBehaviour
{

    [SerializeField] Camera camera;
    [SerializeField] Vector3 Bola;
    [SerializeField] GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Instantiate(particle, new Vector3(collision.gameObject.transform.position.x, collision.transform.position.y), Quaternion.identity);
        kasihefek();
        
    }

    public void kasihefek()
    {
        camera.DOShakePosition(0.5f, 0.5f, 20, 90);
       
    }
}
