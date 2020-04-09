using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Decorator.CloudApp
{
    class CompressedCloudStream : IStream
    {
        private IStream stream;

        public CompressedCloudStream(IStream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            var compressedData = Compress(data);
            stream.Write(compressedData);
        }

        private string Compress(string data) => data.Substring(0, 5);
    }
}
