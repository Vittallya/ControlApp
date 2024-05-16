using System.Security.Cryptography;

namespace ControlApp.Core.Extensions;

public static class StringExtensions
{
    const int keySize = 64;
    const int iterations = 350000;
    static readonly HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;
    static readonly byte[] _salt = Enumerable.Repeat((byte)15, keySize).ToArray();

    public static string GeneratePasswordHash(this string password)
    {
        var hash = Rfc2898DeriveBytes.Pbkdf2(
            password,
            _salt,
            iterations,
            hashAlgorithm,
            keySize);
        return Convert.ToHexString(hash);
    }
    public static bool VerifyPassword(this string password, string hash)
    {
        var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, _salt, iterations, hashAlgorithm, keySize);
        var fromHex = Convert.FromHexString(hash);
        return CryptographicOperations.FixedTimeEquals(hashToCompare, fromHex);
    }
}
