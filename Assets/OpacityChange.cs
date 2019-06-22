using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpacityChange : MonoBehaviour
{
    public SpriteRenderer image;

    private bool isGlow;
    Color tmp;

    // Start is called before the first frame update
    void Start()
    {
        isGlow = true;
        image = GetComponent<SpriteRenderer>();
        StartCoroutine("changeColor");
    }

    // Update is called once per frame
    void Update()
    {
        image.color = tmp;

        if (tmp.a <= 0.2)
        {
            isGlow = false;
        }
        else if(tmp.a >= 0.8)
        {
            isGlow = true;
        }

    }

    IEnumerator changeColor()
    {
        while (true)
        {
            tmp = image.color;

            //print(tmp.a);

            if (isGlow)
            {
                tmp.a = Mathf.Lerp(tmp.a, 0, Time.deltaTime * 2);
            }

            else if(!isGlow)
            {
                tmp.a = Mathf.Lerp(tmp.a, 1, Time.deltaTime * 2);
            }

            yield return new WaitForSeconds(Time.deltaTime * 2);
        }

    }


}
