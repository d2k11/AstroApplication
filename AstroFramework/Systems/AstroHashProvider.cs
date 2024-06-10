using System.Security.Cryptography;
using System.Text;

namespace AstroFramework.Systems;

public class AstroHashProvider
{
    /// <summary>
    /// Get the MD5 hash of a string.
    /// </summary>
    /// <param name="str">The string to get the MD5 hash of.</param>
    /// <returns>The MD5 hash of the string.</returns>
    public static string GetMD5(string str)
    {
        return BitConverter.ToString(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(str))).Replace("-", string.Empty);
    }

    /// <summary>
    /// Get the MD5 hash of a byte array.
    /// </summary>
    /// <param name="bytes">The byte array to get the MD5 hash of.</param>
    /// <returns>The MD5 hash.</returns>
    public static string GetMD5(byte[] bytes)
    {
        return BitConverter.ToString(MD5.Create().ComputeHash(bytes)).Replace("-", string.Empty);
    }
    
    /// <summary>
    /// Get the SHA256 hash of a string.
    /// </summary>
    /// <param name="str">The string to get the SHA256 hash of.</param>
    /// <returns>The MD5 hash of the string</returns>
    public static string GetSHA256(string str)
    {
        return BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(str))).Replace("-", string.Empty);
    }
    
    /// <summary>
    /// Get the SHA256 hash of a byte array.
    /// </summary>
    /// <param name="bytes">The byte array to get the SHA256 hash of.</param>
    /// <returns>The SHA256 hash of the string</returns>
    public static string GetSHA256(byte[] bytes)
    {
        return BitConverter.ToString(SHA256.Create().ComputeHash(bytes)).Replace("-", string.Empty);
    }
}