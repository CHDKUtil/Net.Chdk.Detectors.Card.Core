using Net.Chdk.Model.Card;
using System;

namespace Net.Chdk.Detectors.Card
{
    [Obsolete]
    public interface ICardDetector
    {
        CardInfo[] GetCards();
        CardInfo GetCard(string driveLetter);
    }
}
