using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayAtta : MonoBehaviour
{
    public GameObject Boss, targ;
    
    public Transform target;

    public Vector3 bos;

    public float speed = 25f;

    private CharacterController CharCon;

    public BossHealth bh;




    // Start is called before the first frame update
    void Start()
    {
        Boss = GameObject.FindWithTag("Baddie");
        targ = GameObject.Find("Target");
        CharCon = GetComponent<CharacterController>();
        bh = Boss.GetComponent<BossHealth>();
        target = targ.GetComponent<Transform>();
        bos = new Vector3(Boss.transform.position.x, Boss.transform.position.y, Boss.transform.position.z);
        if(target != null)
        {
            transform.LookAt(target);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = transform.forward * 1;

        CharCon.Move(movement * speed * Time.smoothDeltaTime);
    }


    void OnTriggerEnter(Collider hit)
    {
        if(hit.tag == "Baddie")
        {
            bh.health--;
            bh.flashing();
            Destroy(gameObject);
        }

        if(hit.tag == "Wall" /*|| hit.tag == "Snowball"*/)
        {
            Destroy(gameObject);
        }
    }

    
}