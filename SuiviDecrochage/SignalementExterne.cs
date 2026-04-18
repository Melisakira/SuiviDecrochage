public class SignalementExterne : Intervention
{
    private string _organismeDestinataire;
    private bool _estUrgent;
    private DateTime _dateReponse;

    public SignalementExterne(DateTime date, int dureeMinutes,
                               string description, string statut,
                               string organismeDestinataire, bool estUrgent,
                               DateTime dateReponse)
        : base(date, dureeMinutes, description, statut)
    {
        _organismeDestinataire = organismeDestinataire;
        _estUrgent = estUrgent;
        _dateReponse = dateReponse;
    }

    public string OrganismeDestinataire => _organismeDestinataire;
    public bool EstUrgent => _estUrgent;
    public DateTime DateReponse => _dateReponse;

    public void Cloturer()
    {
        throw new NotImplementedException();
    }
}
