using UnityEngine;

public class BillboardUI : MonoBehaviour
{
    public Transform camara;

    void Update()
    {
        transform.LookAt(transform.position + camara.forward);
    }
}