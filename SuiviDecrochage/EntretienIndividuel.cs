public class EntretienIndividuel : Intervention
{
    private string _lieuEntretien;
    private bool _estConfidentiel;
    private string _compteRendu;
    private Intervenant _intervenantResponsable;

    public EntretienIndividuel(DateTime date, int dureeMinutes,
                                string description, string statut,
                                string lieuEntretien, bool estConfidentiel,
                                string compteRendu, Intervenant intervenantResponsable)
        : base(date, dureeMinutes, description, statut)
    {
        _lieuEntretien = lieuEntretien;
        _estConfidentiel = estConfidentiel;
        _compteRendu = compteRendu;
        _intervenantResponsable = intervenantResponsable;
    }

    public string LieuEntretien => _lieuEntretien;
    public bool EstConfidentiel => _estConfidentiel;
    public string CompteRendu => _compteRendu;
    public Intervenant IntervenantResponsable => _intervenantResponsable;

    public override void CloturerSeance()
    {
        throw new NotImplementedException();
    }
}