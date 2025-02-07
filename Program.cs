var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var cipherService = new CICD_cipher.CipherService();

app.MapGet("/", () => "Welcome to API for Caesar Cipher!\n\n +" +
"For encrypting use: /encrypt?input= <text>\n\n" +
"For decrypting use: /decrypt?dinput= <text>");

//Endpoint for encrypting the input
app.MapGet("/encrypt", (string input) =>
{
    return cipherService.Encrypt(input);
});
//Endpoint for decrypting the input
app.MapGet("/decrypt", (string dinput) =>
{
    return cipherService.Decrypt(dinput);
});

app.Run();
