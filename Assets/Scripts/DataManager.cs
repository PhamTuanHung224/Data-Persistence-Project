using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string iplayerName;
    public int bestScore = 0;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy (gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
}
