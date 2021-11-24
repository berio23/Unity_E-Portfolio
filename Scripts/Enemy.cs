using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public float enemySpeed;
    public GameObject ps;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0f, (enemySpeed * Time.fixedDeltaTime) * -1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
        else if (other.CompareTag("missile"))
        {
            Destroy(gameObject);
            Instantiate(ps, transform.position, Quaternion.identity);
            GameManager.AddToScore(1);

        }
   }
}
