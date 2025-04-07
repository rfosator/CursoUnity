using UnityEngine;

public class ChangeCubeColor : MonoBehaviour
{
    public GameObject Cubo;
    public GameObject Esfera;
    public GameObject Capsula;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var color = new Color(Random.value, Random.value, Random.value);
        Capsula.GetComponent<MeshRenderer>().material.color = color;
    }

    private void Awake()
    {
        var color = new Color(Random.value, Random.value, Random.value);
        Cubo.GetComponent<MeshRenderer>().material.color = color;
    }

    private void LateUpdate()
    {
        var color = new Color(Random.value, Random.value, Random.value);
        Esfera.GetComponent<MeshRenderer>().material.color = color;
    }

    private void OnDestroy()
    {
        Destroy(Cubo);
        Destroy(Esfera);
        Destroy(Capsula);
    }
}
