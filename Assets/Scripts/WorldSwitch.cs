using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSwitch : MonoBehaviour
{
    public GameObject player;
    SpriteRenderer sr;
 

    bool inBwWorld = true;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        inBwWorld = true;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (inBwWorld == true)
            {
                inBwWorld = false;
                player.layer = 10;
                sr.color = Color.black;
            }
            
            else if (inBwWorld == false)
            {
                inBwWorld = true;
                player.layer = 11;
                sr.color = Color.blue;
            }
        }

    }

    /*void WorldSwap()
    {
        switch (inBwWorld)
        {
            case (true):
                player.layer = 10;
                break;

            case (false):
                player.layer = 11;

                break;
        }
    }*/
}
