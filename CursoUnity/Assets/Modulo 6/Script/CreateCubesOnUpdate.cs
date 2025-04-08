using UnityEngine;

public class CreateCubes : MonoBehaviour
{
    public GameObject Cube;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Cube = Instantiate(Cube);
        Cube.transform.position = new Vector3(0, 5, 0);
        var renderer = Cube.GetComponent<MeshRenderer>();
        renderer.material.color = new Color(Random.value, Random.value, Random.value);
    }

    public void OnDestroy()
    {
        Destroy(Cube);
    }
}