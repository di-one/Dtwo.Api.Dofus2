using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.Dofus2
{
    public static class Version
    {
        private static string? m_text;
        public static string? Text
        {
            get
            {
                if (m_text == null && m_hasCheckedVersion == false)
                {
                   m_text = FindVersion();
                   m_hasCheckedVersion = true;
                }

                if (m_text == null)
                {
                    LogManager.LogError("Une erreur est survenue lors du check de Version du jeu !", 1);
                    throw new Exception("Une erreur est survenue lors du check de Version du jeu !");
                }

                return m_text;
            }
        }

        private static bool m_hasCheckedVersion = false;

        private static string? FindVersion()
        {
            var dofusPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Ankama", "Dofus");
            var versionFile = System.IO.Path.Combine(dofusPath, "VERSION");

            if (System.IO.File.Exists(versionFile))
            {
                return System.IO.File.ReadAllText(versionFile);
            }
            else
            {
                return null;
            }
        }
    }
}
