using UnityEngine;

public class RotarTraje : MonoBehaviour
{
    public GameObject trajeSlim;
    public GameObject trajeClasico;
    public GameObject dressform;

    public float velocidadRotacion = 15f;

    public void GirarIzquierda()
    {
        trajeSlim.transform.Rotate(0, velocidadRotacion, 0);
        trajeClasico.transform.Rotate(0, velocidadRotacion, 0);
        dressform.transform.Rotate(0, velocidadRotacion, 0);
    }

    public void GirarDerecha()
    {
        trajeSlim.transform.Rotate(0, -velocidadRotacion, 0);
        trajeClasico.transform.Rotate(0, -velocidadRotacion, 0);
        dressform.transform.Rotate(0, -velocidadRotacion, 0);
    }
}