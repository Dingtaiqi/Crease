//*- *- coding GBK -* -* 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decisionline : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab; 
    float timer;
    //随机数，仅拿来测试，后面JSON再说
    void Start()
    {
        GameObject DL = new GameObject();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            int a = Random.Range(-8, 11);
            Instantiate(prefab, new Vector3(a, 5, 0), Quaternion.identity);
            timer = 0;
        }
    }
}
