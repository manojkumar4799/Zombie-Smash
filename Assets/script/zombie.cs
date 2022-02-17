using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{
    [SerializeField] GameObject ZombieVFX;
    [SerializeField] AudioClip ZombieSound;
    [SerializeField] int TimesHit;
    [SerializeField] Sprite[] HitSprite;
        // Start is called before the first frame update
    private void Start()
    {
        FindObjectOfType<level>().countblocks();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(ZombieSound, Camera.main.transform.position);
        handlehits();

    }

    private void handlehits()
    {
        TimesHit++;
        int MaxHits = HitSprite.Length + 1;

        if (TimesHit >= MaxHits)
        {
            destroyzombie();
        }
        else
        {
            shownextsprite();
        }
    }

    private void shownextsprite()
    {
        int spriteindex = TimesHit - 1;
        if (HitSprite[spriteindex] != null)
        {
            GetComponent<SpriteRenderer>().sprite = HitSprite[spriteindex];
        }
        else
        {
            Debug.LogError("block sprite is missing in " + gameObject);
        }
    }

    private void destroyzombie()
    {
        
        Destroy(gameObject);
        FindObjectOfType<level>().destroyedblocks();
        FindObjectOfType<gamestatus>().scorecount();
        zombiesparkles();
    }
    public void zombiesparkles()
    {
        GameObject sparkles = Instantiate(ZombieVFX, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
