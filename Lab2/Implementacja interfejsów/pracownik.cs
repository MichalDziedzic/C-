using System;
namespace asd
{
public class Pracownik
{
    private string Naz;
    public string Nazwisko{

        get => Naz;
        set => Naz = value.Trim(' ');
    }
    
    private DateTime DataZ;

    public DateTime DataZatrudnienia{

        get => DataZ;
        set
        {
            if(DateTime.Today <= value)
            {
                throw new ArgumentException("error");
            }else
            {
                DataZ=value;
            }
        }

    }


    // public DateTime DataZatrudnienia{
    //     get => DataZ;
    //     set {
    //          if(DataZatrudnienia < DateTime.Today)
    //          {
    //             DataZ=value;
    //          }else{
    //              throw new ArgumentException("error");
    //          }

    //     }
    // }


    public int CzasZatrudnienia {
        get => (DateTime.Today - DataZatrudnienia).Days/30;
        
    }
  private decimal _wyn;
    public decimal Wynagrodzenie
    {
        get => _wyn;
        set => _wyn = (value < 0)? 0: value;
           
    }
    public override string ToString() => $"({Nazwisko}, {DataZatrudnienia:d MMM yyyy} ({CzasZatrudnienia}), {Wynagrodzenie} PLN)";

    public Pracownik()
    {
        Nazwisko = "anonim";
        DataZ =DateTime.Today;
        Wynagrodzenie =0;
    }



}
}