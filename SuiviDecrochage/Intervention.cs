public abstract class Intervention
{
    private DateTime _date;
    private int _dureeMinutes;
    private string _description;
    private string _statut;

    public Intervention(DateTime date, int dureeMinutes,
                        string description, string statut)
    {
        _date = date;
        _dureeMinutes = dureeMinutes;
        _description = description;
        _statut = statut;
    }

    public DateTime Date => _date;
    public int DureeMinutes => _dureeMinutes;
    public string Description => _description;
    public string Statut => _statut;

    public virtual void CloturerSeance()
    {
        throw new NotImplementedException();
    }
}
