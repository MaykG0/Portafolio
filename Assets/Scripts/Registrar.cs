using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Registrar : MonoBehaviour
{
    public GameObject info;
    public GameObject contenido;
    public Presets presets;
    public GameObject error_conexion;

    private void Start()
    {
        try
        {
            Main.CargaGeneral(presets);

            string t_entrada = presets.temp_captura;
            string tabla = presets.temp;
            string movimiento = presets.movimiento;
            string conexion = presets.server;

            if (movimiento == "Salida")
            {

                string accion = "SELECT * FROM " + tabla + "";

                MySqlConnection conn = new MySqlConnection(conexion);
                MySqlCommand consola = new MySqlCommand(accion, conn);

                conn.Open();

                MySqlDataReader datos = consola.ExecuteReader();

                while (datos.Read())
                {
                    GameObject texto = Instantiate(info) as GameObject;
                    texto.transform.parent = contenido.transform;
                    texto.transform.position = contenido.transform.position;
                    texto.GetComponent<Text>().text = "Producto: " + datos.GetString(1) + "   Cantidad: " + datos.GetInt32(2);
                }

                datos.Close();
                conn.Close();
            }

            if (movimiento == "Entrada")
            {
                string accion = "SELECT * FROM " + t_entrada + "";

                MySqlConnection conn = new MySqlConnection(conexion);
                MySqlCommand consola = new MySqlCommand(accion, conn);

                conn.Open();

                MySqlDataReader datos = consola.ExecuteReader();

                while (datos.Read())
                {
                    GameObject texto = Instantiate(info) as GameObject;
                    texto.transform.parent = contenido.transform;
                    texto.transform.position = contenido.transform.position;
                    texto.GetComponent<Text>().text = "Producto: " + datos.GetString(1) + "   Cantidad: " + datos.GetInt32(2);
                }

                datos.Close();
                conn.Close();
            }
        }
        catch (MySqlException ex)
        {
            Debug.LogError("Error: " + ex);
        }
    }
    public void RegistrarFinal()
    {
        try
        {
            //Toma de datos
            string tabla = presets.temp;
            string empleado = presets.empleado;
            string tablasucursal = presets.sucursales;
            string sucursal = presets.sucursal;
            int ticket = presets.ticket;
            int bucle = 0;
            int lectura = 1;
            string conexion = presets.server;

            string numero = "SELECT COUNT(*) FROM " + tabla + "";

            MySqlConnection conn = new MySqlConnection(conexion);
            MySqlCommand consola = new MySqlCommand(numero, conn);

            conn.Open();

            MySqlDataReader datos = consola.ExecuteReader();

            while (datos.Read())
            {

            }

            int conteo = datos.GetInt32(0);

            conn.Close();

            //Seleccion de descuento
            //SELECT descuento FROM `traslados_sucursales` WHERE `sucursal` = "tlaltenco"
            string d1 = "SELECT descuento FROM " + tablasucursal + " WHERE sucursal= '" + sucursal + "'";

            MySqlCommand consola2 = new MySqlCommand(d1, conn);

            conn.Open();

            MySqlDataReader datos2 = consola2.ExecuteReader();

            while (datos2.Read())
            {

            }

            int descuento = datos2.GetInt32(0);

            conn.Close();

            //Variables de tiempo

            var hora = System.DateTime.Now.Hour.ToString("00") + ":" +
                System.DateTime.Now.Minute.ToString("00") + ":" +
                System.DateTime.Now.Second.ToString("00");

            var fecha = System.DateTime.Now.Year.ToString("0000") + "/" +
                System.DateTime.Now.Month.ToString("00") + "/" +
                System.DateTime.Now.Day.ToString("00");

            //Registro
            while (bucle < conteo)
            {
                string data = "SELECT producto, cantidad FROM " + tabla + " WHERE id= " + lectura + "";

                MySqlCommand consola3 = new MySqlCommand(data, conn);

                conn.Open();

                MySqlDataReader datos3 = consola3.ExecuteReader();

                while (datos3.Read())
                {

                }

                string producto = datos3.GetString(0);
                int cantidad = datos3.GetInt32(1);

                conn.Close();

                string tablaprecio = presets.existencia;
                string accionprecio = "SELECT precio FROM " + tablaprecio + " WHERE producto= '" + producto + "'";

                MySqlCommand consola4 = new MySqlCommand(accionprecio, conn);

                conn.Open();

                MySqlDataReader datos4 = consola4.ExecuteReader();

                while (datos4.Read())
                {

                }

                double precio = datos4.GetDouble(0);

                conn.Close();

                //Procesos Matematicos

                double subtotal = precio * cantidad;
                double total = subtotal;
                if (descuento > 1)
                {
                    total = subtotal % descuento;
                }
                string ticket2 = ticket.ToString("0000");

                //Registros

                if (sucursal == "Estacion")
                {
                    int continuar = presets.continuar;
                    if (continuar == 1)
                    {

                        string estacion = presets.Estacion;
                        string t_remote = presets.remoto;
                        string operador = presets.operador;
                        MySqlConnection CC = new MySqlConnection(estacion);
                        try
                        {
                            CC.Open();



                            CC.Close();

                            try
                            {
                                var day = System.DateTime.Now.DayOfWeek;

                                string dia = "";

                                string barras = "*R1" + ticket2 + "R1*";

                                if (day == System.DayOfWeek.Sunday)
                                {
                                    dia = "Domingo";
                                }
                                if (day == System.DayOfWeek.Monday)
                                {
                                    dia = "Lunes";
                                }
                                if (day == System.DayOfWeek.Tuesday)
                                {
                                    dia = "Martes";
                                }
                                if (day == System.DayOfWeek.Wednesday)
                                {
                                    dia = "Miercoles";
                                }
                                if (day == System.DayOfWeek.Thursday)
                                {
                                    dia = "Jueves";
                                }
                                if (day == System.DayOfWeek.Friday)
                                {
                                    dia = "Viernes";
                                }
                                if (day == System.DayOfWeek.Saturday)
                                {
                                    dia = "Sabado";
                                }

                                string comando = "INSERT INTO " + t_remote + " VALUES ('0', '" + cantidad + "', '" + producto + "', '" + precio + "', '" + total + "', 'Pendiente', '" + operador + "', '" + empleado + "', '" + fecha + "', '" + hora + "', '" + dia + "', '" + ticket2 + "', '" + barras + "')";

                                MySqlCommand remote = new MySqlCommand(comando, CC);

                                CC.Open();

                                remote.ExecuteReader();

                                CC.Close();
                            }
                            catch (MySqlException ex)
                            {
                                Debug.LogError("Error: " + ex);
                            }
                        }
                        catch (MySqlException ex)
                        {
                            Debug.LogError("Error: " + ex);
                            error_conexion.SetActive(true);
                            break;
                        }
                    }
                }
                if (sucursal == "Santa Maria")
                {
                    int continuar = presets.continuar;
                    if (continuar == 1)
                    {

                        string estacion = presets.Estacion;
                        string t_remote = presets.remoto;
                        string operador = presets.operador;
                        MySqlConnection CC = new MySqlConnection(estacion);
                        try
                        {
                            CC.Open();



                            CC.Close();

                            try
                            {
                                var day = System.DateTime.Now.DayOfWeek;

                                string dia = "";

                                string barras = "*R1" + ticket2 + "R1*";

                                if (day == System.DayOfWeek.Sunday)
                                {
                                    dia = "Domingo";
                                }
                                if (day == System.DayOfWeek.Monday)
                                {
                                    dia = "Lunes";
                                }
                                if (day == System.DayOfWeek.Tuesday)
                                {
                                    dia = "Martes";
                                }
                                if (day == System.DayOfWeek.Wednesday)
                                {
                                    dia = "Miercoles";
                                }
                                if (day == System.DayOfWeek.Thursday)
                                {
                                    dia = "Jueves";
                                }
                                if (day == System.DayOfWeek.Friday)
                                {
                                    dia = "Viernes";
                                }
                                if (day == System.DayOfWeek.Saturday)
                                {
                                    dia = "Sabado";
                                }

                                string comando = "INSERT INTO " + t_remote + " VALUES ('0', '" + cantidad + "', '" + producto + "', '" + precio + "', '" + total + "', 'Pendiente', '" + operador + "', '" + empleado + "', '" + fecha + "', '" + hora + "', '" + dia + "', '" + ticket2 + "', '" + barras + "')";

                                MySqlCommand remote = new MySqlCommand(comando, CC);

                                CC.Open();

                                remote.ExecuteReader();

                                CC.Close();
                            }
                            catch (MySqlException ex)
                            {
                                Debug.LogError("Error: " + ex);
                            }
                        }
                        catch (MySqlException ex)
                        {
                            Debug.LogError("Error: " + ex);
                            error_conexion.SetActive(true);
                            break;
                        }
                    }
                }
                if (sucursal == "Estacion")
                {
                    int continuar = presets.continuar;
                    if (continuar == 1)
                    {

                        string estacion = presets.Estacion;
                        string t_remote = presets.remoto;
                        string operador = presets.operador;
                        MySqlConnection CC = new MySqlConnection(estacion);
                        try
                        {
                            CC.Open();



                            CC.Close();

                            try
                            {
                                var day = System.DateTime.Now.DayOfWeek;

                                string dia = "";

                                string barras = "*R1" + ticket2 + "R1*";

                                if (day == System.DayOfWeek.Sunday)
                                {
                                    dia = "Domingo";
                                }
                                if (day == System.DayOfWeek.Monday)
                                {
                                    dia = "Lunes";
                                }
                                if (day == System.DayOfWeek.Tuesday)
                                {
                                    dia = "Martes";
                                }
                                if (day == System.DayOfWeek.Wednesday)
                                {
                                    dia = "Miercoles";
                                }
                                if (day == System.DayOfWeek.Thursday)
                                {
                                    dia = "Jueves";
                                }
                                if (day == System.DayOfWeek.Friday)
                                {
                                    dia = "Viernes";
                                }
                                if (day == System.DayOfWeek.Saturday)
                                {
                                    dia = "Sabado";
                                }

                                string comando = "INSERT INTO " + t_remote + " VALUES ('0', '" + cantidad + "', '" + producto + "', '" + precio + "', '" + total + "', 'Pendiente', '" + operador + "', '" + empleado + "', '" + fecha + "', '" + hora + "', '" + dia + "', '" + ticket2 + "', '" + barras + "')";

                                MySqlCommand remote = new MySqlCommand(comando, CC);

                                CC.Open();

                                remote.ExecuteReader();

                                CC.Close();
                            }
                            catch (MySqlException ex)
                            {
                                Debug.LogError("Error: " + ex);
                            }
                        }
                        catch (MySqlException ex)
                        {
                            Debug.LogError("Error: " + ex);
                            error_conexion.SetActive(true);
                            break;
                        }
                    }
                }

                string tRegistro = presets.registro;
                string registro = "INSERT INTO " + tRegistro + " VALUES ('0', '" + producto + "', '" + cantidad + "', '" + precio + "', '" + subtotal + "', '" + descuento + "', '" + total + "', 'SALIDA', '" + sucursal + "', '" + empleado + "', '" + fecha + "', '" + hora + "', '" + ticket2 + "')";

                MySqlCommand registros = new MySqlCommand(registro, conn);

                conn.Open();

                registros.ExecuteReader();

                conn.Close();

                bucle++;
                lectura++;

                if (bucle == conteo)
                {
                    PlayerPrefs.SetInt("Condicional", 0);
                    int t = presets.ticket;
                    int t2 = t + 1;
                    PlayerPrefs.SetInt("Ticket", t2);
                    Main.CargaGeneral(presets);
                    string accion = "DELETE FROM " + tabla + "";

                    MySqlCommand borrar = new MySqlCommand(accion, conn);

                    conn.Open();

                    borrar.ExecuteReader();

                    conn.Close();
                    string accion2 = "ALTER TABLE " + tabla + " AUTO_INCREMENT = 0";

                    MySqlCommand restaurar = new MySqlCommand(accion2, conn);

                    conn.Open();

                    restaurar.ExecuteReader();

                    conn.Close();

                    datos.Close();
                    datos2.Close();
                    datos3.Close();
                    datos4.Close();

                    SceneManager.LoadScene("Traslados");
                    break;
                }
            }
        }
        catch (MySqlException ex)
        {
            Debug.LogError("Error: " + ex);
        }

    }
}

