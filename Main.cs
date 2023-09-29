using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using MySql.Data.MySqlClient;

public class Main : MonoBehaviour
{
    public Presets presets;
    public Text empleado;
    public GameObject condicional;
    public Button registrar;

    //Inicio
    void Start()
    {
        CargaGeneral(presets);
        empleado.text = presets.empleado;
        if (presets.condicional == 1)
        {
            registrar.interactable = true;
        }
    }

    //Seleccion de Sucursal

    public void Tlaltenco_S()
    {
        PlayerPrefs.SetString("Operador", "Tlaltenco");
        CargaGeneral(presets);
        SceneManager.LoadScene("LoginUser");
    }
    public void SantaMaria_S()
    {
        PlayerPrefs.SetString("Operador", "SantaMaria");
        CargaGeneral(presets);
        SceneManager.LoadScene("LoginUser");
    }
    public void Estacion_S()
    {
        PlayerPrefs.SetString("Operador", "Estacion");
        CargaGeneral(presets);
        SceneManager.LoadScene("LoginUser");
    }
    public void Otro_S()
    {
        PlayerPrefs.SetString("Operador", "");
        CargaGeneral(presets);
        SceneManager.LoadScene("LoginUser");
    }

    //Carga General de Datos
    public static void CargaGeneral(MonoBehaviour componente)
    {
        Presets presets = (Presets)componente;

        presets.operador = PlayerPrefs.GetString("Operador", "");
        presets.movimiento = PlayerPrefs.GetString("Movimiento", "");

        presets.ticket = PlayerPrefs.GetInt("Ticket", 0);
        presets.ticket_entrada = PlayerPrefs.GetInt("Ticket_Entrada", 0);
        presets.server = PlayerPrefs.GetString("Servidor", "");
        presets.temp = PlayerPrefs.GetString("Temp", "");
        presets.registro = PlayerPrefs.GetString("Registro", "");
        presets.existencia = PlayerPrefs.GetString("Existencia", "");
        presets.empleados = PlayerPrefs.GetString("EmpleadosBase", "");
        presets.empleado = PlayerPrefs.GetString("Empleado", "");
        presets.sucursales = PlayerPrefs.GetString("Sucursales", "");

        presets.producto = PlayerPrefs.GetString("Producto", "");
        presets.sucursal = PlayerPrefs.GetString("Sucursal", "");
        presets.condicional = PlayerPrefs.GetInt("Condicional", 0);
        presets.continuar = PlayerPrefs.GetInt("Continuar", 0);
        presets.categoria = PlayerPrefs.GetString("Categoria", "");

        presets.temp_captura = PlayerPrefs.GetString("TempCaptura", "");
        presets.entrada = PlayerPrefs.GetString("Entrada", "");
        presets.remoto = PlayerPrefs.GetString("Remoto", "");

        presets.ip = PlayerPrefs.GetString("ip", "");
        presets.data = PlayerPrefs.GetString("data", "");
        presets.user = PlayerPrefs.GetString("user", "");
        presets.password = PlayerPrefs.GetString("pass", "");
    }

    //Cambios de escena

    public void EscenaMaestro()
    {
        SceneManager.LoadScene("LoginMaestro");
    }
    public void EscenaLogin()
    {
        SceneManager.LoadScene("LoginUser");
    }
    public void EscenaTraslados()
    {
        SceneManager.LoadScene("Traslados");
    }
    public void EscenaSalida()
    {
        SceneManager.LoadScene("Salida");
        PlayerPrefs.SetString("Movimiento", "Salida");
        PlayerPrefs.SetString("Sucursal", "X");
        CargaGeneral(presets);
    }
    public void EscenaEntrada()
    {
        SceneManager.LoadScene("Entradas");
        PlayerPrefs.SetString("Movimiento", "Entrada");
        PlayerPrefs.SetString("Sucursal", "X");
        CargaGeneral(presets);
    }
    public void EscenaProductos()
    {
        SceneManager.LoadScene("Productos");
    }
    public void EscenaRegistros()
    {
        SceneManager.LoadScene("Registrar");
    }
    public void EscenaInvE()
    {
        SceneManager.LoadScene("Inventario_E");
    }
    public void EscenaPrdE()
    {
        SceneManager.LoadScene("Productos_E");
    }
    public void EscenaRegistrarE()
    {
        SceneManager.LoadScene("Registrar_E");
    }
    public void EscenaEntrada_A()
    {
        SceneManager.LoadScene("Entrada_A");
    }

    //Salida condicional

    public void EscenaSalida_Condicional()
    {
        if (presets.condicional == 0)
        {
            SceneManager.LoadScene("Traslados");
        }

        condicional.SetActive(true);
    }

    public void EscenaSalida_SI()
    {
        try
        {
            string conexion = presets.server;
            string tabla = presets.temp;
            string accion = "DELETE FROM " + tabla + "";

            MySqlConnection conn = new MySqlConnection(conexion);
            MySqlCommand consola = new MySqlCommand(accion, conn);

            conn.Open();

            consola.ExecuteReader();

            conn.Close();
            string accion2 = "ALTER TABLE " + tabla + " AUTO_INCREMENT = 0";

            MySqlCommand restaurar = new MySqlCommand(accion2, conn);

            conn.Open();

            restaurar.ExecuteReader();

            conn.Close();
        }
        catch (MySqlException error)
        {
            Debug.Log("ERROR: " + error);
        }

        PlayerPrefs.SetInt("Condicional", 0);
        CargaGeneral(presets);
        SceneManager.LoadScene("Traslados");
    }

    public void EscenaSalida_NO()
    {
        condicional.SetActive(false);
    }

    //Cambios de sucursal

    public void Tlaltenco()
    {
        PlayerPrefs.SetString("Sucursal", "Tlaltenco");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }
    public void Selene()
    {
        PlayerPrefs.SetString("Sucursal", "Selene");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }
    public void SantaM()
    {
        PlayerPrefs.SetString("Sucursal", "Santa Maria");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }
    public void Altamirano()
    {
        PlayerPrefs.SetString("Sucursal", "Altamirano");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }
    public void Vergel()
    {
        PlayerPrefs.SetString("Sucursal", "Vergel");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }
    public void Estacion()
    {
        PlayerPrefs.SetString("Sucursal", "Estacion");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }
    public void Rosticeria()
    {
        PlayerPrefs.SetString("Sucursal", "Rosticeria");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }
    public void ManuelMlopez()
    {
        PlayerPrefs.SetString("Sucursal", "Manuel M Lopez");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }
    public void Consuelo()
    {
        PlayerPrefs.SetString("Sucursal", "Consuelo");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }
    public void Porvenir()
    {
        PlayerPrefs.SetString("Sucursal", "Porvenir");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }
    public void AltaTension()
    {
        PlayerPrefs.SetString("Sucursal", "Alta Tension");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }
    public void DiazMiron()
    {
        PlayerPrefs.SetString("Sucursal", "Diaz Miron");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }
    public void Silvia()
    {
        PlayerPrefs.SetString("Sucursal", "Silvia");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }
    public void Lorenzo()
    {
        PlayerPrefs.SetString("Sucursal", "Lorenzo");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }
    public void Jorgue()
    {
        PlayerPrefs.SetString("Sucursal", "Jorge");
        PlayerPrefs.SetInt("Continuar", 1);
        CargaGeneral(presets);
        SceneManager.LoadScene("Productos");
    }


    //Cambios de categoria

    public void EscenaPanBlanco()
    {
        PlayerPrefs.SetString("Categoria", "pan_blanco");
        CargaGeneral(presets);
        SceneManager.LoadScene("Inventario");
    }
    public void EscenaPanDulce()
    {
        PlayerPrefs.SetString("Categoria", "pan_dulce");
        CargaGeneral(presets);
        SceneManager.LoadScene("Inventario");
    }
    public void EscenaGelatina()
    {
        PlayerPrefs.SetString("Categoria", "Gelatinas");
        CargaGeneral(presets);
        SceneManager.LoadScene("Inventario");
    }
    public void EscenaBocadillos()
    {
        PlayerPrefs.SetString("Categoria", "Bocadillos");
        CargaGeneral(presets);
        SceneManager.LoadScene("Inventario");
    }
    public void EscenaPasteles()
    {
        PlayerPrefs.SetString("Categoria", "Pasteles");
        CargaGeneral(presets);
        SceneManager.LoadScene("Inventario");
    }
    public void EscenaVarios()
    {
        PlayerPrefs.SetString("Categoria", "Varios");
        CargaGeneral(presets);
        SceneManager.LoadScene("Inventario");
    }

    public void EscenaPanBlancoE()
    {
        PlayerPrefs.SetString("Categoria", "pan_blanco");
        CargaGeneral(presets);
        SceneManager.LoadScene("Inventario_E");
    }
    public void EscenaPanDulceE()
    {
        PlayerPrefs.SetString("Categoria", "pan_dulce");
        CargaGeneral(presets);
        SceneManager.LoadScene("Inventario_E");
    }
    public void EscenaGelatinaE()
    {
        PlayerPrefs.SetString("Categoria", "Gelatinas");
        CargaGeneral(presets);
        SceneManager.LoadScene("Inventario_E");
    }
    public void EscenaBocadillosE()
    {
        PlayerPrefs.SetString("Categoria", "Bocadillos");
        CargaGeneral(presets);
        SceneManager.LoadScene("Inventario_E");
    }
    public void EscenaPastelesE()
    {
        PlayerPrefs.SetString("Categoria", "Pasteles");
        CargaGeneral(presets);
        SceneManager.LoadScene("Inventario_E");
    }
    public void EscenaVariosE()
    {
        PlayerPrefs.SetString("Categoria", "Varios");
        CargaGeneral(presets);
        SceneManager.LoadScene("Inventario_E");
    }

}