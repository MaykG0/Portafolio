using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Añadir : MonoBehaviour
{
    public InputField Dinero;
    public InputField Nota;
    public Presets presets;
    public GameObject PanelAñadir;
    public Text DineroTxt;

    public GameObject Letra;
    public GameObject Mostrador;

    public GameObject Boton;
    public GameObject Canvas;

    public void Aceptar()
    {
        Main.CargaGeneral(presets);
        int RegistroTotal_I = presets.RegistroTotal_I;
        int Diario = presets.RegistrosI_Diario;
        int Mes = presets.RegistroI_Mes;
        int Ano = presets.RegistroI_Ano;
        int General = presets.RegistroTotal_Gen;
        string Movimiento = "Ingreso";

        float Ingreso = float.Parse(Dinero.text);
        float Banco = presets.DineroTotal;
        string Escrito = Nota.text;

        int RegistroTotalP_I = RegistroTotal_I + 1;
        int DiarioP = Diario + 1;
        int MesP = Mes + 1;
        int AnoP = Ano + 1;
        int GeneralP = General + 1;
        float Resumen = Banco + Ingreso;

        PlayerPrefs.SetInt("RegistroTotal_I", RegistroTotalP_I);
        PlayerPrefs.SetInt("RegistroTotal_Gen", GeneralP);
        PlayerPrefs.SetInt("Diario_I", DiarioP);
        PlayerPrefs.SetInt("Mes_I", MesP);
        PlayerPrefs.SetInt("Ano_I", AnoP);

        var Hora = System.DateTime.Now.Hour.ToString("00") + ":" +
            System.DateTime.Now.Minute.ToString("00") + ":" +
            System.DateTime.Now.Second.ToString("00");

        var Fecha = System.DateTime.Now.Year.ToString("0000") + "/" +
            System.DateTime.Now.Month.ToString("00") + "/" +
            System.DateTime.Now.Day.ToString("00");

        PlayerPrefs.SetFloat("" + RegistroTotalP_I + "" + "IngresoI", Ingreso);
        PlayerPrefs.SetString("" + RegistroTotalP_I + "" + "IngresoE", Escrito);
        PlayerPrefs.SetString("" + RegistroTotalP_I + "" + "IngresoF", Fecha);
        PlayerPrefs.SetString("" + RegistroTotalP_I + "" + "IngresoH", Hora);

        PlayerPrefs.SetString("" + GeneralP + "" + "GeneralM", Movimiento);
        PlayerPrefs.SetFloat("" + GeneralP + "" + "GeneralI", Ingreso);
        PlayerPrefs.SetString("" + GeneralP + "" + "GeneralE", Escrito);
        PlayerPrefs.SetString("" + GeneralP + "" + "GeneralF", Fecha);
        PlayerPrefs.SetString("" + GeneralP + "" + "GeneralH", Hora);
        PlayerPrefs.SetInt("" + GeneralP + "" + "General_PosIngreso", RegistroTotalP_I);

        PlayerPrefs.SetFloat("DineroTotal", Resumen);

        Main.CargaGeneral(presets);

        int Registros = presets.RegistroTotal_Gen;

        DineroTxt.text = Resumen.ToString() + "$";
        Dinero.text = "";
        Nota.text = "";

        PanelAñadir.SetActive(false);
    }
}
