#region Concatenar
var nombre1 = "Erick";
var edad = 29;
var direccion = "San Francisco Lempa, Chalatenango";
Console.WriteLine("Hola Soy " + nombre1 + " mi edad es " + edad + "vivo en " + direccion);
var cadena2 = $"Hola Soy {nombre1}  mi edad es  {edad} vivo en  {direccion}";
Console.WriteLine(cadena2);

var cadena3 = @$"/{direccion}/{direccion}/{direccion}";
Console.WriteLine(cadena3);

#endregion