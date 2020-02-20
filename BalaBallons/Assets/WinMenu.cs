using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject WinMenuUI;
    public GameObject Menu;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Restar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadMenu()
    {

        Time.timeScale = 1f;
        Menu.SetActive(true);
    }

}
