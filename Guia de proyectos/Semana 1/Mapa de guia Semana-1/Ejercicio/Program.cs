#region ejecicio1
/*
El Corredor hara 3 distancias y luego las repetira en 8 vueltas 
D1 = 30
D2= 50
D3= 40
 */

int distancia_1, distancia_2, distancia_3, vueltas;
float recorrido;

distancia_1 = 30;
distancia_2 = 40;
distancia_3 = 50;
vueltas = 8;


recorrido = vueltas * (distancia_1 + distancia_2 + distancia_3);

Console.WriteLine($" distancia es {recorrido} metros");
#endregion