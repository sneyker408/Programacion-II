public class Casa
{
    public int Id { get; set; }
    public string Direccion { get; set; }
    public string Ciudad { get; set; }
    public int numeroHabitaciones { get; set; }
    public string dameDatosCasa()
    {
        return $"Direcion es {Direccion} en la ciudad de {Ciudad} con numero de habitaciones {numeroHabitaciones}";
    }
}