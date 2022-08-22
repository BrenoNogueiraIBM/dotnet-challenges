using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio9
{
    class AnimalGuesser
    {
        public string Hint1 { get; set; }
        public string Hint2 { get; set; }
        public string Hint3 { get; set; }

        public AnimalGuesser(string hint1, string hint2, string hint3)
        {
            Hint1 = hint1.ToLower();
            Hint2 = hint2.ToLower();
            Hint3 = hint3.ToLower();
        }

        public string Guess()
        {
            return ProcessCode(HintCode());
        }

        private string HintCode()
        {
            string code = "";
            code += Hint1.Substring(0, 3);
            code += Hint2.Substring(0, 3);
            code += Hint3.Substring(0, 3);
            return code;
        }

        private string ProcessCode(string code)
        {
            switch (code)
            {
                case "veravecar":
                    return "aguia";

                case "veraveoni":
                    return "pomba";

                case "vermamoni":
                    return "homem";

                case "vermamher":
                    return "vaca";

                case "invinshem":
                    return "pulga";

                case "invinsher":
                    return "lagarta";

                case "invanehem":
                    return "sanguessuga";

                case "invaneoni":
                    return "minhoca";

                default:
                    return "";
            }
        }

    }
}
