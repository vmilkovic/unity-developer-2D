using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{
    int score;

    static ScoreKeeper instance;

    void Awake()
    {   
        ManageSingleton();
    }

    void ManageSingleton()
    {
        if(instance != null)
        {
            Scene currentScene = SceneManager.GetActiveScene();
            if(currentScene.name == "Game")
            {
                instance.ResetScore();
            }
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
            
    }

    public ScoreKeeper GetInstance()
    {
        return instance;
    }

    public int GetScore()
    {
        return score;
    }

    public void ModifyScore(int value)
    {
        score += value;
        Mathf.Clamp(score, 0, int.MaxValue);
    }

    public void ResetScore()
    {
        score = 0;
    }
}
