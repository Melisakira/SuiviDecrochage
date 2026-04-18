public class DossierSuivi
{
    private DateTime _dateOuverture;
    private DateTime _dateDerniereMaj;
    private string _statut;
    private string _motifOuverture;
    private string _typeDecrochage;
    private Eleve _eleve;
    private List<Intervention> _interventions;
    private List<Alerte> _alertes;
    private List<Intervenant> _intervenants;
    private List<PlanAction> _plansAction;

    public DossierSuivi(DateTime dateOuverture, DateTime dateDerniereMaj,
                        string statut, string motifOuverture,
                        string typeDecrochage, Eleve eleve)
    {
        _dateOuverture = dateOuverture;
        _dateDerniereMaj = dateDerniereMaj;
        _statut = statut;
        _motifOuverture = motifOuverture;
        _typeDecrochage = typeDecrochage;
        _eleve = eleve;
        _interventions = new List<Intervention>();
        _alertes = new List<Alerte>();
        _intervenants = new List<Intervenant>();
        _plansAction = new List<PlanAction>();
    }

    public DateTime DateOuverture => _dateOuverture;
    public DateTime DateDerniereMaj => _dateDerniereMaj;
    public string Statut => _statut;
    public string MotifOuverture => _motifOuverture;
    public string TypeDecrochage => _typeDecrochage;
    public Eleve Eleve => _eleve;

    public void OuvrirDossier()
    {
        throw new NotImplementedException();
    }

    public void FermerDossier()
    {
        throw new NotImplementedException();
    }

    public void AjouterIntervention()
    {
        throw new NotImplementedException();
    }

    public void AjouterAlerte()
    {
        throw new NotImplementedException();
    }
}
