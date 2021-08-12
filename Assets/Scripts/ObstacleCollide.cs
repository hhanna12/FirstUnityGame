using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollide : MonoBehaviour
{
    public GameObject obstacleText;
    public GameObject fadeOut;
    public GameObject player;


    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {

            player.GetComponent<PlayerControls>().enabled = false;
            obstacleText.SetActive(true);
            fadeOut.SetActive(true);
            StartCoroutine(RespawningLevel());
        }

    }

    IEnumerator RespawningLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }

}
