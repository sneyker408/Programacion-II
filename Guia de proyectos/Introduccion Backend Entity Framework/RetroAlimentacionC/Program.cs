Venta ventas = new Venta(125);
Venta ventas1 = new Venta(125);

VentaImpuestos venta1 = 
class Venta
{

    public decimal Total { get; }

    public Venta(decimal total)
    {
        this.Total = total;
    }

    private string _SoloEnLaClase()
    {
        return "El total es " + Total;

    }

    public string GetInfo()
    {
        return "El total desde get Clase " + Total;
    }

}

class VentaImpuestos : Venta
{
    public VentaImpuestos(decimal total)
        : base(total)
    {

    }
}