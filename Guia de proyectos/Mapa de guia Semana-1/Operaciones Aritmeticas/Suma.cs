// suma 
using System.Security.Cryptography;

int coins = 7;
Console.WriteLine($" coins = {7}");
coins = coins + 1;
Console.WriteLine($" coins +1 = {coins}");

// sumar otra variable
int coinsPack = 5;
Console.WriteLine($" coinsPack = {coinsPack}");
coins = coins + coinsPack;
coins += coinsPack;
Console.WriteLine($" coins + coinstPack = {coinsPack}");

// Resta
int puchDanger = 7;
Console.WriteLine($" Daño acumulado = {puchDanger}");
coins = coins - puchDanger;
coins -= puchDanger;
Console.WriteLine($" coins + coinstPack = {coins}");

//Multipliacion 
int liveUp = 10;
Console.WriteLine($" Daño acumulado = {liveUp}");
coins = coins + liveUp;
coins -= puchDanger * 3;
Console.WriteLine($" coins + coinstPack = {coins}");

//dividir
int power = 25;
Console.WriteLine($" recupera vida = {liveUp}");
coins = coins + power * liveUp;
coins -= puchDanger / power;
Console.WriteLine($" defensa activada = {coins}");
Console.WriteLine($" coins - daño = {coins}");
Console.ReadKey();

//bool
bool isLive = false;
Console.WriteLine($" recupera vida = {liveUp}");
coins = coins + 1;
coins -= puchDanger;
Console.WriteLine($" defensa esta vivo= {isLive}");