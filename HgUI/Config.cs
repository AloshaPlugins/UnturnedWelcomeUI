using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alosha
{
    public class myConfig : IRocketPluginConfiguration
    {
        public ushort id;
        public string SunucuLogosu, SunucuIsmi, Alt_baslik;
        public void LoadDefaults()
        {
            id = 39600;
            SunucuLogosu = "URL";
            SunucuIsmi = "Alosha Roleplay";
            Alt_baslik = "Bu sunucuya geldiğinizde bazı şeylerden vazgeçmiş olacaksın.";
        }
    }
}
