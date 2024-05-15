using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Flick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject flick;
    public GameObject flick1;
    public Rigidbody2D rb;
    public int speed, mt;
    public float time1, time2, time3, time4;
    public float timer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameObject Flick1 = this.gameObject;
        flick.SetActive(true);
        flick1.SetActive(false);
        mt = 0;
        speed = UnityEngine.Random.Range(3, 7);
        rb.velocity = new Vector3(0, -speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (flick1.activeSelf == true)
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
    private void FixedUpdate()
    {
        
        if ((speed == 0) & (mt == 0))
        {
            time1 = Time.time;
            mt = 1;
        }
        time2 = Time.time - time1;
        if (time2 >= 80)
        {
            flick1.SetActive(false);
            mt = 2;
        }
    }
    private async void OnTriggerEnter2D(Collider2D collision)
    {

        flick.SetActive(false);
        flick1.SetActive(true);
        await Task.Delay(100);
        Destroy(this.gameObject);
    }
}

