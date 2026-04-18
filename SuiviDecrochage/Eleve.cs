public class Eleve : Personne
{
    private DateTime _dateNaissance;
    private string _filiere;
    private float _tauxAbsencesNJ;
    private int _scoreMotivationnelPercu;
    private int _indiceSocialRisque;

    public Eleve(string identifiant, string nom, string prenom,
                 string email, string telephone,
                 DateTime dateNaissance, string filiere,
                 float tauxAbsencesNJ, int scoreMotivationnelPercu,
                 int indiceSocialRisque)
        : base(identifiant, nom, prenom, email, telephone)
    {
        _dateNaissance = dateNaissance;
        _filiere = filiere;
        _tauxAbsencesNJ = tauxAbsencesNJ;
        _scoreMotivationnelPercu = scoreMotivationnelPercu;
        _indiceSocialRisque = indiceSocialRisque;
    }

    public DateTime DateNaissance => _dateNaissance;
    public string Filiere => _filiere;
    public float TauxAbsencesNJ => _tauxAbsencesNJ;
    public int ScoreMotivationnelPercu => _scoreMotivationnelPercu;
    public int IndiceSocialRisque => _indiceSocialRisque;

    public void EvaluerRisque()
    {
        throw new NotImplementedException();
    }

    public void ConsulterDossier()
    {
        throw new NotImplementedException();
    }
}
