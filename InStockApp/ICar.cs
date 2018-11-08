namespace InStockApp
{
    public interface ICar
    {
        int Id { get; set; }
        string Kenteken { get; set; }
        int EstablishedYear { get; set; }
        int Price { get; set; }
        int KM { get; set; }
        string CarName { get; set; }
    }
}