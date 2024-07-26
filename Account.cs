using System;
namespace HospitalBillCalculator
{
    internal static class Account
    {
        public static Dictionary<string, string> Users = new Dictionary<string, string>();

        public static bool Accs(string username, string password)
        {
            return Users.ContainsKey(username) && Users[username] == password;
        }
    }
}