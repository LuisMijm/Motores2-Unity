using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager manager = null;

    public int stress;

    // Start is called before the first frame update
    void Awake()
    {
        if(null == manager)
        {
            manager = this;
        }

        else if(manager != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        stress = 1000000;
    }

    static void AddStress(int amount)
    {
        //GameManager.manager.stress += amount;
    }

}
