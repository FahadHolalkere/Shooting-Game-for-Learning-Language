using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiosrc : MonoBehaviour
{
    public AudioSource src;
    public AudioClip clp1,clp2,clp3,clp4,clp5,clp6,clp7,clp8,clp9,clp10,clp11,clp12,clp13;
    public int num=0;
    void start()
    {
        
    }
    public void soundtrack()
    {
        src = GetComponent<AudioSource>();
        switch (num)
        {
            case 0: src.clip = clp1;
                    src.Play();
                    num++;
                    break;
            case 1: src.clip = clp2;
                    src.Play();
                    num++;
                    break;
            case 2: src.clip = clp3;
                    src.Play();
                    num++;
                    break;
            case 3: src.clip = clp4;
                    src.Play();
                    num++;
                    break;
            case 4: src.clip = clp5;
                    src.Play();
                    num++;
                    break;
            case 5: src.clip = clp6;
                    src.Play();
                    num++;
                    break;
            case 6: src.clip = clp7;
                    src.Play();
                    num++;
                    break;
            case 7: src.clip = clp8;
                    src.Play();
                    num++;
                    break;
            case 8: src.clip = clp9;
                    src.Play();
                    num++;
                    break;
            case 9: src.clip = clp10;
                    src.Play();
                    num++;
                    break;
            case 10: src.clip = clp11;
                    src.Play();
                    num++;
                    break;
            case 11: src.clip = clp12;
                    src.Play();
                    num++;
                    break;
            case 12: src.clip = clp13;
                    src.Play();
                    num++;
                    break;
            default:   num=0;
                       src.clip = clp1;
                       src.Play();
                       num++;
                       break; 
        }
    }

}
