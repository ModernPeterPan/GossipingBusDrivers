namespace Gossiping_Bus_Drivers;

public class BusDriverService
{
    public int CountChismes(int[] arrayUn, int[] arrayDeux, int[]? arrayTrois = null)
    {
        int nbChismesUn = 1;
        int nbChismesDeux = 1;
        int nbChismesTrois = 1;

        int countUn = 0;
        int countDeux = 0;
        int countTrois = 0;

        for (int i = 1; i <= 480; i++)
        {

            int totalChismes;

            if (arrayUn[countUn] == arrayDeux[countDeux])
            {
                totalChismes = nbChismesUn + nbChismesDeux;
                nbChismesUn = totalChismes;
                nbChismesDeux = totalChismes;

                if (nbChismesUn >= 3 && nbChismesDeux >= 3 && nbChismesTrois >= 3)
                {
                    return i;
                }
            }
            if (arrayTrois != null && arrayDeux[countDeux] == arrayTrois[countTrois])
            {
                totalChismes = nbChismesDeux + nbChismesTrois;
                nbChismesDeux = totalChismes;
                nbChismesTrois = totalChismes;

                if (nbChismesUn >= 3 && nbChismesDeux >= 3 && nbChismesTrois >= 3)
                {
                    return i;
                }
            }
            if (arrayTrois != null && arrayTrois[countTrois] == arrayUn[countUn])
            {
                totalChismes = nbChismesUn + nbChismesTrois;
                nbChismesUn = totalChismes;
                nbChismesTrois = totalChismes;

                if (nbChismesUn >= 3 && nbChismesDeux >= 3 && nbChismesTrois >= 3)
                {
                    return i;
                }
            }

            // On augmente le counter de chaque array continuer la comparaison, mais basé sur le .length de chacun.
            if (arrayUn.Length - 1 > countUn)
            {
                countUn++;
            }
            else
            {
                countUn = 0;
            }

            if (arrayDeux.Length - 1 > countDeux)
            {
                countDeux++;
            }
            else
            {
                countDeux = 0;
            }

            if (arrayTrois != null && arrayTrois.Length - 1 > countTrois)
            {
                countTrois++;
            }
            else
            {
                countTrois = 0;
            }

        }

        // -1 est suposément une convention pour "J'ai rien trouvé"
        return -1;

    }
}