public abstract class Intervenant : ActeurProfessionnel
{
    private string _organisation;
    private string _typeMandat;
    private string _specialite;
    private DateTime _dateDebutSuivi;

    public Intervenant(string identifiant, string nom, string prenom,
                       string email, string telephone,
                       string roleInstitutionnel, DateTime dateEntree,
                       string niveauAcces, string organisation,
                       string typeMandat, string specialite,
                       DateTime dateDebutSuivi)
        : base(identifiant, nom, prenom, email, telephone,
               roleInstitutionnel, dateEntree, niveauAcces)
    {
        _organisation = organisation;
        _typeMandat = typeMandat;
        _specialite = specialite;
        _dateDebutSuivi = dateDebutSuivi;
    }

    public string Organisation => _organisation;
    public string TypeMandat => _typeMandat;
    public string Specialite => _specialite;
    public DateTime DateDebutSuivi => _dateDebutSuivi;

    public virtual void Intervenir()
    {
        throw new NotImplementedException();
    }
}
