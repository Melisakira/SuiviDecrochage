public class Parent : Personne
{
    private string _lienFamilial;
    private string _niveauImplication;
    private bool _consentementPartage;
    private string _coordonneesUrgence;

    public Parent(string identifiant, string nom, string prenom,
                  string email, string telephone,
                  string lienFamilial, string niveauImplication,
                  bool consentementPartage, string coordonneesUrgence)
        : base(identifiant, nom, prenom, email, telephone)
    {
        _lienFamilial = lienFamilial;
        _niveauImplication = niveauImplication;
        _consentementPartage = consentementPartage;
        _coordonneesUrgence = coordonneesUrgence;
    }

    public string LienFamilial => _lienFamilial;
    public string NiveauImplication => _niveauImplication;
    public bool ConsentementPartage => _consentementPartage;
    public string CoordonneesUrgence => _coordonneesUrgence;

    public void SignalerEvenement()
    {
        throw new NotImplementedException();
    }

    public void ValiderAction()
    {
        throw new NotImplementedException();
    }
}
