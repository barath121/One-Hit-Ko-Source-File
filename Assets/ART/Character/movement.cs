using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed,atx=0,aty=-1;
   public Animator ab;
    private Vector3 position;
    private Rigidbody2D rb;
    public static bool is_alive = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (is_alive)
        { position = Vector3.zero;
            position.x = Input.GetAxisRaw("Horizontal");
            position.y = Input.GetAxisRaw("Vertical");
            if (Input.GetKey(KeyCode.X))
            {
                ab.SetFloat("atx", atx);
                ab.SetFloat("aty", aty);
                ab.SetBool("attack", true);
            }
            else
                ab.SetBool("attack", false);
            if (Input.GetKeyDown(KeyCode.Z))
            {
                ab.SetFloat("atx", atx);
                ab.SetFloat("aty", aty);
                ab.SetBool("sattack", true);
            }
            else
                ab.SetBool("sattack", false);
            if (position != Vector3.zero)
            {
                rb.MovePosition(transform.position + position * speed * Time.deltaTime);
                ab.SetFloat("X", position.x);
                ab.SetFloat("Y", position.y);
                print(position.x);
                ab.SetBool("walking", true);
                atx = position.x;
                aty = position.y;
            }
            else
                ab.SetBool("walking", false);

        } }
}
