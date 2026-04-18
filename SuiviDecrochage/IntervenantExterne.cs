public class IntervenantExterne : Intervenant
{
    private string _typeStructure;
    private string _zoneGeographique;
    private string _protocolCollaboration;

    public IntervenantExterne(string identifiant, string nom, string prenom,
                               string email, string telephone,
                               string roleInstitutionnel, DateTime dateEntree,
                               string niveauAcces, string organisation,
                               string typeMandat, string specialite,
                               DateTime dateDebutSuivi, string typeStructure,
                               string zoneGeographique, string protocolCollaboration)
        : base(identifiant, nom, prenom, email, telephone,
               roleInstitutionnel, dateEntree, niveauAcces,
               organisation, typeMandat, specialite, dateDebutSuivi)
    {
        _typeStructure = typeStructure;
        _zoneGeographique = zoneGeographique;
        _protocolCollaboration = protocolCollaboration;
    }

    public string TypeStructure => _typeStructure;
    public string ZoneGeographique => _zoneGeographique;
    public string ProtocolCollaboration => _protocolCollaboration;

    public override void Intervenir()
    {
        throw new NotImplementedException();
    }
}