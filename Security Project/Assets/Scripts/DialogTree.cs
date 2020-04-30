using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTree : MonoBehaviour
{
    public bool canActivate;
    public GameObject dialogTree;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canActivate == true)
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            canActivate = true;

    }
}
