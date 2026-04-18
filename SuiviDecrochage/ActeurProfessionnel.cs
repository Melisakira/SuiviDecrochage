public abstract class ActeurProfessionnel : Personne
{
    private string _roleInstitutionnel;
    private DateTime _dateEntree;
    private string _niveauAcces;

    public ActeurProfessionnel(string identifiant, string nom, string prenom,
                                string email, string telephone,
                                string roleInstitutionnel, DateTime dateEntree,
                                string niveauAcces)
        : base(identifiant, nom, prenom, email, telephone)
    {
        _roleInstitutionnel = roleInstitutionnel;
        _dateEntree = dateEntree;
        _niveauAcces = niveauAcces;
    }

    public string RoleInstitutionnel => _roleInstitutionnel;
    public DateTime DateEntree => _dateEntree;
    public string NiveauAcces => _niveauAcces;

    public void ConsulterDossier()
    {
        throw new NotImplementedException();
    }
}
