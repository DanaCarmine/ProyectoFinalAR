using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTipo : MonoBehaviour
{
    // =========================
    // MODELO BASE
    // =========================
    [Header("Modelo Base")]
    public GameObject dressForm1;

    // =========================
    // TRAJES
    // =========================
    [Header("Modelos de Trajes")]
    public GameObject trajeSlimFit;
    public GameObject trajeClasico;

    // =========================
    // PANELES UI
    // =========================
    [Header("Paneles UI")]
    public GameObject panelTipoTraje;

    public GameObject panelSlim;
    public GameObject panelClasico;

    public GameObject textoSeleccionTraje;

    // =========================
    // CUELLOS SLIM FIT
    // =========================
    [Header("Cuellos Slim Fit")]
    public GameObject slimNotch;
    public GameObject slimPeak;
    public GameObject slimShawl;

    // =========================
    // CUELLOS CLÁSICO
    // =========================
    [Header("Cuellos Clásico")]
    public GameObject clasicoNotch;
    public GameObject clasicoPeak;
    public GameObject clasicoShawl;

    // =========================
    // BOTONES SLIM
    // =========================

    [Header("Slim Cazuela")]
    public GameObject slimCazuela1;
    public GameObject slimCazuela2;
    public GameObject slimCazuela3;

    [Header("Slim Forrado")]
    public GameObject slimForrado1;
    public GameObject slimForrado2;
    public GameObject slimForrado3;

    // Mangas slim
    public GameObject mangaSlimCazuela;
    public GameObject mangaSlimForrado;

    // =========================
    // BOTONES CLÁSICO
    // =========================

    [Header("Clasico Cazuela")]
    public GameObject clasicoCazuela1;
    public GameObject clasicoCazuela2;
    public GameObject clasicoCazuela3;

    [Header("Clasico Forrado")]
    public GameObject clasicoForrado1;
    public GameObject clasicoForrado2;
    public GameObject clasicoForrado3;

    // Mangas clásico
    public GameObject mangaClasicoCazuela;
    public GameObject mangaClasicoForrado;

    // =========================
    // TIPO DE BOTÓN ACTUAL
    // =========================

    private string tipoBotonSlim = "Forrado";
    private string tipoBotonClasico = "Forrado";

    // =========================
    // START
    // =========================
    void Start()
    {
        // Maniquí visible
        dressForm1.SetActive(true);

        // Trajes ocultos
        trajeSlimFit.SetActive(false);
        trajeClasico.SetActive(false);

        // Solo panel principal visible
        panelTipoTraje.SetActive(true);

        panelSlim.SetActive(false);
        panelClasico.SetActive(false);

        // Apagar todos los cuellos
        ApagarTodosLosCuellos();

        // Apagar todos los botones
        ApagarTodosLosBotones();
    }

    // =========================
    // APAGAR TODOS LOS BOTONES
    // =========================

    void ApagarTodosLosBotones()
    {
        // Slim cazuela
        slimCazuela1.SetActive(false);
        slimCazuela2.SetActive(false);
        slimCazuela3.SetActive(false);

        // Slim forrado
        slimForrado1.SetActive(false);
        slimForrado2.SetActive(false);
        slimForrado3.SetActive(false);


        // Clasico cazuela
        clasicoCazuela1.SetActive(false);
        clasicoCazuela2.SetActive(false);
        clasicoCazuela3.SetActive(false);

        // Clasico forrado
        clasicoForrado1.SetActive(false);
        clasicoForrado2.SetActive(false);
        clasicoForrado3.SetActive(false);
    }

    // =========================
    // SELECCIONAR SLIM FIT
    // =========================
    public void SeleccionarSlimFit()
    {
        // Oculta maniquí
        dressForm1.SetActive(false);

        // Activa traje slim
        trajeSlimFit.SetActive(true);

        // Oculta clásico
        trajeClasico.SetActive(false);

        // Cambiar paneles
        panelTipoTraje.SetActive(false);

        textoSeleccionTraje.SetActive(false);

        panelSlim.SetActive(true);
        panelClasico.SetActive(false);

        // Cuello default
        ActivarCuelloSlimNotch();

        tipoBotonSlim = "Forrado";
        // Sin botones por defecto
        ApagarTodosLosBotones();

        mangaSlimForrado.SetActive(true);
        mangaSlimCazuela.SetActive(false);

    }

    // =========================
    // SELECCIONAR CLÁSICO
    // =========================
    public void SeleccionarClasico()
    {
        // Oculta maniquí
        dressForm1.SetActive(false);

        // Activa clásico
        trajeClasico.SetActive(true);

        // Oculta slim
        trajeSlimFit.SetActive(false);

        // Cambiar paneles
        panelTipoTraje.SetActive(false);

        textoSeleccionTraje.SetActive(false);

        panelClasico.SetActive(true);
        panelSlim.SetActive(false);

        // Cuello default
        ActivarCuelloClasicoNotch();

        tipoBotonClasico = "Forrado";
        // Sin botones por defecto
        ApagarTodosLosBotones();

        mangaClasicoForrado.SetActive(true);
        mangaClasicoCazuela.SetActive(false);
    }

    // =========================
    // CUELLOS SLIM FIT
    // =========================
    public void ActivarCuelloSlimNotch()
    {
        slimNotch.SetActive(true);
        slimPeak.SetActive(false);
        slimShawl.SetActive(false);
    }

    public void ActivarCuelloSlimPeak()
    {
        slimNotch.SetActive(false);
        slimPeak.SetActive(true);
        slimShawl.SetActive(false);
    }

    public void ActivarCuelloSlimShawl()
    {
        slimNotch.SetActive(false);
        slimPeak.SetActive(false);
        slimShawl.SetActive(true);
    }

    // =========================
    // CUELLOS CLÁSICO
    // =========================
    public void ActivarCuelloClasicoNotch()
    {
        clasicoNotch.SetActive(true);
        clasicoPeak.SetActive(false);
        clasicoShawl.SetActive(false);
    }

    public void ActivarCuelloClasicoPeak()
    {
        clasicoNotch.SetActive(false);
        clasicoPeak.SetActive(true);
        clasicoShawl.SetActive(false);
    }

    public void ActivarCuelloClasicoShawl()
    {
        clasicoNotch.SetActive(false);
        clasicoPeak.SetActive(false);
        clasicoShawl.SetActive(true);
    }

    // =========================
    // APAGAR TODOS LOS CUELLOS
    // =========================
    void ApagarTodosLosCuellos()
    {
        // Slim
        slimNotch.SetActive(false);
        slimPeak.SetActive(false);
        slimShawl.SetActive(false);

        // Clásico
        clasicoNotch.SetActive(false);
        clasicoPeak.SetActive(false);
        clasicoShawl.SetActive(false);
    }

    // =========================
    // SELECCIONAR TIPO BOTÓN SLIM
    // =========================

    public void SlimCazuela()
    {
        tipoBotonSlim = "Cazuela";

        ApagarTodosLosBotones();

        mangaSlimCazuela.SetActive(true);
        mangaSlimForrado.SetActive(false);
    }

    public void SlimForrado()
    {
        tipoBotonSlim = "Forrado";

        ApagarTodosLosBotones();

        mangaSlimForrado.SetActive(true);
        mangaSlimCazuela.SetActive(false);
    }

    // =========================
    // CANTIDAD BOTONES SLIM
    // =========================

    public void SlimBotones(int cantidad)
    {
        ApagarTodosLosBotones();

        // =================
        // CAZUELA
        // =================

        if (tipoBotonSlim == "Cazuela")
        {
            if (cantidad >= 1)
                slimCazuela1.SetActive(true);

            if (cantidad >= 2)
                slimCazuela2.SetActive(true);

            if (cantidad >= 3)
                slimCazuela3.SetActive(true);

            mangaSlimCazuela.SetActive(true);
        }

        // =================
        // FORRADO
        // =================

        if (tipoBotonSlim == "Forrado")
        {
            if (cantidad >= 1)
                slimForrado1.SetActive(true);

            if (cantidad >= 2)
                slimForrado2.SetActive(true);

            if (cantidad >= 3)
                slimForrado3.SetActive(true);

            mangaSlimForrado.SetActive(true);
        }
    }

    // =========================
    // SELECCIONAR TIPO BOTÓN CLÁSICO
    // =========================

    public void ClasicoCazuela()
    {
        tipoBotonClasico = "Cazuela";

        ApagarTodosLosBotones();

        mangaClasicoCazuela.SetActive(true);
        mangaClasicoForrado.SetActive(false);
    }

    public void ClasicoForrado()
    {
        tipoBotonClasico = "Forrado";

        ApagarTodosLosBotones();

        mangaClasicoForrado.SetActive(true);
        mangaClasicoCazuela.SetActive(false);
    }

    // =========================
    // CANTIDAD BOTONES CLÁSICO
    // =========================

    public void ClasicoBotones(int cantidad)
    {
        ApagarTodosLosBotones();

        // =================
        // CAZUELA
        // =================

        if (tipoBotonClasico == "Cazuela")
        {
            if (cantidad >= 1)
                clasicoCazuela1.SetActive(true);

            if (cantidad >= 2)
                clasicoCazuela2.SetActive(true);

            if (cantidad >= 3)
                clasicoCazuela3.SetActive(true);

            mangaClasicoCazuela.SetActive(true);
        }

        // =================
        // FORRADO
        // =================

        if (tipoBotonClasico == "Forrado")
        {
            if (cantidad >= 1)
                clasicoForrado1.SetActive(true);

            if (cantidad >= 2)
                clasicoForrado2.SetActive(true);

            if (cantidad >= 3)
                clasicoForrado3.SetActive(true);

            mangaClasicoForrado.SetActive(true);
        }
    }

    // =========================
    // BOTÓN REGRESAR
    // =========================
    public void Regresar()
    {
        // Mostrar maniquí
        dressForm1.SetActive(true);

        // Ocultar trajes
        trajeSlimFit.SetActive(false);
        trajeClasico.SetActive(false);

        // Apagar cuellos
        ApagarTodosLosCuellos();

        // Apagar botones
        ApagarTodosLosBotones();

        // Mostrar panel principal
        panelTipoTraje.SetActive(true);
        textoSeleccionTraje.SetActive(true);

        // Ocultar paneles secundarios
        panelSlim.SetActive(false);
        panelClasico.SetActive(false);
    }
}