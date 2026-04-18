public class TableauDeBord
{
    private DateTime _dateGeneration;
    private int _nbDossiersActifs;
    private int _nbAlertesNonTraitees;
    private float _tauxDecrochageEtablissement;
    private Etablissement _etablissement;

    public TableauDeBord(DateTime dateGeneration, int nbDossiersActifs,
                         int nbAlertesNonTraitees, float tauxDecrochageEtablissement,
                         Etablissement etablissement)
    {
        _dateGeneration = dateGeneration;
        _nbDossiersActifs = nbDossiersActifs;
        _nbAlertesNonTraitees = nbAlertesNonTraitees;
        _tauxDecrochageEtablissement = tauxDecrochageEtablissement;
        _etablissement = etablissement;
    }

    public DateTime DateGeneration => _dateGeneration;
    public int NbDossiersActifs => _nbDossiersActifs;
    public int NbAlertesNonTraitees => _nbAlertesNonTraitees;
    public float TauxDecrochageEtablissement => _tauxDecrochageEtablissement;
    public Etablissement Etablissement => _etablissement;

    public void Afficher()
    {
        throw new NotImplementedException();
    }
}