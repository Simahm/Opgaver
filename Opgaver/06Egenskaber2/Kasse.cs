namespace _06Egenskaber2
{
    class Kasse
    {

        public Kasse(int højde, int bredde, int dybde)
        {
            this.Højde = højde;
            this.Bredde = bredde;
            this.Dybde = dybde;
        }

        public int Højde { get; private set; }
        public int Bredde { get; private set; }
        public int Dybde { get; private set; }

        private int rumfang;
        public int Rumfang
        {
            get {
                return this.Højde * this.Bredde * this.Dybde;
            }
        }

        private int areal;
        public int Areal
        {
            get {
                return (2 * this.Højde * this.Bredde) + (2 * this.Højde * this.Dybde) + (2 * this.Bredde * this.Dybde);
            }
        }
    }
}
