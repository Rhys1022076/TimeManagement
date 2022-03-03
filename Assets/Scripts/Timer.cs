using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    float startTime = 30f;
    float currentTime = 0f;

    public Image timer;
    public TextMeshProUGUI timerText;
    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timer.fillAmount = currentTime / startTime;
        timerText.SetText(currentTime.ToString("0"));
        //print(currentTime);

        if(currentTime <= 0)
        {
            currentTime = 0f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
