using UnityEngine;
using System;

public class LevelManager : MonoBehaviour
{
    public GameObject[] cars;
    public Levels[] level;
    int currentCarId;
    int currentLevelId;
    private void Start()
    {
        foreach (Levels i in level)
        {
            i.completeLevel.SetActive(false);
        }
        currentCarId = GameController.carId;
        currentLevelId = GameController.levelId;
        level[currentLevelId].completeLevel.SetActive(true);
        Instantiate(cars[currentCarId],level[currentLevelId].carSpawnPoint.position, level[currentLevelId].carSpawnPoint.rotation);

    }

    private void Update()
    {
        if (GameController.levelId>=level.Length)
        {
            GameController.levelId = 0;
        }
    }
}


[Serializable]
public class Levels
{
    public GameObject completeLevel;
    public int damageAllowed;
    public int rewards;
    public Transform carSpawnPoint;
}

