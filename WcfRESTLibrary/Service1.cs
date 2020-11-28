using System;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfRESTLibrary
{
    [ServiceBehavior(
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class Service1 : IService1
    {
        public string GetFilePiece(string fileName, string offset, string size)
        {
            byte[] piece = File.ReadAllBytes(fileName).Skip(Int32.Parse(offset)).Take(Int32.Parse(size)).ToArray();
            return Encoding.Default.GetString(piece);
        }


        public string ReceiveText(string fileName, string text)
        {
            StreamWriter writer = File.AppendText(fileName);
            writer.Write(text);
            writer.Close();
            return "written";
        }


        public int GetHashCode(string text)
        {
            return text.GetHashCode();
        }


        public string GetBase64Code(Stream data)
        {
            StreamReader reader = new StreamReader(data);
            byte[] bytes = Encoding.UTF8.GetBytes(reader.ReadToEnd());
            return Convert.ToBase64String(bytes);
        }


        
    }
}
