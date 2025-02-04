using System.Text;

namespace CICD_cipher;
public class CipherService
{
    //Change this value to modify the shift
    private readonly int _shift = 3;

    public string Encrypt(string input) 
    {
        return ProcessInput(input, _shift);
    }
    public string Decrypt(string input)
    {
        return ProcessInput(input, _shift);
    }
    private string ProcessInput(string input, int shift)
    {
        var result = new StringBuilder();
        foreach (var character in input)
        {
            if (char.IsLetter(character))
            {
                char offset = char.IsUpper(character) ? 'A' : 'a';
                int letterValue = (character - offset + shift + 26) % 26;  //Ensure non-negative shift
                result.Append((char)(letterValue + offset));
            }
            else
            {
                //Keep non-letter characters unchanged
                result.Append(character);
            }
        }
        return result.ToString();
    }
}
