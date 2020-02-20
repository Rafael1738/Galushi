using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawRandom : MonoBehaviour
{
    public GameObject objet;
    public float timecration = 2;
    public float rangecreation = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("creation", 0.0f, timecration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void creation()
    {
        Vector3 spawnpoint = new Vector3(0, 0, 0);
        spawnpoint = this.transform.position + Random.onUnitSphere * rangecreation;
        spawnpoint = new Vector3(spawnpoint.x, spawnpoint.y, 0);

        GameObject objetintc = Instantiate(objet, spawnpoint, Quaternion.identity);
    }
   
    
}
