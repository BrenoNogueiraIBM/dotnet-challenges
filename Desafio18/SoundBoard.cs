namespace Desafio18
{
    internal class SoundBoard
    {
        public SoundBoard()
        {
        }

        public string PlayMusic(int button1, int button2)
        {
            return GetMusic(button1 + button2);
        }

        private string GetMusic(int index)
        {
            string[] songs = new string[] {
                "PROXYCITY", "P.Y.N.G.", " DNSUEY!", "SERVERS", "HOST!", "CRIPTONIZE", "OFFLINE DAY",
                "SALT", "ANSWER!", "RAR?", "WIFI ANTENNAS" };

            if (!(index < songs.Length) || index < 0)
                return "Sem musicas com esse código";

            return songs[index];
        }
    }
}