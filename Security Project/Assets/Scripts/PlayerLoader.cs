using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerController.instance == null)
        {
            Instantiate(player, new Vector3(-4.72f, -2.25f, 0.437f), Quaternion.identity );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
