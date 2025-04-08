using UnityEngine;

public class CreateCubeOnAwake : MonoBehaviour
{
    public GameObject Cubo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        Cubo = Instantiate(Cubo);
        Cubo.transform.position = new Vector3(-3, 0, -3);
        Cubo.GetComponent<MeshRenderer>().material.color = Color.black;
    }

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
