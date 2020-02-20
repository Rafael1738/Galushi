using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverFondo : MonoBehaviour
{
    private Renderer mate;
    public float speed = 0.1f;
    private float banner;
    // Start is called before the first frame update
    void Start()
    {
        mate = this.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        mate.material.mainTextureOffset = mate.material.mainTextureOffset + new Vector2(speed * Time.deltaTime, 0);
        //banner = banner + 0.01f;
        //mate.SetTextureOffset("_Maintext",new Vector2(banner+speed,0));
    }
}
