namespace Animals
{
    // Mese: interface-ben összefoglaljuk azokat a tulajdonságokat,
    // amikkel egy ilyen osztálynak rendelkeznie kell.

    // interface: csak metódus fejléceket tartalmaz
    internal interface ITrickPerformer
    {
        //int time; -> Property-vel + getterel lehetne

        void PerformTrick();
    }
}
