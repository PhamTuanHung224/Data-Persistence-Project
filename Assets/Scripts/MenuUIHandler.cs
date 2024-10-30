using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        bestScoreText.text = "Best Score: " + DataManager.Instance.iplayerName + DataManager.Instance.bestScore;
    }

    public void EnterName()
    {
        InputField inputPlayerName = FindObjectOfType<InputField>();
        DataManager.Instance.iplayerName = inputPlayerName.text;
    }
    public void StartGame()
    {
        
        SceneManager.LoadScene(1);

    }
}
