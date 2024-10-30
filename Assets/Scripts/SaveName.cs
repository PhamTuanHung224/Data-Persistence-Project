using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveName : MonoBehaviour
{
    private InputField inputPlayerName;
    // Start is called before the first frame update
    void Start()
    {
        inputPlayerName = GetComponent<InputField>();
    }

    
    public void EnterName()
    {
        DataManager.Instance.iplayerName = inputPlayerName.text;
    }
}
