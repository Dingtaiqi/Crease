using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Tap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tap1;
    public GameObject click;
    public Rigidbody2D rb;
    public int speed, mt;
    public float time1, time2, time3, time4;
    public float timer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameObject Tap1 = this.gameObject;
        tap1.SetActive(true);
        click.SetActive(false);
        mt = 0;
        speed = UnityEngine.Random.Range(3, 7);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(0, -speed, 0);
        if ((speed == 0) & (mt == 0))
        {
            time1 = Time.time;
            mt = 1;
        }
        time2 = Time.time - time1;
        if (time2 >= 80)
        {
            click.SetActive(false);
            mt = 2;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        speed = 0;
        tap1.SetActive(false);
        click.SetActive(true);
        Destroy(this.gameObject);
    }
}

