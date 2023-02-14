using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTimer : MonoBehaviour
{
    public float PTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PTimer -= Time.deltaTime;
        if (PTimer <= 0)
            Destroy(gameObject);
    }
}
