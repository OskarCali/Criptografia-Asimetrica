using System;
using System.Security.Cryptography;
using System.Text;

namespace Criptografia_Asimetrica.Functions
{
    internal class RSA
    {
        /// <summary>
        ///     Propiedad que brinda el servicio de RSA
        /// </summary>
        public RSACryptoServiceProvider RSAProvider { get; set; }

        /// <summary>
        ///     Constructor de la clase RSA
        /// </summary>
        public RSA()
        {
            RSAProvider = new RSACryptoServiceProvider();
        }

        /// <summary>
        ///     Metodo para crear la llave publica usando RSA
        /// </summary>
        /// <returns>Arreglo de bits de la llave publica</returns>
        public byte[] crearPublicKey()
        {
            var pubKey = RSAProvider.ToXmlString(false);
            return Encoding.ASCII.GetBytes(pubKey);
        }

        /// <summary>
        ///     Metodo para crear la llave privada usando RSA
        /// </summary>
        /// <returns>Arreglo de bits de la llave privada</returns>
        public byte[] crearPrivateKey()
        {
            var privKey = RSAProvider.ToXmlString(true);
            return Encoding.ASCII.GetBytes(privKey);
        }

        /// <summary>
        ///     Metodo para encriptar informacion con la llave privada
        /// </summary>
        /// <param name="text">Informacion a encriptar</param>
        /// <param name="privKey">Llave privada</param>
        /// <returns>Informacion encriptada</returns>
        public static byte[] encriptar(string text, string privKey)
        {
            var rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString(privKey);
            var data = rsa.Encrypt(Encoding.ASCII.GetBytes(text), false);
            return data;
        }

        /// <summary>
        ///     Metodo para desencriptar informacion con la llave publica
        /// </summary>
        /// <param name="text">Informacion a desencriptar</param>
        /// <param name="pubKey">Llave publica</param>
        /// <returns>Informacion desencriptada</returns>
        public static byte[] desencriptar(string text, string pubKey)
        {
            var rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString(pubKey);
            var data = rsa.Decrypt(Convert.FromBase64String(text), false);
            return data;
        }
    }
}