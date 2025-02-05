using System.Text;

namespace CICD_cipher;
public class CipherService
{
    //Change this value to modify the shift
    private readonly int _shift = 3;

    public string Encrypt(string input)
    {
        var result = "";
        int leterValue;
        foreach (var character in input)
        {
            leterValue = character;
            if (char.IsLetter(character))
            {
                if (char.IsUpper(character))
                {
                    result += (char)((leterValue - 'A' + _shift) % 26 + 'A');
                }
                else
                {
                    result += (char)((leterValue - 'a' + _shift) % 26 + 'a');
                }
            }
            else
            {
                //Keep non-letter characters unchanged
                result += character;
            }
        }
        return result;
    }
    public string Decrypt(string dinput)
    {
        var result = "";
        int leterValue;
        foreach (var character in dinput)
        {
            leterValue = character;
            if (char.IsLetter(character))
            {
                if (char.IsUpper(character))
                {
                    result += (char)((leterValue - 'A' - _shift + 26) % 26 + 'A');
                }
                else
                {
                    result += (char)((leterValue - 'a' - _shift + 26) % 26 + 'a');
                }
            }
            else
            {
                //Keep non-letter characters unchanged
                result += character;
            }
        }
        return result;
    }
}
