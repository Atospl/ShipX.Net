namespace ShipX.Net.Enum
{
    /// <summary>
    /// Lista sposobów nadania
    /// </summary>
    public enum SendingMethodEnum
    {
        /// <summary>
        /// Nadanie w Paczkomacie
        /// </summary>
        parcel_locker,
        /// <summary>
        /// Nadam przesyłkę w Punkcie Obsługi Klienta
        /// </summary>
        pok,
        /// <summary>
        /// Nadam przesyłkę w Punkcie Obsługi Klienta
        /// </summary>
        courier_pok,
        /// <summary>
        /// Nadanie w Oddziale
        /// </summary>
        branch,
        /// <summary>
        /// Odbiór przez Kuriera
        /// </summary>
        dispatch_order,
        /// <summary>
        /// "Nadam przesyłkę w Punkcie Obsługi Przesyłek"
        /// </summary>
        pop
    }
}
