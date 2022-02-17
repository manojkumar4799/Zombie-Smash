using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : MonoBehaviour
{
    [SerializeField] AudioClip StoneSound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "unbreakable")
        {
            unbreakablestone();
            
        }
        else
        {
            breakablestone();
        }
    }

    public void breakablestone()
    {
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(StoneSound, Camera.main.transform.position);
        
    }
    public void unbreakablestone()
    {
       
            AudioSource.PlayClipAtPoint(StoneSound, Camera.main.transform.position);
        
    }
}
