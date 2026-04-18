public class Alerte
{
    private DateTime _dateAlerte;
    private string _motif;
    private string _niveau;
    private bool _estTraitee;

    public Alerte(DateTime dateAlerte, string motif,
                  string niveau, bool estTraitee)
    {
        _dateAlerte = dateAlerte;
        _motif = motif;
        _niveau = niveau;
        _estTraitee = estTraitee;
    }

    public DateTime DateAlerte => _dateAlerte;
    public string Motif => _motif;
    public string Niveau => _niveau;
    public bool EstTraitee => _estTraitee;

    public void Declencher()
    {
        throw new NotImplementedException();
    }
}
