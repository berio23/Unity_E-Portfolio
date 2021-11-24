using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;
    public float spawnTime;
    private Renderer rd;
    
    // Start is called before the first frame update
    void Start()
    {
        rd = gameObject.GetComponent<Renderer>();

        InvokeRepeating("spawnerCo", 0,  spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnerCo()
    {

        var x1 = transform.position.x - rd.bounds.size.x / 2;

        var x2 = transform.position.x + rd.bounds.size.x / 2;

        var spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        Instantiate(enemy, spawnPoint, Quaternion.identity);
    }
}
