using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
    using UnityEditor;
#endif
public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        DataManager.Instance.LoadingData();
        bestScoreText.text = "Best Score: " + DataManager.Instance.iplayerName +": " + DataManager.Instance.bestScore;
    }

    public void EnterName()
    {
        InputField inputPlayerName = FindObjectOfType<InputField>();
        if (inputPlayerName.text != DataManager.Instance.iplayerName)
        {
           DataManager.Instance.iplayerName = inputPlayerName.text; 
           DataManager.Instance.score = 0;
        }
        
    }
    public void StartGame()
    {
        
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        
# if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
# else
        Application.Quit();
# endif
    }
}
