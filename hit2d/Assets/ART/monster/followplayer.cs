using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public float sp,sit;
    private Transform player;
    Vector3 pos;
    float ti = 1;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            sliders.player_health--;
        }
    }
    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (ti <= 0)
            {
                sliders.player_health--;
                ti = 1;
            }
            else
                ti = ti - Time.deltaTime;
        }
    }
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos.z = -2;
        transform.position = pos;
        if (Vector2.Distance(transform.position, player.position) > sit)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, sp * Time.deltaTime);
        }
        


    }
}
