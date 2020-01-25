using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene : MonoBehaviour
{
    public string lev;
    private void OnTriggerEnter2D(Collider2D colli)
    {
        if (colli.gameObject.tag == "Player")
        {
            sliders.player_health = 100;
            stamina.total = 0;
            gameover.por = true;
            Application.LoadLevel(lev);

        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
