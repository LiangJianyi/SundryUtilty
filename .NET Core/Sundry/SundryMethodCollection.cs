using System.Linq;

namespace Janyee.Utilty {
    public static class SundryMethodCollection {
        public static string BytesToStringArray(byte[] source) {
            string[] temp = (from n in source select n.ToString("X")).ToArray();
            string text = string.Empty;
            text += "{ ";
            for (int i = 0; i < temp.Length; i++) {
                text += string.IsNullOrEmpty(temp[i]) ? "null" : "\"" + temp[i] + "\"";
                text += i == temp.Length - 1 ? " " : ", ";
            }
            text += "}";
            return text;
        }
    }
}
