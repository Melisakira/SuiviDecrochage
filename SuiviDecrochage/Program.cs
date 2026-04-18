class Program
{
    static void Main(string[] args)
    {
        // Instanciation d'un élève
        Eleve eleve = new Eleve(
            "EL001", "Pitta", "Lucas", "lucas.pitta@ecole.be", "0470123456",
            new DateTime(2008, 3, 15), "Professionnelle",
            12.5f, 3, 2
        );

        // Instanciation d'un intervenant interne
        IntervenantInterne intervenant = new IntervenantInterne(
            "II001", "Dupont", "Marie", "marie.dupont@ecole.be", "0471234567",
            "Psychologue PMS", new DateTime(2020, 9, 1), "partage",
            "Centre PMS Namur", "Guidance", "Psychologie scolaire",
            new DateTime(2024, 10, 1), "PMS", 8, "Lundi-Vendredi"
        );

        // Instanciation d'un établissement
        Etablissement ecole = new Etablissement(
            "Athénée Royal de Walcourt", "direction@arwalcourt.be",
            "Lecomte Pierre", "officiel"
        );

        // Instanciation d'un dossier de suivi
        DossierSuivi dossier = new DossierSuivi(
            DateTime.Now, DateTime.Now,
            "ouvert", "Absentéisme répété",
            "actif", eleve
        );

        // Instanciation d'une alerte
        Alerte alerte = new Alerte(
            DateTime.Now, "Taux d'absences dépassé 20 demi-journées",
            "élevé", false
        );

        // Instanciation d'un plan d'action
        PlanAction plan = new PlanAction(
            "Rencontrer les parents dans les 15 jours",
            new DateTime(2025, 11, 30),
            "en cours", "partage", "Dupont Marie"
        );

        // Instanciation d'un entretien individuel
        EntretienIndividuel entretien = new EntretienIndividuel(
            DateTime.Now, 45,
            "Premier entretien de suivi", "planifié",
            "Bureau PMS", true, "", intervenant
        );

        Console.WriteLine("Squelette opérationnel.");
        Console.WriteLine($"Élève : {eleve.Prenom} {eleve.Nom}");
        Console.WriteLine($"Intervenant : {intervenant.Prenom} {intervenant.Nom}");
        Console.WriteLine($"Établissement : {ecole.Nom}");
        Console.WriteLine($"Dossier ouvert le : {dossier.DateOuverture.ToShortDateString()}");
    }
}

