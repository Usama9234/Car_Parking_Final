using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public int count;
    Image loadingBar;
    public bool levelComplete=false;
    public static CarController instance;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        loadingBar = GameObject.Find("LoadingBarImage").GetComponent<Image>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("hurdle"))
        {
            count++;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "parking")
        {
            loadingBar.fillAmount += 0.01f;
            if (loadingBar.fillAmount == 1f)
            {
                loadingBar.fillAmount = 0f;
                levelComplete = true;
            }
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag=="parking")
        {
            loadingBar.fillAmount = 0;
            levelComplete = false;
        }
    }

}
