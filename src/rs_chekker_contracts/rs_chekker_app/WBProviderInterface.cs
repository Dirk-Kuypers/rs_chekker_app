using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_chekker_app
{
    public interface WBProviderInterface
    {
        void WortPrüfen(string wort, Action<string> beiFehler);

        void WortEinfügen(string Wort);

        void SetzeNutzerWörterbuch(string dateiname);
    }
}
