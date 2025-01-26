namespace App.Application.Utilities
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public static bool VerifyPassword(string password, string hasedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hasedPassword);
        }
    }
}
