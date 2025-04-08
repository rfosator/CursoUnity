using UnityEngine;

public class ChangeCubeColor : MonoBehaviour
{
    public GameObject Cubo;

    void Awake()
    {
        var color = new Color(Random.value, Random.value, Random.value);
        Cubo.GetComponent<MeshRenderer>().material.color = color;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
