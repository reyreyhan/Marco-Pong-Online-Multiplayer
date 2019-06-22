using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BendaLangit : MonoBehaviour
{
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-speed, -speed));

        if(transform.position.y < -11f)
        {
            Destroy(gameObject);
        }
    }
}
