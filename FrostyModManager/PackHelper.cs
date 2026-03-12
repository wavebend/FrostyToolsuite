using System.Linq;

namespace FrostyModManager
{
    public static class PackHelper
    {
        public static string CleanPackName(this string packName)
        {
            if (packName.Any(char.IsWhiteSpace))
            {
                packName = new string(packName.Where(c => !char.IsWhiteSpace(c)).ToArray());
            }
            
            if (!char.IsUpper(packName[0]))
            {
                packName = char.ToUpper(packName[0]) + packName.Substring(1);
            }
            
            return packName.Trim();
        }
    }
}
