public class IntervenantInterne : Intervenant
{
    private string _serviceRattachement;
    private int _nbDossiersActifs;
    private string _disponibilite;

    public IntervenantInterne(string identifiant, string nom, string prenom,
                               string email, string telephone,
                               string roleInstitutionnel, DateTime dateEntree,
                               string niveauAcces, string organisation,
                               string typeMandat, string specialite,
                               DateTime dateDebutSuivi, string serviceRattachement,
                               int nbDossiersActifs, string disponibilite)
        : base(identifiant, nom, prenom, email, telephone,
               roleInstitutionnel, dateEntree, niveauAcces,
               organisation, typeMandat, specialite, dateDebutSuivi)
    {
        _serviceRattachement = serviceRattachement;
        _nbDossiersActifs = nbDossiersActifs;
        _disponibilite = disponibilite;
    }

    public string ServiceRattachement => _serviceRattachement;
    public int NbDossiersActifs => _nbDossiersActifs;
    public string Disponibilite => _disponibilite;

    public override void Intervenir()
    {
        throw new NotImplementedException();
    }
}
