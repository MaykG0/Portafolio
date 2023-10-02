using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BaseDatos : MonoBehaviour
{
    //IngresoPassword

    public Presets presets;
    public InputField password;

    //Bases

    public InputField IP;
    public InputField Bas;
    public InputField Usuario;
    public InputField ContraseñaIni;
    public InputField Temporal;
    public InputField Registro;
    public InputField Existencia;
    public InputField Sucursales;
    public InputField EmpleadosBase;
    public InputField Temp_Entrada;
    public InputField Entrada;
    public InputField Remoto;

    private void Start()
    {
        Main.CargaGeneral(presets);

        IP.text = presets.ip;
        Bas.text = presets.data;
        Usuario.text = presets.user;
        ContraseñaIni.text = presets.password;
        Temporal.text = presets.temp;
        Registro.text = presets.registro;
        Existencia.text = presets.existencia;
        Sucursales.text = presets.sucursales;
        EmpleadosBase.text = presets.empleados;
        Temp_Entrada.text = presets.temp_captura;
        Entrada.text = presets.entrada;
        Remoto.text = presets.remoto;
    }

    //Sucursales






    public void Ajustar()
    {

        string autorizar = password.text;

        if (autorizar == "1608")
        {
            string ip = IP.text;
            string bas = Bas.text;
            string usuario = Usuario.text;
            string contraseña = ContraseñaIni.text;
            string empleados = EmpleadosBase.text;
            string temp = Temporal.text;
            string registro = Registro.text;
            string existencia = Existencia.text;
            string sucursales = Sucursales.text;
            string tempE = Temp_Entrada.text;
            string enter = Entrada.text;
            string remote = Remoto.text;

            string server = "Server=" + ip + ";Database=" + bas + ";Uid=" + usuario + ";Pwd=" + contraseña + ";";

            PlayerPrefs.SetString("Servidor", server);
            PlayerPrefs.SetString("Temp", temp);
            PlayerPrefs.SetString("Registro", registro);
            PlayerPrefs.SetString("Existencia", existencia);
            PlayerPrefs.SetString("EmpleadosBase", empleados);
            PlayerPrefs.SetString("Sucursales", sucursales);

            PlayerPrefs.SetString("TempCaptura", tempE);
            PlayerPrefs.SetString("Entrada", enter);
            PlayerPrefs.SetString("Remoto", remote);

            PlayerPrefs.SetString("ip", ip);
            PlayerPrefs.SetString("data", bas);
            PlayerPrefs.SetString("user", usuario);
            PlayerPrefs.SetString("pass", contraseña);

            SceneManager.LoadScene("LoginUser");
        }
    }
}
