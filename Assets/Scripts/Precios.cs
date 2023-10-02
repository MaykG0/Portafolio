using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using UnityEngine.UI;

public class Precios : MonoBehaviour
{
    public Presets presets;
    public Text exist_t;
    public Text precio_t;

    public void Actualizacion()
    {
        string conexion = presets.server;
        string t_producto = presets.existencia;
        string producto = presets.producto;
        string accion = "SELECT existencia_total, precio FROM " + t_producto + " WHERE producto = '" + producto + "'";

        MySqlConnection conn = new MySqlConnection(conexion);
        MySqlCommand consola = new MySqlCommand(accion, conn);

        conn.Open();

        MySqlDataReader datos = consola.ExecuteReader();

        while (datos.Read())
        {
            int E = datos.GetInt32(0);
            double P = datos.GetDouble(1);
            exist_t.text = E.ToString();
            precio_t.text = P.ToString();
        }

        conn.Close();
        datos.Close();
    }
}
