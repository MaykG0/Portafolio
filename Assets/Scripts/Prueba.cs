using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data.Types;
using System;
using MySql.Data;

public class Prueba : MonoBehaviour
{
    void Start()
    {
        int a = 1;
        int b = 10;

        if (a < 10)
        {
            while (a < 10)
            {
                if (b == 10)
                {
                    print("Huevo");
                    break;
                }

                print(a);

                a++;
            }
        }
    }
}
