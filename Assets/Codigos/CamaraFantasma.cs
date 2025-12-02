using UnityEngine;
using UnityEngine.XR;

public class CamaraFantasma : MonoBehaviour
{
    public Camera cam;
    public Renderer pantalla;
    public Vector3 camaraUso;
    public Material materialCamara, apagado;
    Vector3 posicionInicial;
    bool listo;
    InputDevice manoDerecha;
    bool botonB;
    private void Start()
    {
        posicionInicial = transform.localPosition;
        manoDerecha = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    }
    private void Update()
    {
        if (manoDerecha.TryGetFeatureValue(CommonUsages.secondaryButton, out botonB) && botonB)
        {
            listo = !listo;
            cam.enabled = !cam.enabled;
            if (listo)
            {
                transform.localPosition = camaraUso;
                pantalla.material = materialCamara;
            }
            else
            {
                transform.localPosition = posicionInicial;
                pantalla.material = apagado;
            }
        }
    }
}
