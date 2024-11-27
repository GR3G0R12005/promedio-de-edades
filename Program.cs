// escribe un programa que permita ingresar las de edades de 10 personas una por una, el programa debe mostrar el promedio de edades ,mostrar cunatas personas son mayor o igual al promedio y cuales son las edades
//1-pedirle al usuario que ingrese 10 edades
//2-dimensionar el array en 10
//3-

using System.Diagnostics.CodeAnalysis;
int suma = 0 , promedio, contador= 0;

int[] edades = new int[10];

Console.Clear();
for (int i = 0; i < edades.Length; i++)
{
    System.Console.WriteLine($"ingrese la edad, persona {i + 1}");
    edades[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < edades.Length; i++)
{
    suma += edades[i];
}

promedio = suma / 10 ;

Console.WriteLine($"El promedio de edad es :{promedio}");

for (int i = 0; i < edades.Length; i++)
{
    if (edades[i] >= promedio)
    {
        System.Console.WriteLine(edades[i]);
        contador++;
    }

}

Console.WriteLine($"Las personas que tienen la edad mayor o igual al promedio son: {contador}");
