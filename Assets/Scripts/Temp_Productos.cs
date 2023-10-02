using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using MySql.Data.MySqlClient;

public class Temp_Productos : MonoBehaviour
{
    public Presets presets;
    public InputField cantidadIngreso;
    public Text producto;
    public GameObject ingreso;
    public Button registrar;
    public GameObject falta;

    //Boton Cancelar

    public void Cancelar()
    {
        ingreso.SetActive(false);
        PlayerPrefs.SetString("Producto", "X");
        Main.CargaGeneral(presets);
    }

    //Cambios de producto
    //Pan Blanco
    public void Bolillo()
    {
        PlayerPrefs.SetString("Producto", "Bolillo");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Español()
    {
        PlayerPrefs.SetString("Producto", "Español");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Chapata()
    {
        PlayerPrefs.SetString("Producto", "Chapata");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Cascaras()
    {
        PlayerPrefs.SetString("Producto", "Cascaras");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Barra4T()
    {
        PlayerPrefs.SetString("Producto", "Barra 4T");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Telera1_Medio()
    {
        PlayerPrefs.SetString("Producto", "Telera 1 1/2");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Barra3T()
    {
        PlayerPrefs.SetString("Producto", "Barra 3T");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void ChapataChica()
    {
        PlayerPrefs.SetString("Producto", "Chapata chica");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Palitos()
    {
        PlayerPrefs.SetString("Producto", "Palitos");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Rollos()
    {
        PlayerPrefs.SetString("Producto", "Rollos");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Bollos()
    {
        PlayerPrefs.SetString("Producto", "Bollos");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Barra2T()
    {
        PlayerPrefs.SetString("Producto", "Barra 2T");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Barra1T()
    {
        PlayerPrefs.SetString("Producto", "Barra 1T");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void PanRustico()
    {
        PlayerPrefs.SetString("Producto", "Pan rustico");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void BolilloAjonjoli()
    {
        PlayerPrefs.SetString("Producto", "Bolillo C/Ajonjoli");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void BolilloIntegral()
    {
        PlayerPrefs.SetString("Producto", "Bolillo integral");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Pambazo()
    {
        PlayerPrefs.SetString("Producto", "Pambazo");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Hueso()
    {
        PlayerPrefs.SetString("Producto", "Hueso");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Campesino()
    {
        PlayerPrefs.SetString("Producto", "Campesino");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void MiniBolilloLim()
    {
        PlayerPrefs.SetString("Producto", "Mini Bolillo Lim");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void PanNuez()
    {
        PlayerPrefs.SetString("Producto", "Pan Nuez");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void PambazoBocadillo()
    {
        PlayerPrefs.SetString("Producto", "Pambazo Bocadillo");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Barra()
    {
        PlayerPrefs.SetString("Producto", "Barra");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Teleraconajonjoli()
    {
        PlayerPrefs.SetString("Producto", "Telera/Ajonjoli");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Cocodriloch()
    {
        PlayerPrefs.SetString("Producto", "Cocodrilo Ch");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Cocodrilogrd()
    {
        PlayerPrefs.SetString("Producto", "Cocodrilo Grd");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Figura()
    {
        PlayerPrefs.SetString("Producto", "Figura");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Gallinas()
    {
        PlayerPrefs.SetString("Producto", "Gallinas");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    //Pan Dulce
    public void Biscocho75()
    {
        PlayerPrefs.SetString("Producto", "Biscocho75");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Resposteria13()
    {
        PlayerPrefs.SetString("Producto", "Reposteria13");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void EmpanadaVigilia()
    {
        PlayerPrefs.SetString("Producto", "Empanada Vigilia");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void CubileteFruta()
    {
        PlayerPrefs.SetString("Producto", "Cubilete Fruta");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void PayGrande()
    {
        PlayerPrefs.SetString("Producto", "Pay Grande");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void ConchaRellena()
    {
        PlayerPrefs.SetString("Producto", "Concha Rellena");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Hojaldra()
    {
        PlayerPrefs.SetString("Producto", "Hojaldra");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void HojaldraMed()
    {
        PlayerPrefs.SetString("Producto", "Hojaldra Med");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Biscocho9()
    {
        PlayerPrefs.SetString("Producto", "Biscocho9");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Reposteria10()
    {
        PlayerPrefs.SetString("Producto", "Reposteria10");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Reposteria15()
    {
        PlayerPrefs.SetString("Producto", "Reposteria15");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Panmini()
    {
        PlayerPrefs.SetString("Producto", "Pan mini");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void PanGrande()
    {
        PlayerPrefs.SetString("Producto", "Pan Grande");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void PastaSecach()
    {
        PlayerPrefs.SetString("Producto", "Pasta Seca Ch");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void PayElote()
    {
        PlayerPrefs.SetString("Producto", "Pay Elote");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void PastaSecagrd()
    {
        PlayerPrefs.SetString("Producto", "Pasta Seca Grd");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void RoscaGrd()
    {
        PlayerPrefs.SetString("Producto", "Rosca Grd");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void RoscaCh()
    {
        PlayerPrefs.SetString("Producto", "Rosca Ch");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void RoscaGrdChoco()
    {
        PlayerPrefs.SetString("Producto", "Rosca Grd Choco");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void RoscaChChoco()
    {
        PlayerPrefs.SetString("Producto", "Rosca Ch Choco");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void PayConFrutaGrd()
    {
        PlayerPrefs.SetString("Producto", "Pay C/Fruta Grd");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    //Gelatinas
    public void Gelatina()
    {
        PlayerPrefs.SetString("Producto", "Gelatina");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelJumbo()
    {
        PlayerPrefs.SetString("Producto", "Gel. Jumbo");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelCopa()
    {
        PlayerPrefs.SetString("Producto", "Gel. Copa");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelVasoGrande()
    {
        PlayerPrefs.SetString("Producto", "Gel. Vaso Gde");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelVasoChico()
    {
        PlayerPrefs.SetString("Producto", "Gel. Vaso Ch");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelCapasillo()
    {
        PlayerPrefs.SetString("Producto", "Gel. Capasillo");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelTorre()
    {
        PlayerPrefs.SetString("Producto", "Gel. Torre");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void NapolitanoGde()
    {
        PlayerPrefs.SetString("Producto", "Napolitano Gde");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void NapolitanoInd()
    {
        PlayerPrefs.SetString("Producto", "Napolitano Ind");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void NapolitanoCh()
    {
        PlayerPrefs.SetString("Producto", "Napolitano Ch");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void NapolitanoMini()
    {
        PlayerPrefs.SetString("Producto", "Napolitano Mini");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelRosca()
    {
        PlayerPrefs.SetString("Producto", "Gel Rosca");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelDomoInd()
    {
        PlayerPrefs.SetString("Producto", "Gel. Domo Ind");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Tulipan()
    {
        PlayerPrefs.SetString("Producto", "Tulipan");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Trufa()
    {
        PlayerPrefs.SetString("Producto", "Trufa");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Reynas()
    {
        PlayerPrefs.SetString("Producto", "Reynas");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Chocorrol()
    {
        PlayerPrefs.SetString("Producto", "Chocorrol");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void TartaFruta()
    {
        PlayerPrefs.SetString("Producto", "Tarta de fruta");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelVasoFantasia()
    {
        PlayerPrefs.SetString("Producto", "Gel Vaso Fantasia");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelDomoPasta()
    {
        PlayerPrefs.SetString("Producto", "Gel.Domo Pasta");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelRellena()
    {
        PlayerPrefs.SetString("Producto", "Gelatina Rellena");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelCopaRumba()
    {
        PlayerPrefs.SetString("Producto", "Gelatina Copa Rumba");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelatinaArtistica()
    {
        PlayerPrefs.SetString("Producto", "Gelatina Artistica");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void BrochetaBombon()
    {
        PlayerPrefs.SetString("Producto", "Brocheta Bombon");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Moquitas()
    {
        PlayerPrefs.SetString("Producto", "Moquitas");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void FresasDeco()
    {
        PlayerPrefs.SetString("Producto", "Fresas Decoradas");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelUnicornio()
    {
        PlayerPrefs.SetString("Producto", "Gelatina Unicornio");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void MiniPay()
    {
        PlayerPrefs.SetString("Producto", "Mini pay");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Perritos()
    {
        PlayerPrefs.SetString("Producto", "Perritos");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void GelMediaBanda()
    {
        PlayerPrefs.SetString("Producto", "Gelatina 1/2 Banda");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    //Bocadillos
    public void Boloban()
    {
        PlayerPrefs.SetString("Producto", "Boloban");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Bocadillo12()
    {
        PlayerPrefs.SetString("Producto", "Bocadillo12");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Bocadillotrescuartos()
    {
        PlayerPrefs.SetString("Producto", "Bocadillo 3/4");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    //Pastel
    public void Pastel()
    {
        PlayerPrefs.SetString("Producto", "Pastel");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Leches3CR()
    {
        PlayerPrefs.SetString("Producto", "3 Leches C/R");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Leches3SR()
    {
        PlayerPrefs.SetString("Producto", "3 Leches S/R");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Cuadro()
    {
        PlayerPrefs.SetString("Producto", "Cuadro");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void CuadroEspecial()
    {
        PlayerPrefs.SetString("Producto", "Cuadro Especial");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Especial()
    {
        PlayerPrefs.SetString("Producto", "Especial");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Decoracion()
    {
        PlayerPrefs.SetString("Producto", "Decoracion");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Treslechesnormalcrch()
    {
        PlayerPrefs.SetString("Producto", "Tres Leches Normal C/R");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void TresLechesCRch()
    {
        PlayerPrefs.SetString("Producto", "Tres Leches C/R CH");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void TresLechesSRch()
    {
        PlayerPrefs.SetString("Producto", "3 Leches S/R Ch");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void TresLechesSRgrd()
    {
        PlayerPrefs.SetString("Producto", "Tres Leches S/R Grd");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void BandaMedia()
    {
        PlayerPrefs.SetString("Producto", "1/2 Banda");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Banda()
    {
        PlayerPrefs.SetString("Producto", "Banda");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void MiniBanda()
    {
        PlayerPrefs.SetString("Producto", "Mini Banda");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void PastelInd3()
    {
        PlayerPrefs.SetString("Producto", "Pastel Ind 3 Lech");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void PastelInd()
    {
        PlayerPrefs.SetString("Producto", "Pastel Ind");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Rebanada()
    {
        PlayerPrefs.SetString("Producto", "Rebanada Pastel");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Chiscake()
    {
        PlayerPrefs.SetString("Producto", "Chiscake");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    //Varios
    public void Vela30()
    {
        PlayerPrefs.SetString("Producto", "Vela 30");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Vela70()
    {
        PlayerPrefs.SetString("Producto", "Vela 70");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Vela35()
    {
        PlayerPrefs.SetString("Producto", "Vela 35");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Vela40()
    {
        PlayerPrefs.SetString("Producto", "Vela 40");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Vela45()
    {
        PlayerPrefs.SetString("Producto", "Vela 45");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Vela50()
    {
        PlayerPrefs.SetString("Producto", "Vela 50");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Vela60()
    {
        PlayerPrefs.SetString("Producto", "Vela 60");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Pastillaje1()
    {
        PlayerPrefs.SetString("Producto", "Pastillaje1");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Pastillaje2()
    {
        PlayerPrefs.SetString("Producto", "Pastillaje2");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Animas()
    {
        PlayerPrefs.SetString("Producto", "Animas");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Costal()
    {
        PlayerPrefs.SetString("Producto", "Costal");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Caja()
    {
        PlayerPrefs.SetString("Producto", "Caja");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Vela20()
    {
        PlayerPrefs.SetString("Producto", "Vela20");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Velapirotecnia15()
    {
        PlayerPrefs.SetString("Producto", "Vela Pirotecnia15");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void PastillajePastel()
    {
        PlayerPrefs.SetString("Producto", "Pastillaje Pastel");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void BolsaPlastico()
    {
        PlayerPrefs.SetString("Producto", "Bolsa Plastico");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void BolsaJumbo30()
    {
        PlayerPrefs.SetString("Producto", "Bolsa Jumbo3");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }
    public void Bolsabio()
    {
        PlayerPrefs.SetString("Producto", "Bolsa Bio");
        Main.CargaGeneral(presets);
        ingreso.SetActive(true);
        producto.text = presets.producto;
    }

    //Carga de precios y existencias

    public Text p;
    public Text c;

    //

    private void Update()
    {
        string conexion = presets.server;
        string existencia = presets.existencia;
        string producto = presets.producto;
        string a = "SELECT precio, existencia_final FROM " + existencia + " WHERE producto = '" + producto + "'";

        MySqlConnection conn = new MySqlConnection(conexion);
        MySqlCommand b = new MySqlCommand(a, conn);

        conn.Open();

        MySqlDataReader datos2 = b.ExecuteReader();

        while (datos2.Read())
        {

        }

        double price = datos2.GetDouble(0);
        int mount = datos2.GetInt32(1);

        string pp = price.ToString();
        string mm = mount.ToString();

        p.text = pp;
        c.text = mm;

        conn.Close();
        datos2.Close();
    }

    //Carga del temp

    public void Registrar()
    {
        try
        {
            string conexion = presets.server;
            string existencia = presets.existencia;
            string producto = presets.producto;


            string numero = cantidadIngreso.text;
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

                PlayerPrefs.SetInt("Condicional", 1);
                Main.CargaGeneral(presets);
                ingreso.SetActive(false);
                if (presets.condicional == 1)
                {
                    registrar.interactable = true;
                }
            }

            if (cantidad > condicion)
            {
                falta.SetActive(true);
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
            falta.SetActive(false);
        }
    }
}
