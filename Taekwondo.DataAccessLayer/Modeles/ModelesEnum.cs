namespace Taekwondo.DataAccessLayer.Modeles
{
    public enum GradeAdulte
    {
        /// <summary>
        /// Indéfini
        /// </summary>
        Indefini = 0,
        /// <summary>
        /// Ceinture Blanche
        /// </summary>
        Keup10 = 1,
        /// <summary>
        /// Ceinture Jaune
        /// </summary>
        Keup9 = 2,
        /// <summary>
        /// Ceinture Jaune - 1e barrette bleue
        /// </summary>
        Keup8 = 3,
        /// <summary>
        /// Ceinture Jaune - 2e barrette bleue
        /// </summary>
        Keup7 = 4,
        /// <summary>
        /// Ceinture Bleue
        /// </summary>
        Keup6 = 5,
        /// <summary>
        /// Ceinture Bleue - 1e barrette rouge
        /// </summary>
        Keup5 = 6,
        /// <summary>
        /// Ceinture Bleue - 2e barrette rouge
        /// </summary>
        Keup4 = 7,
        /// <summary>
        /// Ceinture Rouge
        /// </summary>
        Keup3 = 8,
        /// <summary>
        /// Ceinture Rouge - 1e barrette noire
        /// </summary>
        Keup2 = 9,
        /// <summary>
        /// Ceinture Rouge - 2e barrette noire
        /// </summary>
        Keup1 = 10,
        /// <summary>
        /// Ceinture Noire
        /// </summary>
        Dan1etPlus = 11
    }

    public enum GradeEnfant
    {
        /// <summary>
        /// Indéfini
        /// </summary>
        Indefini = 0,
        /// <summary>
        /// Ceinture Blanche
        /// </summary>
        Keup15 = 1,
        /// <summary>
        /// Ceinture Jaune
        /// </summary>
        Keup14 = 2,
        /// <summary>
        /// Ceinture Jaune - barrette orange
        /// </summary>
        Keup13 = 3,
        /// <summary>
        /// Ceinture Orange
        /// </summary>
        Keup12 = 4,
        /// <summary>
        /// Ceinture Orange - barrette verte
        /// </summary>
        Keup11 = 5,
        /// <summary>
        /// Ceinture Verte
        /// </summary>
        Keup10 = 6,
        /// <summary>
        /// Ceinture Verte - barrette viollette
        /// </summary>
        Keup9 = 7,
        /// <summary>
        /// Ceinture Violette
        /// </summary>
        Keup8 = 8,
        /// <summary>
        /// Ceinture Violette - barrette bleue
        /// </summary>
        Keup7 = 9,
        /// <summary>
        /// Ceinture Bleue
        /// </summary>
        Keup6 = 10,
        /// <summary>
        /// Ceinture Bleue - 1e barrette rouge
        /// </summary>
        Keup5 = 11,
        /// <summary>
        /// Ceinture Bleue - 2e barrette rouge
        /// </summary>
        Keup4 = 12,
        /// <summary>
        /// Ceinture Rouge
        /// </summary>
        Keup3 = 13,
        /// <summary>
        /// Ceinture Rouge - 1e barrette noire
        /// </summary>
        Keup2 = 14,
        /// <summary>
        /// Ceinture Rouge - 2e barrette noire
        /// </summary>
        Keup1 = 15,
        /// <summary>
        /// Ceinture Rouge et Noire
        /// </summary>
        IlPoum = 16,
        /// <summary>
        /// Ceinture Noire
        /// </summary>
        Dan1etPlus = 17,
    }

    public enum TypeTechnique
    {
        Indefini = 0,
        Position = 1,
        Blocage = 2,
        Frappe = 3
    }

    public enum MembreAnatomique
    {
        Indefini = 0,
        Inferieur = 1,
        Superieur = 2
    }

    public enum NiveauDifficulte
    {
        Indefini = 0,
        Facile = 1,
        Intermediaire = 2,
        Expert = 3
    }
}
