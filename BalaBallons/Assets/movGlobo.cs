using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movGlobo : MonoBehaviour
{
    public float speed;
    public float limit;
    private Transform transx;
    public int scorevalue; 
    private GameScore gscore;
    private GameHelio ghelio;
    public int heliovalue;
    //privatentrollofgame scorepass;
    // Start is called before the first frame update
    void Start()
    {
        transx = GetComponent<Transform>();
        gscore = GameObject.FindWithTag("GameController").GetComponent<GameScore>();
        ghelio = GameObject.FindWithTag("GameController").GetComponent<GameHelio>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
        if (transform.position.y > limit)
        {
            
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            gscore.addScore(scorevalue);
            ghelio.addHelio(heliovalue);
            Destroy(gameObject);
            
        }
    }
}
