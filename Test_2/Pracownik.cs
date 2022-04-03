using System;

namespace Test_2
{
    class Pracownik
    {
        private string nazw;
        public string Nazwisko { get => nazw; set => nazw.Trim(); }

        private DateTime dataZatr;
        private static DateTime data = DateTime.Now;
        public DateTime DataZatrudnienia
        {
            get => dataZatr;
            set => dataZatr = (value < data) ? throw new ArgumentException() : dataZatr = value;
        }

        private decimal wyn;
        public decimal Wynagrodzenie { 
            get => wyn; 
            set => wyn = (value > 0) ? wyn = 0 : wyn = value; 
        }

        public override string ToString()
        {
            return $"{Nazwisko}, {DataZatrudnienia}, {Wynagrodzenie}";
        }

        public Pracownik(string nazwisko, DateTime dataZatrudnienia, decimal wynagrodzenie)
        {
            this.Nazwisko = nazwisko;
            this.DataZatrudnienia = dataZatrudnienia;
            this.Wynagrodzenie = wynagrodzenie;
        }
        public Pracownik()
        {

        }

    }
}
