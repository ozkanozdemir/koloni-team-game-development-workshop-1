using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_ManagerSript : MonoBehaviour
{
    public TextMeshProUGUI coin;
    public TextMeshProUGUI exp;
    public TextMeshProUGUI wave;
    public TextMeshProUGUI level;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonUp()
    {
        Debug.Log("+");
    }
    public void ButtonDown()
    {
        Debug.Log("-");
    }
}
