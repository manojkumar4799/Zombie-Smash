using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{
    [SerializeField] int totalblocks;
    
   public void countblocks()
    {
        totalblocks++;

    }
    
    public void destroyedblocks()
    {
        totalblocks--;
        if (totalblocks <= 0)
        {
            FindObjectOfType<sceneloader>().loadnextscene();
        }
    }
}
