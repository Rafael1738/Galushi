using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveController : MonoBehaviour
{
    public float speed = 5f;
    public float padding = 1f;
    public GameObject bullet;
    public GameObject Over;
    public AudioSource au;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, vInput * speed * Time.deltaTime, 0);

        float newY = Mathf.Clamp(transform.position.y, -10 + padding, 10 - padding);
        float newX = Mathf.Clamp(transform.position.x, -15 + padding, 15 - padding);

        transform.position = new Vector3(newX, newY, 0);

        if ((newY == 9) || (newY == -9))
        {
            
            Destroy(gameObject);

            Over.SetActive(true);


        }

        //disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            au.Play();
            var naveAlien = GameObject.Find("Viscosi");
            if (naveAlien != null)
            {
                Vector3 newPosition = naveAlien.transform.position + Vector3.left * 1.75f;
                Instantiate(bullet, naveAlien.transform.position, Quaternion.identity);
            }
           
          
        }
    }
}
