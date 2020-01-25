using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwnners : MonoBehaviour
{
    public GameObject[] spaw =new GameObject[9];
    public int max;
    public GameObject monster;
    public static int limit;
    private int rand;
    private Vector3 cur;
    public int lim;
    // Start is called before the first frame update
    void Start()
    {
        limit = lim;
    }

    // Update is called once per frame
    void Update()
    {
        if (limit>0&&stamina.total<50)
        {
            rand = Random.Range(0, max);
            Instantiate(monster, spaw[rand].transform.position, transform.rotation);
            limit--;
        }
    }
}
