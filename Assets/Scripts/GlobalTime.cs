 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTime : MonoBehaviour
{

    public GameObject timeDisplay;
    public int seconds = 30;
    public bool deductingTime;
    public GameObject timeUpText;
    public GameObject fadeOut;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (seconds == 0) {
            player.GetComponent<PlayerControls>().enabled = false;
            seconds = 0;
            timeUpText.SetActive(true);
            fadeOut.SetActive(true);
            StartCoroutine(RespawningLevel());
            
        }
        else {
            if (deductingTime == false) {
                deductingTime = true;
                StartCoroutine(DeductSecond());
            }
        }
    }

    //Coroutine
    IEnumerator DeductSecond() {
        yield return new WaitForSeconds(1);
        seconds -= 1;
        timeDisplay.GetComponent<Text>().text = "TIME: " + seconds;
        deductingTime = false;
    }

    IEnumerator RespawningLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }
}
