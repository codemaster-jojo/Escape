using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;

    private bool isPaused = false;

    // Start is called before the first frame update
    private void Awake()
    {
        pauseScreen.SetActive(isPaused);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            isPaused = !isPaused;
            pauseScreen.SetActive(isPaused);
            if (isPaused) {
                Time.timeScale = 0f;
            }
            else Time.timeScale = 1.0f;
        }
    }

    public void Unpause()
    {
        Time.timeScale = 1.0f;
        isPaused = false;
        pauseScreen.SetActive(isPaused);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        isPaused = true;
        pauseScreen.SetActive(isPaused);
    }
}
