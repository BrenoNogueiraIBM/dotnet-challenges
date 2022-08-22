class Result
{

    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        char[] alfabeto = new char[26];
        char[] ALFA = new char[26];
        
        alfabeto[0] = 'a';
        alfabeto[1] = 'b';
        alfabeto[2] = 'c';
        alfabeto[3] = 'd';
        alfabeto[4] = 'e';
        alfabeto[5] = 'f';
        alfabeto[6] = 'g';
        alfabeto[7] = 'h';
        alfabeto[8] = 'i';
        alfabeto[9] = 'j';
        alfabeto[10] = 'k';
        alfabeto[11] = 'l';
        alfabeto[12] = 'm';
        alfabeto[13] = 'n';
        alfabeto[14] = 'o';
        alfabeto[15] = 'p';
        alfabeto[16] = 'q';
        alfabeto[17] = 'r';
        alfabeto[18] = 's';
        alfabeto[19] = 't';
        alfabeto[20] = 'u';
        alfabeto[21] = 'v';
        alfabeto[22] = 'w';
        alfabeto[23] = 'x';
        alfabeto[24] = 'y';
        alfabeto[25] = 'z';
        
        ALFA[0] = 'A';
        ALFA[1] = 'B';
        ALFA[2] = 'C';
        ALFA[3] = 'D';
        ALFA[4] = 'E';
        ALFA[5] = 'F';
        ALFA[6] = 'G';
        ALFA[7] = 'H';
        ALFA[8] = 'I';
        ALFA[9] = 'J';
        ALFA[10] = 'K';
        ALFA[11] = 'L';
        ALFA[12] = 'M';
        ALFA[13] = 'N';
        ALFA[14] = 'O';
        ALFA[15] = 'P';
        ALFA[16] = 'Q';
        ALFA[17] = 'R';
        ALFA[18] = 'S';
        ALFA[19] = 'T';
        ALFA[20] = 'U';
        ALFA[21] = 'V';
        ALFA[22] = 'W';
        ALFA[23] = 'X';
        ALFA[24] = 'Y';
        ALFA[25] = 'Z';
        
        StringBuilder st = new StringBuilder(s);
        
        for(int i=0; i<st.Length; i++){
            for(int j=0; j<alfabeto.Length; j++){
                int z = j+k;
                if(alfabeto[j] == st[i]){
                    st[i] = alfabeto[z%26];
                    break;
                }else if(ALFA[j] == st[i]){
                    st[i] = ALFA[z%26];
                    break;
                }
            }
        }
        return st.ToString();
    }
}