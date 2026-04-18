public class PlanAction
{
    private string _objectif;
    private DateTime _echeance;
    private string _statut;
    private string _niveauVisibilite;
    private string _auteur;

    public PlanAction(string objectif, DateTime echeance,
                      string statut, string niveauVisibilite,
                      string auteur)
    {
        _objectif = objectif;
        _echeance = echeance;
        _statut = statut;
        _niveauVisibilite = niveauVisibilite;
        _auteur = auteur;
    }

    public string Objectif => _objectif;
    public DateTime Echeance => _echeance;
    public string Statut => _statut;
    public string NiveauVisibilite => _niveauVisibilite;
    public string Auteur => _auteur;

    public void MettreAJour()
    {
        throw new NotImplementedException();
    }

    public void Valider()
    {
        throw new NotImplementedException();
    }
}
