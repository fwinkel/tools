using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryReader
{
    class BinaryHelper
    {
        public enum CopyMode
        {
            binario,
            hexa,
            hexa_offset
        }

        public static void Write(string filename, int position, string bytes)
        {
            byte[] data = StringToByteArray(bytes);
            using (System.IO.Stream stream = System.IO.File.Open(filename, System.IO.FileMode.Open))
            {
                stream.Position = position;
                stream.Write(data, 0, data.Length);
            }
        }

        private static byte[] StringToByteArray(string data)
        {
            string[] sBytes = data.Split(new string[]{ "-", " " },  StringSplitOptions.RemoveEmptyEntries);
            int totalBytes = sBytes.Length;
            byte[] bytes = new byte[totalBytes];
            for (int i = 0; i < totalBytes; i ++)
                bytes[i] = Convert.ToByte(sBytes[i], 16);
            return bytes;
        }

        private static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba);//.Replace("-", "");
        }

        public static void CopyHeader(string archivoOrigen, int size, string archivoDestino, CopyMode mode)
        {
            byte[] buffer = new byte[size];
            using (System.IO.FileStream fs =
                new System.IO.FileStream(archivoOrigen, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
            }

            switch (mode)
            {
                case CopyMode.binario:
                    using (System.IO.Stream stream = System.IO.File.Open(archivoDestino, System.IO.FileMode.OpenOrCreate))
                    {
                        stream.Position = 0;
                        stream.Write(buffer, 0, buffer.Length);
                    }
                    break;
                case CopyMode.hexa:
                case CopyMode.hexa_offset:
                    string hexaBytes = ByteArrayToString(buffer);
                    StringBuilder result = new StringBuilder();
                    int lenLine = 16 * 3; // multiplo de 3
                    int lines = (hexaBytes.Length + lenLine - 1) / lenLine;
                    bool writeOffset = mode == CopyMode.hexa_offset;
                    for (int i = 0; i < lines; i++)
                    {
                        string offset = (writeOffset) ? (i * 16).ToString("X4").PadLeft(10, '0') + "\t" : string.Empty;

                        string hexaButeLine = (i + 1 == lines) ?
                            hexaBytes.Substring(lenLine * i) :
                            hexaBytes.Substring(lenLine * i, lenLine);
                        result.AppendLine(offset + hexaButeLine);
                    }
                    System.IO.File.WriteAllText(archivoDestino, result.ToString());
                    break;
            }
        }
    }
}
