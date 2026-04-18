public class Etablissement
{
    private string _nom;
    private string _email;
    private string _directeur;
    private string _typeReseau;
    private List<DossierSuivi> _dossiers;

    public Etablissement(string nom, string email,
                         string directeur, string typeReseau)
    {
        _nom = nom;
        _email = email;
        _directeur = directeur;
        _typeReseau = typeReseau;
        _dossiers = new List<DossierSuivi>();
    }

    public string Nom => _nom;
    public string Email => _email;
    public string Directeur => _directeur;
    public string TypeReseau => _typeReseau;

    public void GenererTableauDeBord()
    {
        throw new NotImplementedException();
    }
}