using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalLevel : MonoBehaviour
{
    public static int levelNumber = 3;
    public int internalNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalNum = levelNumber;
    }
}
