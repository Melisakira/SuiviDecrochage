public class AtelierGroupe : Intervention
{
    private int _nbParticipants;
    private string _theme;
    private string _lieuAtelier;
    private Intervenant _intervenantResponsable;

    public AtelierGroupe(DateTime date, int dureeMinutes,
                         string description, string statut,
                         int nbParticipants, string theme,
                         string lieuAtelier, Intervenant intervenantResponsable)
        : base(date, dureeMinutes, description, statut)
    {
        _nbParticipants = nbParticipants;
        _theme = theme;
        _lieuAtelier = lieuAtelier;
        _intervenantResponsable = intervenantResponsable;
    }

    public int NbParticipants => _nbParticipants;
    public string Theme => _theme;
    public string LieuAtelier => _lieuAtelier;
    public Intervenant IntervenantResponsable => _intervenantResponsable;

    public override void CloturerSeance()
    {
        throw new NotImplementedException();
    }
}