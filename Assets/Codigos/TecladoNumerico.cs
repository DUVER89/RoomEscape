using TMPro;
using UnityEngine;

public class TecladoNumerico : MonoBehaviour
{
    [Header("Código Correcto (4 dígitos)")]
    public string codigoCorrecto = "1234";

    [Header("Referencia del Texto donde se escribe")]
    public TextMeshProUGUI textoCodigo;

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
    }

    void VerificarCodigo()
    {
        if (codigoIngresado == codigoCorrecto)
        {
            if (puerta != null)
            {
                puerta.SetActive(true);
            }
        }
        else
        {
            Debug.Log("Código Incorrecto — No se abre");
        }

        Invoke(nameof(BotonBorrar), 0.5f);
    }
}
