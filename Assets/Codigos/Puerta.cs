using UnityEngine;

public class Puerta : MonoBehaviour
{
    public Animator puertaAnimacion;
    public AudioSource fuenteAudio;
    public AudioClip sonidoPuerta;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            puertaAnimacion.Play("Abrir");
            fuenteAudio.PlayOneShot(sonidoPuerta);
            Debug.Log("Reproduciendo sonido");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            puertaAnimacion.Play("Cerrar");
            fuenteAudio.PlayOneShot(sonidoPuerta);
        }
    }
}