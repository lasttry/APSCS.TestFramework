using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace APSCS.TestFramework
{
    public class SSHCommunication
    {
        public string Server { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        SftpClient sftp;
        SshClient sshClient;

        public SSHCommunication(string server, string user, string password)
        {
            Server = server;
            User = user;
            Password = password;

            sftp = new SftpClient(Server, User, Password);
            sshClient = new SshClient(Server, User, Password);
        }

        public void CopyFile(string file, string directory = "")
        {
            if (!sftp.IsConnected)
                sftp.Connect();
            string previousDirectory = sftp.WorkingDirectory;

            if(directory.Length != 0)
                sftp.ChangeDirectory(directory);

            using (var fileStream = new FileStream(file, FileMode.Open))
            {
                sftp.BufferSize = 4 * 1024;
                sftp.UploadFile(fileStream, Path.GetFileName(file));
            }

            if (previousDirectory.Length != 0)
                sftp.ChangeDirectory(previousDirectory);
        }

        public SshCommand RunCommand(string cmd)
        {
            if (!sshClient.IsConnected)
                sshClient.Connect();

            var result = sshClient.RunCommand(cmd);
            return result;
        }

        public static string EndpointSH
        {
            get { return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "endpoint.sh"); }
        }

        public static void DownloadEndpoint()
        {
            WebClient client = new WebClient();
            client.DownloadFile(new Uri(Settings.GetEndpointSHUrl()), EndpointSH);
        }
    }
}
