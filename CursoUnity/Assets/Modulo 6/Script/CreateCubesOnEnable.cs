using UnityEngine;

public class CreateCubesOnEnable : MonoBehaviour
{
    public GameObject Cubo;

    private GameObject instance1;
    private GameObject instance2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        instance1 = Instantiate(Cubo);
        instance1.GetComponent<MeshRenderer>()
            .material
            .color = GetRandomColor();
        instance1.transform.position = new Vector3(3, 0, -3);
    }

    private void OnDisable()
    {
        try
        {
            instance2 = Instantiate(Cubo);
            instance2.GetComponent<MeshRenderer>()
                .material
                .color = GetRandomColor();
            instance2.transform.position = new Vector3(3, 0, -3);
        }
        catch (System.Exception)
        {
            Debug.LogError("Error al instanciar cubo en OnDisable");
        }
    }

    private void OnDestroy()
    {
        Destroy(Cubo);
        Destroy(instance1);
        Destroy(instance2);
    }

    

    private Color GetRandomColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}
