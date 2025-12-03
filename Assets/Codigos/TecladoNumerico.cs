using TMPro;
using UnityEngine;

public class TecladoNumerico : MonoBehaviour
{
    [Header("Código Correcto (4 dígitos)")]
    public string codigoCorrecto = "1234";

    [Header("Texto donde se escribe el código")]
    public TextMeshProUGUI textoCodigo;

    [Header("Texto del mensaje de estado (Correcto / Incorrecto)")]
    public TextMeshProUGUI mensajeEstado;

    private string codigoIngresado = "";

    [Header("Evento a Activar (puerta, objeto, etc.)")]
    public GameObject puerta;

    public void BotonNumero(int numero)
    {
        if (codigoIngresado.Length >= 4)
            return;

        codigoIngresado += numero.ToString();
        textoCodigo.text = codigoIngresado;

        if (codigoIngresado.Length == 4)
        {
            VerificarCodigo();
        }
    }

    public void BotonBorrar()
    {
        codigoIngresado = "";
        textoCodigo.text = "";
        mensajeEstado.text = "";
    }

    void VerificarCodigo()
    {
        if (codigoIngresado == codigoCorrecto)
        {
            mensajeEstado.text = "<color=green>✔ Código Correcto</color>";

            if (puerta != null)
                puerta.SetActive(true);
        }
        else
        {
            mensajeEstado.text = "<color=red>✘ Código Incorrecto</color>";
            Debug.Log("Código Incorrecto — No se abre");
        }

        // Limpiar pantalla después de 1 segundo
        Invoke(nameof(BotonBorrar), 1f);
    }
}

