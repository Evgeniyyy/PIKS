namespace Adapter
{
    class AdapterGame: IGame
    {
        Monet mot;

        public AdapterGame(Monet mt)
        {
            mot = mt;
        }

        public int Brosok()
        {
            return mot.BrosokM();
        }
    }
}