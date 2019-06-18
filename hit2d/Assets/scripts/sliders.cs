using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sliders : MonoBehaviour
{
    public Slider slid;
    public static float player_health=100;
    // Start is called before the first frame update
    void Start()
    {
        slid = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        slid.value = player_health;
    }
}
