using UnityEngine;
using UnityEngine.UI;   // Necesario para usar Image

public class DesactivarImagenUI : MonoBehaviour
{
    public Image imagenUI;   // Asigna aquí la imagen del Canvas

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (imagenUI != null)
            {
                imagenUI.gameObject.SetActive(false);
            }
        }
    }
}

