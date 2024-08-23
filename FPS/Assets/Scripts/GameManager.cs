using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int score = 1;
    public int Health;
    private int DamageHealth;
    public Text HealthBox;
    public Text ScoreText;
    public int damage;
    public GameObject HomePage;
    public GameObject GamePage;
    public GameObject Pausepanel;
    public GameObject DeadScreen;
    // Start is called before the first frame update
    void Start()
    {
        HealthFull();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void scoreAdd()
    {
        ScoreText.text = "Score: " + score.ToString();
        score++;
    }

    public void healthReduce()
    {
        Health-=damage;
        if(Health < 0)
        {
            Die();
        }
        HealthFull();
    }

    public void HealthFull()
    {
        HealthBox.text = "Life: " + Health.ToString();
    }

    public void Die()
    {
        Time.timeScale = 0;
        DeadScreen.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

    public void play()
    {
        HomePage.gameObject.SetActive(false);
        GamePage.gameObject.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        Pausepanel.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        Pausepanel.gameObject.SetActive(true);
        Pausepanel.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    
    public void retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        HomePage.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.None;

    }
}