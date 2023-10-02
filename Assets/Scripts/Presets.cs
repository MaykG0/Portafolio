using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presets : MonoBehaviour
{
    //Registros
    public int ticket = 1;
    public int condicional = 0;
    public int ticket_salida = 1;
    public int continuar = 0;
    public int ticket_entrada = 1;

    //Fundamentales

    public string empleado = "Mayk";
    public string sucursal = "X";
    public string sucursal_entrada = "X";
    public string movimiento = "X";
    public string operador = "X";

    //Principal

    public string server = "Server=0.0.0.0;Database=maykbasemk_1;Uid=posmc;Pwd=12345;";
    public string empleados = "empleados_log";

    public string producto = "X";
    public string categoria = "X";

    //Bases

    public string temp = "temp_productos";
    public string temp_captura = "temp_captura";
    public string registro = "traslados_registro";
    public string t_entradas = "traslados_entrada";
    public string existencia = "productos_panaderia";
    public string sucursales = "traslados_sucursales";
    public string remoto = "traslados_entrada_remoto";
    public string entrada = "traslados_entrada_captura";

    //Complementos

    public string ip = "0.0.0.0";
    public string data = "maykbasemk_1";
    public string user = "posmc";
    public string password = "12345";

    //Sucursales

    public string Estacion = "Server=0.0.0.0;Database=maykbasemk_1;Uid=posmc;Pwd=12345;";
    public string Tlaltenco = "Server=0.0.0.0;Database=maykbasemk_1;Uid=posmc;Pwd=12345;";
    public string SantaM = "Server=0.0.0.0;Database=maykbasemk_1;Uid=posmc;Pwd=12345;";
}
