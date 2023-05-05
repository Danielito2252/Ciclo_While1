//Manejo de ciclos - While - do While
//Crear un programa para sumar numeros aleatoriamente
//Variable


int suma = 0;
int randomNumber = 0;
//instanciamos rnd
Random rnd = new Random();
//Ciclo DoWhile: Ejecutate mientras esto no ocurra
do
{
    randomNumber = rnd.Next(1, 5);
    Console.WriteLine($"Numero Aleatorio generado: {randomNumber}");
    suma += randomNumber;
} while (suma <= 100);
Console.WriteLine($"La suma de los numeros aleatorios es: {suma}");
