using UnityEngine;

public class ChangeCylinder : MonoBehaviour
{
    public GameObject Cilindro;
    public GameObject Cubo;
    public GameObject CuboReplica;

    public bool Enabled;

    private void FixedUpdate()
    {
        bool cube = Cubo.GetComponent<ChangeCubeColor>().Enabled;
        bool replicaCube = CuboReplica.GetComponent<ChangeReplicaCubeColor>().Enabled;
        /* Se establece el estado del cubo en función de la disyunción (OR) 
         * de los estados de la esfera y la capsula */
        Enabled = cube && replicaCube;

        Color color = Enabled ? Color.white : Color.black;
        Cilindro.GetComponent<MeshRenderer>().material.color = color;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.fixedDeltaTime = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
