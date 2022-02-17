using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamestatus : MonoBehaviour
{
    [Range(0f,10f)][SerializeField] float GameSpeed = 1f;
    [SerializeField] int PointPerHit = 1;
    [SerializeField] int TotalScore = 0;
    [SerializeField] TextMeshProUGUI ScoreText;
    
    // Start is called before the first frame update
    private void Awake()
    {
        int gamestatuscount = FindObjectsOfType<gamestatus>().Length;
        if (gamestatuscount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        ScoreText.text = TotalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = GameSpeed;
        
        
    }
    public void scorecount()
    {
        TotalScore += PointPerHit;
        ScoreText.text = TotalScore.ToString();
    }
    public void gameset()
    {
        Destroy(gameObject);
    }
    
   
   /* public bool gameautoplay()
    {
        return AutoPlay;
    }*/
}
