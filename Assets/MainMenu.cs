using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject flashText;
    [SerializeField] GameObject flashText2;

    SoundManager soundManager;

    private void Start()
    {
        InvokeRepeating("flashTheText", 0f, 0.5f);
        InvokeRepeating("flashTheText2", 0f, 0.5f);
    }

    public void Setting()
    {
        soundManager.PlaySFX();
        panel.SetActive(true);
    }

    public void ClosePanel()
    {
        soundManager.PlaySFX();
        panel.SetActive(false);
    }

    public void NextScene(int a)
    {
        //soundManager.PlaySFX();
        SceneManager.LoadScene(a);
    }

    public void BackScene(int b)
    {
        soundManager.PlaySFX();
        SceneManager.LoadScene(b);
    }

    public void Exit()
    {
        soundManager.PlaySFX();
        Application.Quit();
    }

    void flashTheText()
    {
        if (flashText.activeInHierarchy)
            flashText.SetActive(false);
        else
            flashText.SetActive(true);
    }

    void flashTheText2()
    {
        if (flashText2.activeInHierarchy)
            flashText2.SetActive(false);
        else
            flashText2.SetActive(true);
    }
}
