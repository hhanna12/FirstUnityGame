using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelComplete : MonoBehaviour
{
    public int importedCoins;
    public GameObject completedText;
    public GameObject fadeOut;
    public GameObject player;



    void Update()
    {
        importedCoins = GlobalCoins.coinCoint;
        if (importedCoins == 3)
        {
            if (GlobalLevel.levelNumber == 5)
            {
                StartCoroutine(LastLevel());
            }
            else
            StartCoroutine(LevelCompeted());
        }
    }

    IEnumerator LevelCompeted()
    {
        yield return new WaitForSeconds(0.2f);
        completedText.SetActive(true);
        fadeOut.SetActive(true);
        player.GetComponent<PlayerControls>().enabled = false;
        yield return new WaitForSeconds(3);
        GlobalLevel.levelNumber += 1;
        PlayerPrefs.SetInt("LevelLoadNum", GlobalLevel.levelNumber);
        SceneManager.LoadScene(2);
    }
    IEnumerator LastLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }


}
