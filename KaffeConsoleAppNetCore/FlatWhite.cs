using System;
using System.Collections.Generic;
using System.Text;
using kaffe;

namespace KaffeConsoleAppNetCore
{
    class FlatWhite : Kaffe, Imælk
    {
        public FlatWhite(int rabat) 
            : base(rabat)
        {
            
        }

        public int MlMælk()
        {
            return 160;
        }

        public override int Pris()
        {
            return 45;
        }

        public override string Styrke()
        {
            return "mild";
        }
    }
}
