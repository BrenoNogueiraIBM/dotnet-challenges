using System;

namespace Desafio23
{

    class RLJ {
        public int R { get; set; }
        public int L { get; set; }
        public int J { get; set; }
        public char ToFind { get; set; }

        public RLJ (string value)
        {
            SetRLJ(value);
        }

        private void SetRLJ(string value)
        {
            if(value.Contains("R"))
            {
                L = int.Parse(value[2].ToString());
                J = int.Parse(value[4].ToString());
                ToFind = 'R';
            }else if (value.Contains("L")){
                R = int.Parse(value[0].ToString());
                J = int.Parse(value[4].ToString());
                ToFind = 'L';
            }else{
                L = int.Parse(value[2].ToString());
                R = int.Parse(value[0].ToString());
                ToFind = 'J';
            }
        }

        public int FindRLJ()
        {
            switch(ToFind)
            {
                case 'R':
                    return J - L;
                case 'L':
                    return J - R;
                case 'J':
                    return R + L;
                default:
                    return 0;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<string> values = new List<string>();
            while (true)
            {
                Console.Write("Formula sagrada: ");
                string value = Console.ReadLine();
                if (value == "0")
                    break;

                values.Add(value);
            }

            foreach(var item in values)
            {
                Console.WriteLine(new RLJ(item).FindRLJ());
            }
        }
    }
}
