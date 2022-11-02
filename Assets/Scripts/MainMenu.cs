using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    bool LoadingInitiated = false;
    int x;

    public void PlayGame()
    {
        if (!LoadingInitiated)
        {
            x = 0;
            StartCoroutine(DelayedLoad(x));
            LoadingInitiated = true;
        }
    }

    public void QuitGame()
    {
            x = 1;
            StartCoroutine(DelayedLoad(x));
            LoadingInitiated = true;
    }

    IEnumerator DelayedLoad(int y)
    {
        GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(1);

        if (x == 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            Application.Quit();

    }
}