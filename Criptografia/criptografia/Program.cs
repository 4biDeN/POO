using System;
using System.IO;
using System.Text;

public class Program
{
    public static void Main()
    {
        // Criptografia Simétrica
        Console.Write("Digite a senha para criptografia: ");
        string password = Console.ReadLine();

        byte[] salt = Encoding.UTF8.GetBytes("salt1234"); // Em um cenário real, gere um salt aleatório
        var fileEncryptor = new FileEncryptor(password, salt);

        // Solicitar os caminhos dos arquivos ao usuário
        Console.Write("Digite o caminho do arquivo a ser criptografado: ");
        string inputFile = Console.ReadLine();

        Console.Write("Digite o caminho onde o arquivo criptografado será salvo: ");
        string encryptedFile = Console.ReadLine();

        Console.Write("Digite o caminho onde o arquivo descriptografado será salvo: ");
        string decryptedFile = Console.ReadLine();

        // Criptografia Assimétrica
        var asymmetricEncryptor = new AsymmetricFileEncryptor();

        // Exportar e importar a chave pública
        string publicKey = asymmetricEncryptor.ExportPublicKey();
        Console.WriteLine("Chave pública:");
        Console.WriteLine(publicKey);

        // Exportar e importar a chave privada
        string privateKey = asymmetricEncryptor.ExportPrivateKey();
        Console.WriteLine("Chave privada:");
        Console.WriteLine(privateKey);

        try
        {
            // 1. Criptografar o arquivo com AES
            fileEncryptor.EncryptFile(inputFile, encryptedFile);
            Console.WriteLine("Arquivo criptografado com sucesso!");

            // 2. Criptografar a chave e IV com RSA
            byte[] encryptedKey = asymmetricEncryptor.EncryptData(fileEncryptor.Key);
            byte[] encryptedIV = asymmetricEncryptor.EncryptData(fileEncryptor.IV);

            // Salvar as chaves criptografadas
            File.WriteAllBytes(encryptedFile + ".key", encryptedKey);
            File.WriteAllBytes(encryptedFile + ".iv", encryptedIV);

            // Para simular a transferência, criar uma nova instância e importar a chave privada
            var decryptor = new AsymmetricFileEncryptor();
            decryptor.ImportPrivateKey(privateKey);

            // 3. Descriptografar a chave e IV com RSA
            byte[] decryptedKey = decryptor.DecryptData(File.ReadAllBytes(encryptedFile + ".key"));
            byte[] decryptedIV = decryptor.DecryptData(File.ReadAllBytes(encryptedFile + ".iv"));

            // Configurar o FileEncryptor com a chave e IV descriptografadas
            var fileDecryptor = new FileEncryptor(password, salt)
            {
                Key = decryptedKey,
                IV = decryptedIV
            };

            // 4. Descriptografar o arquivo com AES
            fileDecryptor.DecryptFile(encryptedFile, decryptedFile);
            Console.WriteLine("Arquivo descriptografado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}
