using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    public static bool por=false;
    
    public GameObject[] p = new GameObject[4];
    // Start is called before the first frame update
    void Start()
    {
        p[1].SetActive(true);
        p[2].SetActive(false);
        p[3].SetActive(false);
        p[0].SetActive(false);
        movement.is_alive = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (stamina.total >= 50)
        {
            p[1].SetActive(false);
            p[2].SetActive(true);
            p[3].SetActive(true);

        }

        if (sliders.player_health <= 0)
        {
            p[0].SetActive(true);
            movement.is_alive = false;
        }
        if (por)
        {
            
            por = false;
        }
    }
}
