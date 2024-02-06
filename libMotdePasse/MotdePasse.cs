namespace libMotdePasse
{
    public class MotdePasse
    {
        private string login;
        private string mdp;
        public MotdePasse(string login, string mdp)
        {
            this.login = login;
            this.mdp = mdp;

        }
        public bool Verifier(string verif)
        {

            bool flag = false;
            if (mdp == this.mdp)
            { flag = true; }
            return flag;
        }

        public bool Longueur()
        {
            bool flag = false;
            if (mdp.Length > 12)
            { flag = true; }
            return flag;
        }

        public bool EstNumeric()
        {
            bool flag = false;
            int lng = mdp.Length;
            for (int i = 0; i < lng; i++)
            {
                
                if (char.IsNumber(mdp,i))
                { 
                    flag = true; 
                }
                
            }
            return flag;
        }

        public bool EstMajuscule()
        {
            bool flag = false;
            int lng = mdp.Length;
            for (int i = 0; i < lng; i++)
            {
                if (char.IsUpper(mdp,i)) 
                { 
                    flag = true;
                }
            
            }
            return flag;
        }

        public bool EstSpecial()
        {
            bool flag = false;
            int lng = mdp.Length;
            for (int i = 0; i < lng; i++)
            {
                if (char.IsLetterOrDigit(mdp, i))
                {
                    flag = true;
                }

            }
            return flag;
    }   }   
}