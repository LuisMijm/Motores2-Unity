using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPool : MonoBehaviour
{
    public GameObject hiddenPoolRoom_;

    public GameObject ballPrefab_;
    public int poolMaxSize = 50;
    List<GameObject> ballPoolList;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BallGeneration());
    }


    IEnumerator BallGeneration()
    {
        ballPoolList = new List<GameObject>();
        for (int i = 0; i < poolMaxSize; ++i)
        {
            GameObject obj = (GameObject)Instantiate(ballPrefab_, hiddenPoolRoom_.transform.position, Quaternion.identity);
            //obj.SetActive(false);
            ballPoolList.Add(obj);

            yield return new WaitForSeconds(0.03f);
        }
    }
}
