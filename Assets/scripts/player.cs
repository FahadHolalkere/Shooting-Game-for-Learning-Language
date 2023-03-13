using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Transform bulletsp;
    public GameObject bulletprefab;
    public float bspeed =10;
    public float speed = 8;
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 5)
        {
            transform.position = new Vector2(transform.position.x,5);
        }
        if(transform.position.y <= -5)
        {
            transform.position = new Vector2(transform.position.x,-5);
        }
        if(Input.GetKeyDown(KeyCode.Space)==true)
        {
        var bullet = Instantiate(bulletprefab,bulletsp.position,bulletsp.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bulletsp.right * bspeed;
        }
        float v = Input.GetAxis("Vertical");

        Vector2 pos = transform.position;

        pos.y += v * Time.deltaTime * speed;

        transform.position = pos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.gover();
    }
    
}
