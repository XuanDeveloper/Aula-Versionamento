using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu peso em kg: ");
        float peso = float.Parse(Console.ReadLine());

        Console.Write("Digite sua altura em metros: ");
        float altura = float.Parse(Console.ReadLine());

        float imc = CalcularIMC(peso, altura);
        string classificacao = ClassificarIMC(imc);

        Console.WriteLine($"Seu IMC é: {imc:F2}");
        Console.WriteLine($"Classificação: {classificacao}");
    }

    static float CalcularIMC(float peso, float altura)
    {
        return peso / (altura * altura);
    }

    static string ClassificarIMC(float imc)
    {
        if (imc < 18.5)
            return "Abaixo do peso";
        else if (imc < 24.9)
            return "Peso normal";
        else if (imc < 29.9)
            return "Sobrepeso";
        else
            return "Obesidade";
    }
}
