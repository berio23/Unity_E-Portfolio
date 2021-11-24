using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSDestory : MonoBehaviour
{

    private ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        ps = gameObject.GetComponent<ParticleSystem>();
        Destroy(gameObject, ps.main.duration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
