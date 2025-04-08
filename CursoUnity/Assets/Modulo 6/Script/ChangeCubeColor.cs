using UnityEngine;

public class ChangeCubeColor : MonoBehaviour
{
    public GameObject Cubo;
    public GameObject Esfera;
    public GameObject Capsula;

    public bool Enabled;

    private void FixedUpdate()
    {
        bool sphereStatus = Esfera.GetComponent<ChangeSphereColor>().Enabled;
        bool capsuleStatus = Capsula.GetComponent<ChangeCapsuleColor>().Enabled;
        /* Se establece el estado del cubo en funci�n de la conjunci�n (AND)
         * de los estados de la esfera y la capsula */
        Enabled = sphereStatus && capsuleStatus;

        Color color = Enabled ? Color.white : Color.black;
        Cubo.GetComponent<MeshRenderer>().material.color = color;
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

    private void OnDestroy()
    {
        Destroy(Cubo);
    }
}
