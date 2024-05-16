using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
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
        Input.multiTouchEnabled = true;
        rb = GetComponent<Rigidbody2D>();
        GameObject Tap1 = this.gameObject;
        tap1.SetActive(true);
        click.SetActive(false);
        mt = 0;
        speed = UnityEngine.Random.Range(3, 7);
        rb.velocity = new Vector3(0, -speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject dy = GameObject.Find("Square");
        Vector3 dyPos = dy.transform.position;
        Vector3 myPos = tap1.transform.position;
        Touch touch = Input.touches[0];
        switch (touch.phase)
        {
            case TouchPhase.Began:
                if (((myPos.y - dyPos.y) <= 34) & ((myPos.y - dyPos.y) <= -12) & ((touch.position.y - myPos.y) < 10) & ((touch.position.y - myPos.y) < -10) & ((touch.position.x - myPos.x) <= 1) & ((touch.position.x - myPos.x) <= -1))
                {
                    tap1.SetActive(false);
                    click.SetActive(true);
                    // await Task.Delay(100);
                    // Destroy(this.gameObject);
                }
                break;
        }
        if (click.activeSelf == true)
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
            click.SetActive(false);
            mt = 2;
        }
    }
    private async void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Square")
        {
            tap1.SetActive(false);
            click.SetActive(true);
            //await Task.Delay(100);
            Destroy(this.gameObject);
        }
    }
}

