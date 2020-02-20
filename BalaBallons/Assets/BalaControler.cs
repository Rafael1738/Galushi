using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaControler : MonoBehaviour
{
    public float balaspeed = -12f;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(balaspeed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -15) {
            Destroy(gameObject);
        }
    }
}
