using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHelio : MonoBehaviour
{
    //public AudioSource coro;
    public int helio;
    public Text helioText;
    public GameObject WinMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        helio = 0;
        UpdateHelio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addHelio(int value)
    {
        helio += value;
        UpdateHelio();
    }
    void UpdateHelio()
    {
        if (helio >= 500)
        {
            WinMenuUI.SetActive(true);
        }
        helioText.text = "Helio: " + helio;
    }
}
