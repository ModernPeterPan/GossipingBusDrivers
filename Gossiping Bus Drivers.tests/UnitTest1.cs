namespace Gossiping_Bus_Drivers.tests;

public class UnitTest1
{
    [Fact]
    public void TrouverNbStops()
    {
        // Basé sur Exemple 1 du Kata
        int[] chauffeurUn = { 3, 1, 2, 3 };
        int[] chauffeurDeux = { 3, 2, 3, 1 };
        int[] chauffeurTrois = { 4, 2, 3, 4, 5 };

        var service = new BusDriverService();

        var result = service.CountChismes(chauffeurUn, chauffeurDeux, chauffeurTrois);

        Assert.Equal(5, result);
    }

    [Fact]
    public void jamaisTrouverNbRumeurs()
    {
        // Basé sur Exemple 2 du Kata
        int[] chauffeurUn = { 2, 1, 2 };
        int[] chauffeurDeux = { 5, 2, 8 };

        var service = new BusDriverService();

        var result = service.CountChismes(chauffeurUn, chauffeurDeux);

        Assert.Equal(-1, result);
    }
}
