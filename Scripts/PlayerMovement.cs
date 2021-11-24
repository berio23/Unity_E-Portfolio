using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed;
    private Vector3 change;
    public GameObject bullet;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        change.Normalize();

        rb.MovePosition(transform.position + change * moveSpeed * Time.fixedDeltaTime);


        if(Input.GetKeyDown("space"))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }

        if(transform.position.x > 8.29f)
        {
            transform.position = new Vector3(8.29f, transform.position.y, transform.position.z);
        }
        else if(transform.position.x < -8.29f)
        {
            transform.position = new Vector3(-8.29f, transform.position.y, transform.position.z);
        }


        if (transform.position.y > 4.13f)
        {
            transform.position = new Vector3(transform.position.x, 4.13f, transform.position.z);
        }
        else if(transform.position.y < -4.1f)
        {
            transform.position = new Vector3(transform.position.x, -4.1f, transform.position.z);
        }
    }
}
