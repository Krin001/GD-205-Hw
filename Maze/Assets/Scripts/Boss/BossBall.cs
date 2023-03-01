using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBall : MonoBehaviour
{
    public GameObject snBall,throw1,throw2;

    public int rand;

    public Vector3[] ball;

    // Start is called before the first frame update
    void Start()
    {
        ball[0]= throw1.transform.position;
        ball[1] = throw2.transform.position;

        StartCoroutine(attack());
    }

    // Update is called once per frame
    void Update()
    {
        ball[0]= throw1.transform.position;
        ball[1] = throw2.transform.position;
        
        
    
        
    }

    public IEnumerator attack()
    {
        yield return new WaitForSeconds(1f);
       
        strike();

        StopCoroutine(attack());

        
    }

    public void strike()
    {
        rand = Random.Range(0,1);
        Instantiate(snBall, ball[rand], Quaternion.identity);
        StartCoroutine(attack());
    }


}
