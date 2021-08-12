using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            GlobalCoins.coinCoint += 1;
            this.gameObject.SetActive(false);
        }

    }

}
