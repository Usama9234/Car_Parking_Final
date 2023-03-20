using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject carPanel;
    public GameObject levelPanel;
    public static int carId;
    public static int levelId;
    public GameObject loadingPanel;
    public GameObject[] levelButtons;

    private void Start()
    {
        levelPanel.SetActive(false);
    }


    public void EnableLevelPanel()
    {
        carPanel.SetActive(false);
        levelPanel.SetActive(true);
    }

    public void SelectCar(int id)
    {
        GameController.carId = id;
    }

    public void SelectLevel(int id)
    {
        GameController.levelId = id;
        loadingPanel.SetActive(true);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("GamePlay");
    }


}
