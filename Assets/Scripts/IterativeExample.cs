using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IterativeExample : MonoBehaviour
{

    private void Start()
    {
       
    }


    void Update()
    {
        DifferentCategory();

    }


   

    void DifferentCategory()
    {
        /*Two strings, one random integer*/
        int x = Random.Range(0, 101);
        string y = "--";
        string a = "--";

        /* First, we want to pick a semi-random value for string a based on integer x */
        if (x >= 0 && x <= 30)
        {
            a = "A";
        }
        else if (x >= 31 && x <= 38)
        {
            a = "B";
        }
        else if (x >= 39 && x <= 100)
        {
            a = "C";
        }
        else
        {
            a = "--";

        }

        /*Then we want to pick a semi-random value for string y. */

        x = Random.Range(0, 101);

        if (x >= 0 && x <= 30)
        {
            y = "A";
        }
        else if (x >= 31 && x <= 38)
        {
            y = "B";
        }
        else if (x >= 39 && x <= 100)
        {
            y = "C";
        }
        else
        {
            y = "--";

        }

        /* While string a and y are equal, then roll a new value. This code only runs if we accidently rolled the same value. */
        while (a == y)
        {

            x = Random.Range(0, 101);

            if (x >= 0 && x <= 30)
            {
                y = "A";
            }
            else if (x >= 31 && x <= 38)
            {
                y = "B";
            }
            else if (x >= 39 && x <= 100)
            {
                y = "C";
            }
            else
            {
                y = "--";

            }

        }

        Debug.Log(a + "  " + y);
    }
}







