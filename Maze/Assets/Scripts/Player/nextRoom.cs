using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextRoom : MonoBehaviour
{
    public float direction;
    public bool passed;

    // Start is called before the first frame update
    void Start()
    {
        passed = false;
        direction = Random.Range(1,4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
