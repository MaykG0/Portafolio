using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MySql.Data.MySqlClient;
using System;
using UnityEngine.SceneManagement;

public class LoginUser : MonoBehaviour
{
    //Log
    public InputField user;
    public InputField pass;
    public GameObject fail;

    public Presets presets;

    //LoginUser

    public void Log()
    {

        int log = Int32.Parse(user.text);

        int password = Int32.Parse(pass.text);

        string conexion = presets.server;
        string accion = "SELECT * FROM " + presets.empleados + " WHERE empleado = " + log + "";

        MySqlConnection conn = new MySqlConnection(conexion);
        MySqlCommand consola = new MySqlCommand(accion, conn);

        conn.Open();

        MySqlDataReader datos = consola.ExecuteReader();

        while (datos.Read())
        {
            if (log == datos.GetInt32(2))
            {
                if (password == datos.GetInt32(3))
                {
                    string empleado = datos.GetString(1);

                    PlayerPrefs.SetString("Empleado", empleado);
                    Main.CargaGeneral(presets);
                    SceneManager.LoadScene("Traslados");
                }
                fail.SetActive(true);
                StartCoroutine(Fallo());
            }
            fail.SetActive(true);
            StartCoroutine(Fallo());
        }
        conn.Close();
        datos.Close();

        IEnumerator Fallo()
        {
            yield return new WaitForSeconds(4f);
            fail.SetActive(false);
        }
    }
}
