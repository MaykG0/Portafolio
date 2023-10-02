using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using MySql.Data.MySqlClient;

public class Temp_prueba : MonoBehaviour
{
    public Presets presets;

    public Text p1;
    public Text p2;
    public Text p3;
    public Text p4;
    public Text p5;
    public Text p6;
    public Text p7;
    public Text p8;
    public Text p9;
    public Text p10;
    public Text p11;
    public Text p12;
    public Text p13;
    public Text p14;
    public Text p15;
    public Text p16;
    public Text p17;
    public Text p18;
    public Text p19;
    public Text p20;
    public Text p21;
    public Text p22;
    public Text p23;
    public Text p24;
    public Text p25;
    public Text p26;
    public Text p27;
    public Text p28;
    public Text p29;
    public Text p30;
    public Text p31;
    public Text p32;
    public Text p33;
    public Text p34;
    public Text p35;
    public Text p36;
    public Text p37;
    public Text p38;
    public Text p39;
    public Text p40;
    public Text p41;
    public Text p42;
    public Text p43;
    public Text p44;
    public Text p45;
    public Text p46;
    public Text p47;
    public Text p48;
    public Text p49;
    public Text p50;

    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;
    public GameObject b7;
    public GameObject b8;
    public GameObject b9;
    public GameObject b10;
    public GameObject b11;
    public GameObject b12;
    public GameObject b13;
    public GameObject b14;
    public GameObject b15;
    public GameObject b16;
    public GameObject b17;
    public GameObject b18;
    public GameObject b19;
    public GameObject b20;
    public GameObject b21;
    public GameObject b22;
    public GameObject b23;
    public GameObject b24;
    public GameObject b25;
    public GameObject b26;
    public GameObject b27;
    public GameObject b28;
    public GameObject b29;
    public GameObject b30;
    public GameObject b31;
    public GameObject b32;
    public GameObject b33;
    public GameObject b34;
    public GameObject b35;
    public GameObject b36;
    public GameObject b37;
    public GameObject b38;
    public GameObject b39;
    public GameObject b40;
    public GameObject b41;
    public GameObject b42;
    public GameObject b43;
    public GameObject b44;
    public GameObject b45;
    public GameObject b46;
    public GameObject b47;
    public GameObject b48;
    public GameObject b49;
    public GameObject b50;

    public void Refresh()
    {
        string conexion = presets.server;
        string t_productos = presets.existencia;
        string categoria = presets.categoria;
        string accion = "SELECT COUNT(*) FROM " + t_productos + " WHERE categoria1 = '" + categoria + "'";

        MySqlConnection conn = new MySqlConnection(conexion);
        MySqlCommand consola = new MySqlCommand(accion, conn);

        conn.Open();

        MySqlDataReader datos = consola.ExecuteReader();

        while (datos.Read())
        {
            
        }
        int count = datos.GetInt32(0);

        conn.Close();


        int b = 0;
        List<string> productos = new List<string>();

        while (b < count)
        {
            string data = "SELECT producto FROM " + t_productos + " WHERE categoria1 = '" + categoria + "' ORDER BY id DESC LIMIT " + b + ",1";

            MySqlCommand dat = new MySqlCommand(data, conn);

            conn.Open();

            MySqlDataReader cc = dat.ExecuteReader();

            while (cc.Read())
            {

            }
            productos.Add("" + cc.GetString(0) + "");

            conn.Close();
            b++;
            if (b == count)
            {
                datos.Close();
                cc.Close();
                break;
            }
        }

        int capturados = productos.Count;
        int p_1 = capturados - 1;
        int posicion = p_1;
        int num = 0;

        if (num < capturados)
        {
            b1.SetActive(true);
            p1.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b2.SetActive(true);
            p2.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b3.SetActive(true);
            p3.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b4.SetActive(true);
            p4.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b5.SetActive(true);
            p5.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b6.SetActive(true);
            p6.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b7.SetActive(true);
            p7.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b8.SetActive(true);
            p8.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b9.SetActive(true);
            p9.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b10.SetActive(true);
            p10.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b11.SetActive(true);
            p11.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b12.SetActive(true);
            p12.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b13.SetActive(true);
            p13.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b14.SetActive(true);
            p14.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b15.SetActive(true);
            p15.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b16.SetActive(true);
            p16.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b17.SetActive(true);
            p17.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b18.SetActive(true);
            p18.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b19.SetActive(true);
            p19.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b20.SetActive(true);
            p20.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b21.SetActive(true);
            p21.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b22.SetActive(true);
            p22.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b23.SetActive(true);
            p23.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b24.SetActive(true);
            p24.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b25.SetActive(true);
            p25.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b26.SetActive(true);
            p26.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b27.SetActive(true);
            p27.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b28.SetActive(true);
            p28.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b29.SetActive(true);
            p29.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b30.SetActive(true);
            p30.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b31.SetActive(true);
            p31.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b32.SetActive(true);
            p32.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b33.SetActive(true);
            p33.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b34.SetActive(true);
            p34.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b35.SetActive(true);
            p35.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b36.SetActive(true);
            p36.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b37.SetActive(true);
            p37.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b38.SetActive(true);
            p38.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b39.SetActive(true);
            p39.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b40.SetActive(true);
            p40.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b41.SetActive(true);
            p41.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b42.SetActive(true);
            p42.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b43.SetActive(true);
            p43.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b44.SetActive(true);
            p44.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b45.SetActive(true);
            p45.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b46.SetActive(true);
            p46.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b47.SetActive(true);
            p47.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b48.SetActive(true);
            p48.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b49.SetActive(true);
            p49.text = productos[posicion];
            num++;
            posicion--;
        }
        if (num < capturados)
        {
            b50.SetActive(true);
            p50.text = productos[posicion];
            num++;
            posicion--;
        }
    }

    public Text exist_t;
    public Text precio_t;

    public void Precios()
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

    public GameObject box;
    public Text producto;

    public void A()
    {
        PlayerPrefs.SetString("Producto", p1.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AA()
    {
        PlayerPrefs.SetString("Producto", p2.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AB()
    {
        PlayerPrefs.SetString("Producto", p3.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AC()
    {
        PlayerPrefs.SetString("Producto", p4.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AD()
    {
        PlayerPrefs.SetString("Producto", p5.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AE()
    {
        PlayerPrefs.SetString("Producto", p6.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AF()
    {
        PlayerPrefs.SetString("Producto", p7.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AG()
    {
        PlayerPrefs.SetString("Producto", p8.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AH()
    {
        PlayerPrefs.SetString("Producto", p9.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AI()
    {
        PlayerPrefs.SetString("Producto", p10.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AJ()
    {
        PlayerPrefs.SetString("Producto", p11.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AK()
    {
        PlayerPrefs.SetString("Producto", p12.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AL()
    {
        PlayerPrefs.SetString("Producto", p13.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AM()
    {
        PlayerPrefs.SetString("Producto", p14.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AN()
    {
        PlayerPrefs.SetString("Producto", p15.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AO()
    {
        PlayerPrefs.SetString("Producto", p16.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AP()
    {
        PlayerPrefs.SetString("Producto", p17.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AQ()
    {
        PlayerPrefs.SetString("Producto", p18.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AR()
    {
        PlayerPrefs.SetString("Producto", p19.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AS()
    {
        PlayerPrefs.SetString("Producto", p20.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AT()
    {
        PlayerPrefs.SetString("Producto", p21.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AV()
    {
        PlayerPrefs.SetString("Producto", p22.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AW()
    {
        PlayerPrefs.SetString("Producto", p23.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AX()
    {
        PlayerPrefs.SetString("Producto", p24.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AY()
    {
        PlayerPrefs.SetString("Producto", p25.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void AZ()
    {
        PlayerPrefs.SetString("Producto", p26.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void B()
    {
        PlayerPrefs.SetString("Producto", p27.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BA()
    {
        PlayerPrefs.SetString("Producto", p28.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BB()
    {
        PlayerPrefs.SetString("Producto", p29.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BC()
    {
        PlayerPrefs.SetString("Producto", p30.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BD()
    {
        PlayerPrefs.SetString("Producto", p31.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BE()
    {
        PlayerPrefs.SetString("Producto", p32.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BF()
    {
        PlayerPrefs.SetString("Producto", p33.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BG()
    {
        PlayerPrefs.SetString("Producto", p34.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BH()
    {
        PlayerPrefs.SetString("Producto", p35.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BI()
    {
        PlayerPrefs.SetString("Producto", p36.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BJ()
    {
        PlayerPrefs.SetString("Producto", p37.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BK()
    {
        PlayerPrefs.SetString("Producto", p38.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BL()
    {
        PlayerPrefs.SetString("Producto", p39.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BM()
    {
        PlayerPrefs.SetString("Producto", p40.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BN()
    {
        PlayerPrefs.SetString("Producto", p41.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BO()
    {
        PlayerPrefs.SetString("Producto", p42.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BP()
    {
        PlayerPrefs.SetString("Producto", p43.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BQ()
    {
        PlayerPrefs.SetString("Producto", p44.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BR()
    {
        PlayerPrefs.SetString("Producto", p45.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BS()
    {
        PlayerPrefs.SetString("Producto", p46.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BT()
    {
        PlayerPrefs.SetString("Producto", p47.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BV()
    {
        PlayerPrefs.SetString("Producto", p48.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BW()
    {
        PlayerPrefs.SetString("Producto", p49.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }
    public void BX()
    {
        PlayerPrefs.SetString("Producto", p50.text);
        Main.CargaGeneral(presets);
        box.SetActive(true);
        producto.text = presets.producto;
    }

    public InputField ingreso;
    public Button registrar;
    public GameObject error;

    public void Registro()
    {
        string movimiento = presets.movimiento;

        if (movimiento == "Salida")
        {

            try
            {
                string conexion = presets.server;
                string existencia = presets.existencia;
                string producto = presets.producto;
                string numero = ingreso.text;
                int cantidad = Int32.Parse(numero);
                string comprobacion = "SELECT existencia_final FROM " + existencia + " WHERE producto= '" + producto + "'";

                MySqlConnection conn = new MySqlConnection(conexion);
                MySqlCommand cateo = new MySqlCommand(comprobacion, conn);

                conn.Open();

                MySqlDataReader datos = cateo.ExecuteReader();

                while (datos.Read())
                {

                }

                int condicion = datos.GetInt32(0);

                conn.Close();

                if (cantidad <= condicion)
                {

                    string tabla = presets.temp;
                    string accion = "INSERT INTO " + tabla + " VALUES ('0', '" + producto + "', '" + cantidad + "')";

                    MySqlCommand consola = new MySqlCommand(accion, conn);

                    conn.Open();

                    consola.ExecuteReader();

                    conn.Close();
                    datos.Close();

                    ingreso.text = "";

                    PlayerPrefs.SetInt("Condicional", 1);
                    Main.CargaGeneral(presets);
                    box.SetActive(false);
                    if (presets.condicional == 1)
                    {
                        registrar.interactable = true;
                    }
                }

                if (cantidad > condicion)
                {
                    error.SetActive(true);
                    StartCoroutine(Falta());
                    datos.Close();
                }
            }
            catch (MySqlException error)
            {
                Debug.LogError("ERROR: " + error);
            }
            IEnumerator Falta()
            {
                yield return new WaitForSeconds(4f);
                error.SetActive(false);
            }
        }

        if (movimiento == "Entrada")
        {
            try
            {
                string conexion = presets.server;
                string producto = presets.producto;
                string t_captura = presets.temp_captura;

                string numero = ingreso.text;
                int cantidad = Int32.Parse(numero);

                string captura = "INSERT INTO " + t_captura + " VALUES ('0', '" + producto + "', '" + cantidad + "')";

                MySqlConnection conn = new MySqlConnection(conexion);
                MySqlCommand consola = new MySqlCommand(captura, conn);

                conn.Open();

                consola.ExecuteReader();

                conn.Close();

                ingreso.text = "";

                PlayerPrefs.SetInt("Condicional", 1);
                Main.CargaGeneral(presets);
                box.SetActive(false);
                if (presets.condicional == 1)
                {
                    registrar.interactable = true;
                }
            }
            catch (MySqlException error)
            {
                Debug.LogError("ERROR: " + error);
            }
        }
    }
    public void Cancelar()
    {
        box.SetActive(false);
        ingreso.text = ""; 
        PlayerPrefs.SetString("Producto", "X");
        Main.CargaGeneral(presets);
    }
}
