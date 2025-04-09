using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int NumeroAleatorio = 0;
    public int Entero = 0;
    public float Flotante = 0;

    public string ColorCubo = "blanco";

    public GameObject Cubo1;
    public GameObject Cubo2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.fixedDeltaTime = 0.5f;

        // Operación entre números flotantes
        int sumaFlotantes = SumaFlotantes(5.6f, 8.4f);
        Debug.Log($"Suma entre flotantes: {sumaFlotantes}");

        // Conversión de flotante a string con cuatro decimales
        // https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#FFormatString
        float flotante = 5.36f;
        Debug.Log($"Conversión de flotante a string: {flotante:F4}");

        // Separar nombre en un arreglo de cadenas (Split)
        string nombreCompleto = "Ramon Fosado Toraya";
        string[] splited = nombreCompleto.Split(' ');
        foreach (var item in splited)
        {
            Debug.Log(item);
        }

        // Separar nombre mediante subcadenas (Substring)
        string nombre = nombreCompleto.Substring(0, 5);
        string paterno = nombreCompleto.Substring(6, 6);
        string materno = nombreCompleto.Substring(13);

        Debug.Log($"Nombre(s): {nombre}, Apellido Paterno: {paterno}, Apellido Materno: {materno}");
    }

    // Update is called once per frame
    void Update()
    {
        // Se incrementa el valor de la variable tipo entero en cada frame
        Entero += 1;
    }

    private void FixedUpdate()
    {
        // Se incrementa el valor de la variable tipo flotante cada cierto tiempo en segundos
        Flotante += 1;
        
        /* Se establece el color del cubo en función del un número 
         * generado aleatoriamente */
        Color color = Color.white;
        NumeroAleatorio = Random.Range( 0, int.MaxValue );
        if (NumeroAleatorio % 2 == 0)
        {
            color = Color.red;
        }
        Cubo1.GetComponent<MeshRenderer>().material.color = color;

        // Se cambia el color del segundo cubo en función del nombre
        Cubo2.GetComponent<MeshRenderer>().material.color = ObtenerColorCubo(ColorCubo);
    }

    private Color ObtenerColorCubo(string color)
    {
        switch (color)
        {
            case "rojo":
                return Color.red;
            case "azul":
                return Color.blue;
            case "verde":
                return Color.green;
            case "purpura":
                return Color.magenta;
            case "negro":
                return Color.black;
            case "gris":
                return Color.gray;
            case "amarillo":
                return Color.yellow;
            default:
                return Color.white;
            
        }
    }

    private int SumaFlotantes(float value1, float value2)
    {
        return (int)(value1 + value2);
    }
}
