namespace _06Egenskaber2
{
    class Trekant
    {
        public Trekant(int grundlinje, int højde)
        {
            this.Grundlinje = grundlinje;
            this.Højde = højde;
            this.Areal = this.Grundlinje * this.Højde * 0.5;
        }
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }
        public double Areal { get; private set; }

        /*public double Areal
        {
            get { return this.Grundlinje * this.Højde * 0.5; }
        }*/
    }
}
