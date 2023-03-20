using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject loadingPanel;
    public Text currentDamageCount;
    public Text totalDamageAllowed;
    public Image loadingBar;
    bool check = true;
    int totalDamage;
    public GameObject gameOverPanel;
    public GameObject levelWonPanel;
    public LevelManager levelManager;


    private void Start()
    {
        gameOverPanel.SetActive(false);
        levelWonPanel.SetActive(false);
        totalDamageAllowed.text = levelManager.level[GameController.levelId].damageAllowed.ToString();
    }

    private void Update()
    {
        currentDamageCount.text = CarController.instance.count.ToString();
        if (CarController.instance.count>=int.Parse(totalDamageAllowed.text))
        {
            gameOverPanel.SetActive(true);
        }
        if (CarController.instance.levelComplete)
        {
            levelWonPanel.SetActive(true);
        }

    }


    public void Retry()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void NextLevel()
    {
        GameController.levelId++;
        SceneManager.LoadScene("GamePlay");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
