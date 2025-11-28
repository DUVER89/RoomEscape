using UnityEngine;

public class PortalTeletransporte : MonoBehaviour
{
    [Header("Punto al que será teletransportado el jugador")]
    public Transform puntoDeSalida;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = puntoDeSalida.position;

        }
    }
}