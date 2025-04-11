using System.Collections.Generic;
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

        /* Parte 1 - Ejercicio 2 
         * Operación entre números flotantes */
        int sumaFlotantes = SumaFlotantes(5.6f, 8.4f);
        Debug.Log($"Suma entre flotantes: {sumaFlotantes}");

        /* Parte 1 - Ejercicio 5 
         * Conversión de flotante a string con cuatro decimales */
        // https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#FFormatString
        float flotante = 5.36f;
        Debug.Log($"Conversión de flotante a string: {flotante:F4}");

        // Parte 1 - Ejercicio 6 
        // Separar nombre en un arreglo de cadenas (Split)
        string nombreCompleto = "Ramon Fosado Toraya";
        Split(nombreCompleto);

        // Separar nombre mediante subcadenas (Substring)
        Substrings(nombreCompleto);

        /* Parte 2 - Ejercicio 1 
         * Crear variables tipo string que almacenan valores númericos 
         * y pasar a tipo numérico */
        string stringNumber = "156849";
        int result = ParseStringToInt(stringNumber);   
        Debug.Log($"TryParse con división: {result / 2}");

        /* Parte 2 - Ejercicio 2 
         * Imprimir solo caracteres pares de una cadena de texto */
        string texto = "Prueba de caracteres pares";
        List<char> list = new();
        for (int i = 0; i < texto.Length - 1; i++)
        {
            if (i % 2 == 0)
            {
                list.Add(texto[i]);
            }
        }
        Debug.Log($"Caracteres pares: {string.Concat(list)}");

        /* Parte 2 - Ejercicio 3 
         * Eliminar los primeros 5 caracteres de un texto */
        Debug.Log(texto[4..]);
    }

    // Update is called once per frame
    void Update()
    {
        /* Parte 1 - Ejercicio 1 
         * Se incrementa el valor de la variable tipo entero en cada frame */
        Entero += 1;
    }

    private void FixedUpdate()
    {
        /* Parte 1 - Ejercicio 1 
         * Se incrementa el valor de la variable tipo flotante cada cierto tiempo en segundos */
        Flotante += 1;
        
        /* Parte 1 - Ejercicio 3 
         * Se establece el color dependiendo si es par o impar */
        Color color = Color.white;
        NumeroAleatorio = Random.Range( 0, int.MaxValue );
        if (NumeroAleatorio % 2 == 0)
        {
            color = Color.red;
        }
        Cubo1.GetComponent<MeshRenderer>().material.color = color;

        /* Parte 1 - Ejercicio 4
         * Se cambia el color del segundo cubo en función del nombre del color */
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

    private static void Split(string nombreCompleto)
    {
        string[] splited = nombreCompleto.Split(' ');
        foreach (var item in splited)
        {
            Debug.Log(item);
        }
    }

    private static void Substrings(string nombreCompleto)
    {
        string nombre = nombreCompleto.Substring(0, 5);
        string aPaterno = nombreCompleto.Substring(6, 6);
        string aMaterno = nombreCompleto.Substring(13);

        Debug.Log($"Nombre(s): {nombre}, Apellido Paterno: {aPaterno}, Apellido Materno: {aMaterno}");
    }

    private int ParseStringToInt(string stringNumber)
    {
        if (int.TryParse(stringNumber, out int result))
            return result;

        return 0;
    }
}
