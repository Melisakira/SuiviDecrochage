public abstract class Personne
{
    private string _identifiant;
    private string _nom;
    private string _prenom;
    private string _email;
    private string _telephone;

    public Personne(string identifiant, string nom, string prenom,
                    string email, string telephone)
    {
        _identifiant = identifiant;
        _nom = nom;
        _prenom = prenom;
        _email = email;
        _telephone = telephone;
    }

    public string Identifiant => _identifiant;
    public string Nom => _nom;
    public string Prenom => _prenom;
    public string Email => _email;
    public string Telephone => _telephone;

    public void Contacter()
    {
        throw new NotImplementedException();
    }
}