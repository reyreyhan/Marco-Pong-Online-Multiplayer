using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] GameObject[] button;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HorizontalMove()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            gameObject.transform.Translate(new Vector2(1, 0));
        }
    }

    public void HorizontalMoveNeg()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            gameObject.transform.Translate(new Vector2(1, 0));
        }
    }

    public void VerticalMove()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            gameObject.transform.Translate(new Vector2(0, 1));
        }
    }

    public void VerticalMoveNeg()
    {
        if (Input.GetAxis("Vertical") < 0)
        {
            gameObject.transform.Translate(new Vector2(0, 1));
        }
    }
}
