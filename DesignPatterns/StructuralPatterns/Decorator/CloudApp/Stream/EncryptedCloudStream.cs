using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Decorator.CloudApp
{
    class EncryptedCloudStream : IStream
    {
        private IStream stream;

        public EncryptedCloudStream(IStream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            var encryptedData = Encrypt(data);
            stream.Write(encryptedData);
        }

        private string Encrypt(string data) => data.Length > 0 ? $"!!#@$$@#(%&*!#%&(#%-{data.Substring((data.Length >= 5 ? data.Length-5 : 0), 5)}" :
            "!@#$@$%%";
    }
}
