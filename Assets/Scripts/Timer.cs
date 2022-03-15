using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float startTime = 30f;
    public float currentTime;

    public Image timer;
    public TextMeshProUGUI timerText;

    private bool ended = false;
    
    // Start is called before the first frame update
    void Awake()
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

        if (currentTime <= 0)
		{
            currentTime = 0f;
        }
        
        if(!ended && currentTime <= 0)
        {
            print("end");
            ended = true;
            FindObjectOfType<UIManager>().StartEnd();
            FindObjectOfType<SpawnTasks>().SpawnStop();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
