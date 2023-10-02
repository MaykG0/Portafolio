using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Entrada : MonoBehaviour
{
    public InputField ticket;
    public Presets presets;
    public GameObject exito;

    public void EntradasAutomatica()
    {
        string tabla = presets.remoto;
        string t = ticket.text;
        string conexion = presets.server;
        string t_exist = presets.existencia;
        string accion = "SELECT COUNT(*) FROM " + tabla + " WHERE codigo_barras = " + t + "";

        MySqlConnection conn = new MySqlConnection(conexion);
        MySqlCommand consola = new MySqlCommand(accion, conn);

        conn.Open();

        MySqlDataReader datos = consola.ExecuteReader();

        while (datos.Read())
        {

        }
        int count = datos.GetInt32(0);

        conn.Close();

        int bucle = 0;

        while (bucle < count)
        {

            string cap = "SELECT producto, precio, cantidad, sucursal FROM " + tabla + " WHERE codigo_barras = " + t + " ORDER BY idcaptura DESC LIMIT " + bucle + ",1";

            MySqlCommand captura = new MySqlCommand(cap, conn);

            conn.Open();

            MySqlDataReader cc = captura.ExecuteReader();

            while (cc.Read())
            {

            }

            string producto = cc.GetString(0);
            int precio = cc.GetInt32(1);
            int cantidad = cc.GetInt32(2);
            string sucursal = cc.GetString(3);

            conn.Close();

            string t_entrada = presets.t_entradas;

            var hora = System.DateTime.Now.Hour.ToString("00") + ":" +
                System.DateTime.Now.Minute.ToString("00") + ":" +
                System.DateTime.Now.Second.ToString("00");

            var fecha = System.DateTime.Now.Year.ToString("0000") + "/" +
                System.DateTime.Now.Month.ToString("00") + "/" +
                System.DateTime.Now.Day.ToString("00");

            double total = precio * cantidad;
            int ticket = presets.ticket_entrada;
            string ticket2 = ticket.ToString("0000");

            string empleado = presets.empleado;

            string BaseD = "INSERT INTO " + t_entrada + " VALUES('0', '" + producto + "', '" + cantidad + "', '" + precio + "', '" + total + "', 'Entrada', '" + sucursal + "', '" + empleado + "', '" + fecha + "', '" + hora + "', '" + ticket2 + "')";

            MySqlCommand entrada = new MySqlCommand(BaseD, conn);

            conn.Open();

            entrada.ExecuteReader();

            conn.Close();

            bucle++;

            if (bucle == count)
            {
                int ticket3 = ticket + 1;

                PlayerPrefs.SetInt("Ticket_Entrada", ticket3);
                Main.CargaGeneral(presets);

                string realizado = "UPDATE " + tabla + " SET status = 'Cargado' WHERE codigo_barras = " + t + "";

                MySqlCommand actualizacion = new MySqlCommand(realizado, conn);

                conn.Open();

                actualizacion.ExecuteReader();

                conn.Close();

                datos.Close();
                cc.Close();
                exito.SetActive(true);
                break;
            }
        }
    }

    public GameObject info;
    public GameObject contenido;

    public void Mostrar()
    {
        string tabla = presets.remoto;
        string movimiento = presets.movimiento;
        string conexion = presets.server;

        try
        {

            string accion = "SELECT producto, cantidad FROM " + tabla + " WHERE codigo_barras = " + ticket.text + "";

            MySqlConnection conn = new MySqlConnection(conexion);
            MySqlCommand consola = new MySqlCommand(accion, conn);

            conn.Open();

            MySqlDataReader datos = consola.ExecuteReader();

            while (datos.Read())
            {
                GameObject texto = Instantiate(info) as GameObject;
                texto.transform.parent = contenido.transform;
                texto.transform.position = contenido.transform.position;
                texto.GetComponent<Text>().text = "Producto: " + datos.GetString(0) + "   Cantidad: " + datos.GetInt32(1);
            }

            datos.Close();
            conn.Close();
        }
        catch (MySqlException ex)
        {
            Debug.LogError("Error: " + ex);
        }
    }

    public void EntradaManual()
    {
        string t_entrada = presets.t_entradas;
        string t_temp = presets.temp_captura;
        string conexion = presets.server;

        string conteo = "SELECT COUNT(*) FROM " + t_temp + "";

        MySqlConnection conn = new MySqlConnection(conexion);
        MySqlCommand consola = new MySqlCommand(conteo, conn);

        conn.Open();

        MySqlDataReader datos = consola.ExecuteReader();

        while (datos.Read())
        {

        }

        int count = datos.GetInt32(0);

        conn.Close();

        int bucle = 0;
        int lectura = 1;

        while (bucle < count)
        {
            string leer = "SELECT producto, cantidad FROM " + t_temp + " WHERE idcaptura = " + lectura + "";

            MySqlCommand learn = new MySqlCommand(leer, conn);

            conn.Open();

            MySqlDataReader datos3 = learn.ExecuteReader();

            while (datos3.Read())
            {

            }

            string producto = datos3.GetString(0);
            int cantidad = datos3.GetInt32(1);

            conn.Close();


            string tablaprecio = presets.existencia;
            string accionprecio = "SELECT precio FROM " + tablaprecio + " WHERE producto= '" + producto + "'";

            MySqlCommand consola2 = new MySqlCommand(accionprecio, conn);

            conn.Open();

            MySqlDataReader datos2 = consola2.ExecuteReader();

            while (datos2.Read())
            {

            }

            double precio = datos2.GetDouble(0);

            conn.Close();


            var hora = System.DateTime.Now.Hour.ToString("00") + ":" +
                System.DateTime.Now.Minute.ToString("00") + ":" +
                System.DateTime.Now.Second.ToString("00");

            var fecha = System.DateTime.Now.Year.ToString("0000") + "/" +
                System.DateTime.Now.Month.ToString("00") + "/" +
                System.DateTime.Now.Day.ToString("00");

            double total = precio * cantidad;
            int ticket_e = presets.ticket_entrada;
            string ticket2 = ticket_e.ToString("0000");

            string sucursal = presets.sucursal_entrada;
            string empleado = presets.empleado;

            string registro = "INSERT INTO " + t_entrada + " VALUES ('0', '" + producto + "', '" + cantidad + "', '" + precio + "', '" + total + "', 'Entrada', 'Manual', '" + empleado + "', '" + fecha + "', '" + hora + "', '" + ticket2 + "')";

            MySqlCommand registros = new MySqlCommand(registro, conn);

            conn.Open();

            registros.ExecuteReader();

            conn.Close();
            bucle++;
            lectura++;

            if (bucle == count)
            {
                PlayerPrefs.SetInt("Condicional", 0);
                int t1 = presets.ticket_entrada;
                int t2 = t1 + 1;
                PlayerPrefs.SetInt("Ticket_Entrada", t2);
                Main.CargaGeneral(presets);
                string accion = "DELETE FROM " + t_temp + "";

                MySqlCommand borrar = new MySqlCommand(accion, conn);

                conn.Open();

                borrar.ExecuteReader();

                conn.Close();
                string accion2 = "ALTER TABLE " + t_temp + " AUTO_INCREMENT = 0";

                MySqlCommand restaurar = new MySqlCommand(accion2, conn);

                conn.Open();

                restaurar.ExecuteReader();

                conn.Close();

                datos.Close();
                datos2.Close();
                datos3.Close();

                SceneManager.LoadScene("Traslados");

                break;
            }
        }
    }
}
