using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int Score;
    static GameManager Instance;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null) Instance = this;
        else Destroy(this.gameObject);
    }

    public static void AddToScore(int points)
    {
        Instance.Score += points;
    }

    public static int getScore()
    {
        return Instance.Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
