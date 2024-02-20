using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace UserInterFace
{
    public class GetHash
    {
        public byte[] computeHash(byte[] input)
        {
            using (var md5Hash = MD5.Create())
            {
                return md5Hash.ComputeHash(input);
            }
        }
    }
}
