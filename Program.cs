using System;

public class classes
{
    public class CompteBancaire        //  Exo class1
    {

        private String m_titulaire;
        private int m_solde;
        private String m_devise;

        public CompteBancaire(string leTitulaire, int leSolde, string laDevise)
        {
            this.m_titulaire = leTitulaire;
            this.m_solde = leSolde;
            this.m_devise = laDevise;
        }
        public string titulaire
        {
            get { return m_titulaire; }
        }
        public int solde
        {
            get { return m_solde; }
        }
        public string devise
        {
            get { return m_devise; }
        }
        public void crediter(int montant)
        {
            this.m_solde += montant;
        }
        public void debiter(int montant)
        {
            this.m_solde -= montant;
        }

        public void decrire()
        {
            
            Console.WriteLine(" le nouveau compte bancaire est associé au Titulaire :" + this.titulaire + " avec un solde de " + this.solde + " " + this.devise);
        }
        ~CompteBancaire()
        {
            Console.WriteLine("Objet détruit.");
        }
        static void Main(string[] args)
        {

            CompteBancaire compte1 = new CompteBancaire("Mr Jean", 15, "euros");
            compte1.decrire();
            compte1.crediter(5);
            compte1.decrire();
            compte1.debiter(5);
            compte1.decrire();
            
        }

    }

}

