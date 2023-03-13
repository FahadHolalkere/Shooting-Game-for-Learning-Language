using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundry : MonoBehaviour
{
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    private void OnCollision2D(Collider2D collision)
    {
        //audio.soundtrack();
        logic.gover();
    }
}
