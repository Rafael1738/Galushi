using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tiempo : MonoBehaviour
{
    // Start is called before the first frame update
    public int inicialTime;
    public float timeScale= 1;
    private Text Tiempo;
    private float tiempoDelFrameConTimeScale = 0;
    private float tiempoAMostrarEnSegundo = 0;
    private float escalaDeTiempoAlPausar, escalaDeTiempoInicial;
    private bool estaPausado = false;
    //private Controllofgame scorepass;
    //private float tiempopuntos = 0;
    public float timelimit = 10;
    private GameHelio ghelio;
    private int newHelioValue;
    public Text newhelioText;
    private int counter1 = 0;
    private int counter2 = 0;


    void Start()
    {
        
        
        
        escalaDeTiempoInicial = timeScale;

        Tiempo = GetComponent<Text>();

        tiempoAMostrarEnSegundo = inicialTime;

        ActualizarRelok(inicialTime);
        updateVariableHelio();


        //scorepass = GameObject.FindWithTag("GameController").GetComponent<Controllofgame>();

    }

    // Update is called once per frame
    void Update()
    {

        tiempoDelFrameConTimeScale = Time.deltaTime * timeScale;

        tiempoAMostrarEnSegundo += tiempoDelFrameConTimeScale;


        ActualizarRelok(tiempoAMostrarEnSegundo);
        counter1 += ActualizarRelok(tiempoAMostrarEnSegundo);
        if(counter1 % 60 == 5) {
            counter2 += counter1 % 60;
        }
        if (counter2 == 50) {
            int pmenos = -5;
            newHelioValue = newHelioValue - pmenos;
            updateVariableHelio();
            counter2 = 0;

        }




    }

    public int ActualizarRelok(float tiempoEnSegundos)
    {
        
        int minutos = 0;
        int segundos = 0;
       // int puntosmenos = 0;
        string textoDelReloj;

        if (tiempoEnSegundos < 0)
            tiempoEnSegundos = 0;

        minutos = (int)tiempoEnSegundos / 60;
        segundos = (int)tiempoEnSegundos % 60;

        




        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");

        Tiempo.text = textoDelReloj;
        return 1;




    }
    public void updateVariableHelio()
    {
        
        ghelio = GameObject.FindWithTag("GameController").GetComponent<GameHelio>();
        newHelioValue = ghelio.helio;
        


    }
    void UpdatenewHelio()
    {
        newhelioText.text = "Helio: " + newHelioValue;
    }



   
}
