using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawn : MonoBehaviour
{
    private int frameCount = 0;
    public GameObject Bronze;
    public GameObject Silver;
    public GameObject Gold;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //30 fps
        if (frameCount % 900 == 0) {
            // random pick
            GameObject obj = null;
            System.Random rnd = new System.Random();
            int num = rnd.Next(10);

            //  5/10=bronze  3/10=silver  2/10-gold
            if (num==0) {
                obj = Bronze;
            }

            if (num==1) {
                obj = Bronze;
            }

            if (num==2) {
                obj = Bronze;
            }

            if (num==3) {
                obj = Bronze;
            }

            if (num==4) {
                obj = Bronze;
            }

            if (num==5) {
                obj = Silver;
            }
             if (num==6) {
                obj = Silver;
            }

             if (num==7) {
                obj = Silver;
            }

            if (num==8) {
                obj = Gold;
            }

            if (num==9) {
                obj = Gold;
            }

            // spawn
            Instantiate(obj, new Vector3(rnd.Next(-20, 24), 20, 0), Quaternion.identity);
        }
        frameCount++;
    }
}
