using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication {
    public static class ConnectionSettings {
        public static string ConnectionSring, BlobContainerName;
        public static void SetUp(string connectionString, string blobContainerName) {
            ConnectionSring = connectionString;
            BlobContainerName = blobContainerName;
        }
    }
}
