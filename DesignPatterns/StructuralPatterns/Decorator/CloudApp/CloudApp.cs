using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Decorator.CloudApp
{
    public class CloudApp
    {
        public static void Run()
        {
            var compressedCloudStream = new CompressedCloudStream(new CloudStream());
            var encryptedCloudStream = new EncryptedCloudStream(compressedCloudStream);
            StoreCreditCard(encryptedCloudStream);
        }

        public static void StoreCreditCard(IStream stream)
        {
            stream.Write(data: "1234-1234-1234-1234");
        }
    }
}
