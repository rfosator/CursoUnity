using UnityEngine;

public class ChangeCapsuleColor : MonoBehaviour
{
    public GameObject Capsula;
    public bool Enabled = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* Se establece el intervalo de actualización en 0.5 segundos
         * con el fin de observar mejor el comportamiento */
        Time.fixedDeltaTime = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        // Se elige el color del GO en función del estado de la variable Enabled 
        Color color = Enabled ? Color.white : Color.black;
        Capsula.GetComponent<MeshRenderer>().material.color = color;
        // Se cambia el estado de True a False y vicerversa en cada FixedUpdate 
        Enabled = !Enabled;
    }

    private void OnDestroy()
    {
        Destroy(Capsula);
    }
}
