using UnityEngine;

public class ChangeCapsuleColor : MonoBehaviour
{
    public GameObject Capsula;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        var color = new Color(Random.value, Random.value, Random.value);
        Capsula.GetComponent<MeshRenderer>().material.color = color;
    }

    private void OnDestroy()
    {
        Destroy(Capsula);
    }
}
