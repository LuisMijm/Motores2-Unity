using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    public PlayerController player_;

    public BallPool ballPool_;

    public List<EnemyController> EnemyCList_ = null;
    public PlayerController PC_;
    public ScoreManager SM_;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        foreach(EnemyController ec in EnemyCList_)
        {
            ec.DieEvent += OnEnemyDeath;
        }
    }

    void OnEnemyDeath(int score, GameObject causer)
    {
        if(causer.GetComponent<PlayerController>() == PC_)
        {
            Debug.Log("Lo que sea");
        }
    }
}
