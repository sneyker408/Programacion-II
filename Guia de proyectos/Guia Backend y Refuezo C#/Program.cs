Codigo de la guia 
using System.Numerics;
using System.Security.Cryptography;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
#region declaraicon
/*
Venta ventas = new Venta(12);
VentaconImpuestos ventas1 = new(154, 15.65m);
var mensage2 = ventas1.impuesto(154);

var message = ventas1.GetInfo();
Console.WriteLine(message + "  impuestos total son " + mensage2);
Console.WriteLine(ventas1.getInfoCliente("Ever Sorto"));
Pago ejemplo = new();
var valor = ejemplo.total(400m, 0.13m);
Console.WriteLine(valor);
ejemplo.mostrar(valor);

var numbers = new MyList<int>(5);
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);
Console.WriteLine(numbers.GetContent());
var nombres = new MyList<string>(5);
nombres.Add("b");
nombres.Add("c");
nombres.Add("d");
nombres.Add("e");
nombres.Add("f");
nombres.Add("h");
Console.WriteLine(nombres.GetContent());

// utilizmaos una clase 
var impuestosG = new MyList<Pago>(3);
impuestosG.Add(new Pago
{
    iva = 13
});
impuestosG.Add(new Pago
{
    iva = 10
});

impuestosG.Add(new Pago
{
    iva = 15
});
impuestosG.Add(new Pago
{
    iva = 23
});
Console.WriteLine(impuestosG.GetContent());
*/
/*
var Ever = new Persona()
{
    Name = "Ever",
    Age = 20,
};

string json = JsonSerializer.Serialize(Ever);
var myJson = @"{""Name"":""Ever"",""Age"":20}";
Console.WriteLine(json);

Persona? yo = JsonSerializer.Deserialize<Persona>(myJson);
Console.WriteLine(yo?.Name);
Console.WriteLine(yo?.Age);
*/
#endregion
#region Lambda
/*
Func<int, int, int> sub = (x, y) => x - y;
Func<int, int> some2 = a => a * 2;
Func<int, int> some = a => {
    a= a + 1;
    return a * 2; };

Console.WriteLine(sub(1, 2));
Console.WriteLine(some(5));
Console.WriteLine(some2(45));

//Creando funciones que reciven como parametro otras fucniones 

Some((a,b) => a + b , 5);

void Some( Func<int, int , int > fn, int number ) {

  var resultado = fn(number, number);
    Console.WriteLine(resultado);
}
*/
#endregion

#region LinQ
/*var nombres = new List<string>()
{
    "José",
    "Carlos",
    "Juan",
    "Luis",
    "Ricardo",
    "Mario",
    "Manuel",
    "Francisco",
    "David",
    "Miguel",
    "María",
    "Ana",
    "Carmen",
    "Rosa",
    "Silvia",
    "Claudia",
    "Karla",
    "Gabriela",
    "Paola",
    "Jessica",
    "Ever"
};
var names2 = from alias in nombres
             where  alias.Length > 6
             orderby alias descending 
             select alias;
var nombre3 = nombres.Where(n => n.Length > 7).OrderByDescending(n => n).Select(n => n);
foreach (var i in nombre3) { 
    Console.WriteLine(i);
}
*/
#endregion
/*
#region Clases
class Venta
{
    public decimal Total { get; set; }

    public Venta(decimal total)
    {
        this.Total = total;
    }

    public string GetInfo()
    {
        return "El total es " + Total;
    }
    private string _SoloEnLaClase()
    {
        return "El total es " + Total;
    }

    protected String SoloHeredados()
    {
        return "El total es " + Total;
    }

    public virtual string getInfoCliente()
    {
        return "El cliente se llama Carlor";
    }
}
class VentaconImpuestos : Venta
{

    decimal porcentaje;
    public VentaconImpuestos(decimal total, decimal porcentaje) : base(total)
    {
        this.porcentaje = porcentaje;
    }

    public decimal impuesto(decimal impuesto)
    {
        var total = this.Total * impuesto;
        return total;
    }

    public override string getInfoCliente()
    {
        return "El cliete se llama Juan " + porcentaje;
    }

    public string getInfoCliente(string cliente)
    {
        return cliente;
    }
}
public class MyList<T>
{
    private List<T> _list;
    private int _limint = 5;

    public MyList(int limit)
    {
        _limint = limit;
        _list = new List<T>();
    }
    public void Add(T element)
    {
        if (_list.Count < _limint)
        {
            _list.Add(element);
        }
    }

    public string GetContent()
    {
        string content = "";
        foreach (var i in _list)
        {
            content += i + ", ";
        }
        return content;
    }
}
public class Persona { 
    public string Name { get; set; }
    public int Age{ get; set; }
}
#endregion
#region Interfaz
public class Pago :  Iinpuesto, ICalcular, IMostrar
{
    public decimal iva { get; set; }
    public decimal total(decimal cantidad, decimal impuesto)
    {

        var resultado = cantidad += cantidad * impuesto;
        return resultado;
    }
    public void mostrar(decimal resultado)
    {
        Console.WriteLine("El resultado es : " + resultado);
    }

    public override string ToString()
    {
        return "el monto aplicado al saliro es " + iva;
    }
}

public interface Iinpuesto
{
    public decimal iva { get; set; }
}

public interface ICalcular
{

    public decimal total(decimal cantidad, decimal impuesto)
    {
        var resultado = 0;
        return resultado;
    }
}

public interface IMostrar
{

    public void mostar()
    {
    }
}
#endregion
*/