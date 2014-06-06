using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_chekker_app
{
    public interface TextProviderInterface
    {
        void LadeTextAusDatei(string dateiname, Action<string> onText);

        void SpeichereTextAlsDatei(string dateiname, string text);
    }
}
