using UnityEngine;

public class ChangeSphereColor : MonoBehaviour
{
    public GameObject Esfera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var color = new Color(Random.value, Random.value, Random.value);
        Esfera.GetComponent<MeshRenderer>().material.color = color;
    }

    private void OnDestroy()
    {
        Destroy(Esfera);
    }
}
