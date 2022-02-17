using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redbullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] wartank wartank1;
    [SerializeField] float XPush;
    [SerializeField] float YPush;
    [SerializeField] float RandomFactor = 1.5f;
    Rigidbody2D myrigidbody;

    Vector2 tankballdist;
    bool gamekey=false;
   // [SerializeField] AudioClip[] ballsound;
    void Start()
    {
        tankballdist = transform.position - wartank1.transform.position;
        myrigidbody = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        if (!gamekey)
        {
            lockball();
            launchball();
        }
    }

    private void launchball()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gamekey = true;
            myrigidbody.velocity = new Vector2(XPush, YPush);
        }   
    }

    private void lockball()
    {
        Vector2 tankpos = new Vector2(wartank1.transform.position.x, wartank1.transform.position.y);
        transform.position = tankpos + tankballdist;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocitytweak = new Vector2(UnityEngine.Random.Range(0, RandomFactor), 
            UnityEngine.Random.Range(0, RandomFactor));
        if (gamekey)
        {
            myrigidbody.velocity += velocitytweak;
        }
    }


    // public void OnCollisionEnter2D(Collision2D collision)
    // {

    //   if (gamekey)
    //   {
    //      AudioClip clip = ballsound[UnityEngine.Random.Range(0, ballsound.Length)];
    //      GetComponent<AudioSource>().PlayOneShot(clip);
    //   }
    // }
}
