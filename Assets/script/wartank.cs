using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wartank : MonoBehaviour
{
    [SerializeField] float ScreenWidth;
   

    void Update()
    {
        tankball();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }

    private void tankball()
    {
        float mousepos= Input.mousePosition.x / Screen.width * ScreenWidth;
        Vector2 tankpos = new Vector2(transform.position.x, transform.position.y);
        tankpos.x = Mathf.Clamp(mousepos, 0.85f, 15.15f);
        transform.position = tankpos;
    }
   
    }

   

   

