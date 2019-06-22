using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreImageController : MonoBehaviour
{
    public GameObject atas, bawah;
    public BatasScript batasAtas, batasBawah;

    public GameObject[] disableAll;
    public GameObject p1win, p2win;

    public int score1, score2;
    public bool CheckPlayerWin;
   

    // Start is called before the first frame update
    void Start()
    {
        batasAtas = atas.GetComponent<BatasScript>();
        batasBawah = bawah.GetComponent<BatasScript>();
        p1win.SetActive(false);
        p2win.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        score2 = batasAtas.scoreTemp;
        score1 = batasBawah.scoreTemp;

        if ((score1 >= 9 || score2 >= 9))
        {
            WinCondition();
        }
    }

    public void WinCondition()
    {
        for (int i = 0; i < disableAll.Length; i++)
        {
            disableAll[i].SetActive(false); 
        }

        if (score1 > score2)
        {
            p1win.SetActive(true);
        }
        else
        {
            p2win.SetActive(true);
        }

        StartCoroutine("changeScene");
    }
    
    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
    }

}
