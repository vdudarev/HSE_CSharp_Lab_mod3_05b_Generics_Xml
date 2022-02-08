using System;
using System.Collections.Generic;

namespace Task03_GenericInterfaces
{
    public abstract class BinaryToStringEncoder : IEncrypted<byte[], string>
    {
        protected abstract Dictionary<string, byte[]> GetDictionary();

        public byte[] Encode(string u)
        {
            // TODO: реализовать данный метод
            throw new NotImplementedException();
            // return GetDictionary().
        }

        public string Decode(byte[] t)
        {
            // TODO: реализовать данный метод
            throw new NotImplementedException();
            // return GetDictionary().
        }
    }

}