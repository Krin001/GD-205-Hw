using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float correct;
    

    public GameObject random;
    public GameObject[] exit;

    public int next;
    


    public nextRoom nr;

    public Vector3 start;

    public float x,y,z;

    private CharacterController CharCon;

    public Vector3 room;

    
    // Start is called before the first frame update
    void Start()
    {
        CharCon = GetComponent<CharacterController>();
        correct = 1;
        start = transform.position;
        next = -1;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerEnter(Collider rand)
    {
        if(rand.tag == "Random")
        {
            random = rand.gameObject;
            nr = random.GetComponent<nextRoom>();
            correct = nr.direction;
        }

        if(rand.tag == "Start")
        {
            next = 0;
            x = exit[next].transform.position.x;
            y = exit[next].transform.position.y+2;
            z = exit[next].transform.position.z;
            room = new Vector3(x,y,z);


            CharCon.enabled = false;
            transform.position = room;
            CharCon.enabled = true;

        }


        if(rand.tag == "North")
        {
            if(correct == 1)
            {   
                next++;
                x = exit[next].transform.position.x;
                y = exit[next].transform.position.y+2;
                z = exit[next].transform.position.z;
                room = new Vector3(x,y,z);


                CharCon.enabled = false;
                transform.position = room;
                CharCon.enabled = true;
                
            }
            else
            {
                CharCon.enabled = false;
                transform.position = start;
                CharCon.enabled = true;
                
                next = -1;
            }
        }

        if(rand.tag == "South")
        {
            if(correct == 2)
            {
                next++;
                x = exit[next].transform.position.x;
                y = exit[next].transform.position.y+2;
                z = exit[next].transform.position.z;
                room = new Vector3(x,y,z);


                CharCon.enabled = false;
                transform.position = room;
                CharCon.enabled = true;
                
                
            }
            else
            {
                next = -1;
                CharCon.enabled = false;
                transform.position = start;
                CharCon.enabled = true;
                
                
            }
        }

        if(rand.tag == "East")
        {
            if(correct == 3)
            {
                next++;
                x = exit[next].transform.position.x;
                y = exit[next].transform.position.y+2;
                z = exit[next].transform.position.z;
                room = new Vector3(x,y,z);

                CharCon.enabled = false;
                transform.position = room;
                CharCon.enabled = true;
                
            }
            else
            {
                next = -1;
                CharCon.enabled = false;
                transform.position = start;
                CharCon.enabled = true;
                
                

            }
        }

        if(rand.tag == "West")
        {
            if(correct == 4)
            {
                next++;
                x = exit[next].transform.position.x;
                y = exit[next].transform.position.y+2;
                z = exit[next].transform.position.z;
                room = new Vector3(x,y,z);

                CharCon.enabled = false;
                transform.position = room;
                CharCon.enabled = true;
                

            }
            else
            {
                next = -1;
                CharCon.enabled = false;
                transform.position = start;
                CharCon.enabled = true;
                
                
            }
        }
    }

    
}
