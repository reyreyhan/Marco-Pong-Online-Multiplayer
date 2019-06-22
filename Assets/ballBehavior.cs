using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehavior : MonoBehaviour
{
    [SerializeField] float speed = 30;
    [SerializeField] GameObject particle;
    [SerializeField] BatasShake batas;
    AudioSource au;
    // Start is called before the first frame update
    void Start()
    {
        batas = GameObject.Find("Batas").GetComponent<BatasShake>();
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        au = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        au.Play();
        Instantiate(particle, new Vector3(gameObject.transform.position.x, transform.position.y), Quaternion.identity);
        batas.kasihefek();
        if (coll.gameObject.tag == "PlayerDown")
        {
            
            float x = hitfucktorx(transform.position,coll.transform.position, coll.collider.bounds.size.x);
            Vector2 dir = new Vector2(x,1);
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if (coll.gameObject.tag == "PlayerUp")
        {
            
            float x = hitfucktorx(transform.position, coll.transform.position, coll.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, -1);
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }

    float hitfucktorx(Vector2 ballpos,Vector2 racketpos,float widthracket){

        return(ballpos.x - racketpos.x)/ widthracket;
        }
}
