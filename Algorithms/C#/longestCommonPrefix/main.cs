public class Solution {
    public string LongestCommonPrefix(string[] strs) {
if (strs == null || strs.Length == 0)
    {
        return "";
    }

    string prefix = strs[0]; // İlk metni varsayılan önek olarak al

    for (int i = 1; i < strs.Length; i++)
    {
        while (!strs[i].StartsWith(prefix)) // Metinlerin başlangıcında önek kontrolü yap
        {
            prefix = prefix.Substring(0, prefix.Length - 1); // Öneği bir karakter eksilt
            if (prefix.Length == 0)
            {
                return ""; // Önek bulunamadı
            }
        }
    }

    return prefix;
    }
}
