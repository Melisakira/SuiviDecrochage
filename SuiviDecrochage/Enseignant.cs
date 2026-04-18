public class Enseignant : ActeurProfessionnel
{
    private string _matiere;
    private bool _estTitulaire;
    private string _niveauEnseignement;
    private int _anneesExperience;

    public Enseignant(string identifiant, string nom, string prenom,
                      string email, string telephone,
                      string roleInstitutionnel, DateTime dateEntree,
                      string niveauAcces, string matiere, bool estTitulaire,
                      string niveauEnseignement, int anneesExperience)
        : base(identifiant, nom, prenom, email, telephone,
               roleInstitutionnel, dateEntree, niveauAcces)
    {
        _matiere = matiere;
        _estTitulaire = estTitulaire;
        _niveauEnseignement = niveauEnseignement;
        _anneesExperience = anneesExperience;
    }

    public string Matiere => _matiere;
    public bool EstTitulaire => _estTitulaire;
    public string NiveauEnseignement => _niveauEnseignement;
    public int AnneesExperience => _anneesExperience;

    public void SignalerEleve()
    {
        throw new NotImplementedException();
    }
}