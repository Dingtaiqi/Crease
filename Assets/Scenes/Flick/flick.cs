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
    public bool sb, sd = false;
    public float time1, time2, time3, time4;
    public float timer;
    void Start()
    {
        sb = false; sd = false;
        Input.multiTouchEnabled = true;
        rb = GetComponent<Rigidbody2D>();
        GameObject Drag = this.gameObject;
        flick.SetActive(true);
        flick1.SetActive(false);
        mt = 0;
        speed = UnityEngine.Random.Range(3, 7);
        rb.velocity = new Vector3(0, -speed, 0);
    }

    // Update is called once per frame
    void Update()
    {

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
    private async void OnTriggerStay2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "Square"))
        {
            sd = true;
        }
        if ((collision.gameObject.name == "Square") & (sb == true) & (sd == true))
        {
            flick.SetActive(false);
            flick1.SetActive(true);
            await Task.Delay(100);
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.name == "SB")
        {

            Destroy(this.gameObject);
        }

    }
    void OnMouseDown()
    {
        sb = true;


        if (sd == false) { Debug.Log("114514"); Destroy(this.gameObject); } else { Debug.Log("1919810"); }
        GameObject dy = GameObject.Find("Square");
        Vector3 dyPos = dy.transform.position;
        Vector3 myPos = flick.transform.position;
        //if (Input.touchCount > 0)
        //if (((myPos.y - dyPos.y) <= 0.34) & ((myPos.y - dyPos.y) <= -1.2)) //& ((touch.position.y - myPos.y) < 10) & ((touch.position.y - myPos.y) < -10) & ((touch.position.x - myPos.x) <= 1) & ((touch.position.x - myPos.x) <= -1))

        //{
        // flick.SetActive(false);
        //  flick1.SetActive(true);
        // await Task.Delay(100);
        // Destroy(this.gameObject);
        // }

        //break;
    }
    // case TouchPhase.Ended:

}

