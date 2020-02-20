using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAMEOVERMENU : MonoBehaviour
{
    public GameObject Menu;
    public GameObject GameOverMenuUI;
    public static bool GamePause = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }



    public void LoadMenu()
    {
        
        Time.timeScale = 1f;
        Menu.SetActive(true);
    }

    public void ReinicarLvl()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}
