using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BinaryReader
{
    public partial class FrmBinaryManager : Form
    {
        public FrmBinaryManager()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    /*
        //                string archivo = @"Y:\W7Pro64.vdi";
        //                //MessageBoxLeerCabecera(archivo, "ERROR-vd1", false);

        //                archivo = @"Y:\pp.vdi";
        //                MessageBoxLeerCabecera(archivo, "pp-vd1", true);
        //    */
        //    /*
        //    string fileNameRefer = @"E:\Desarrollo\Virtual Box\W7Pro64\W7Pro64.vdi";
        //    string filenameError = @"E:\Virtual Machines\REPARAR\W7Pro64\W7Pro64.vdi";

        //    //MessageBox.Show(CompararCabeceras(fileNameRefer, filenameError));
        //    MessageBoxLeerCabecera(fileNameRefer, @"referencia");
        //    MessageBoxLeerCabecera(filenameError, @"error");
        //    //string filenameError = @"E:\Virtual Machines\REPARAR\W7Pro64\W7Pro64.vdi";
        //    //ReadBinaryHead(512, filenameError);
             
        //     */
        //}

        //private void MessageBoxLeerCabecera(string filename, string tag, bool grabarArchivo = true)
        //{
        //    MessageBox.Show(LeerCabecera(filename, tag, grabarArchivo), "[" + tag + "] " + filename, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private string LeerCabecera(string filename, string tag, bool grabarArchivo = true)
        //{
        //    int len = 512;

        //    string a = GetHeader(len, filename);

        //    StringBuilder result = new StringBuilder();
        //    //            int lines = 4;
        //    //            int lenLine = a.Length / lines;
        //    int lenLine = 48;
        //    int lines = a.Length / lenLine;
        //    for (int i = 0; i < lines; i++)
        //    {
        //        string offset = (i * 16).ToString("X4");
        //        result.AppendLine(offset + "\t" + a.Substring(lenLine * i, lenLine));
        //        //result.AppendLine();
        //    }
        //    if (grabarArchivo)
        //    {
        //        //string outputFile = "E:\\Virtual Machines\\REPARAR\\" + tag + ".txt";
        //        string outputFile = tag + ".txt";
        //        System.IO.File.WriteAllText(outputFile, result.ToString());
        //    }
        //    return result.ToString();
        //}

        //private string CompararCabeceras(string filenameA, string filenameB)
        //{
        //    int len = 512;

        //    string a = GetHeader(len, filenameA);
        //    string b = GetHeader(len, filenameB);

        //    StringBuilder result = new StringBuilder();
        //    //            int lines = 4;
        //    //            int lenLine = a.Length / lines;
        //    int lenLine = 99;
        //    int lines = a.Length / lenLine;
        //    for (int i = 0; i < lines; i++)
        //    {
        //        result.AppendLine(a.Substring(lenLine * i, lenLine));
        //        result.AppendLine(b.Substring(lenLine * i, lenLine));
        //        result.AppendLine();
        //    }
        //    return result.ToString();
        //}

        //private string GetHeader(int len, string filename)
        //{

        //    byte[] buffer = new byte[len];
        //    using (System.IO.FileStream fs =
        //        new System.IO.FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read))
        //    {
        //        fs.Read(buffer, 0, buffer.Length);
        //        fs.Close();
        //    }
        //    return ByteArrayToString(buffer);
        //}

        //private void ReadBinaryHead(int len, string filename)
        //{

        //    byte[] buffer = new byte[len];
        //    try
        //    {
        //        using (System.IO.FileStream fs =
        //            new System.IO.FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read))
        //        {
        //            fs.Read(buffer, 0, buffer.Length);
        //            fs.Close();
        //        }
        //        string msg = ByteArrayToString(buffer);
        //        MessageBox.Show(msg, System.IO.Path.GetFileName(filename), MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (System.UnauthorizedAccessException ex)
        //    {
        //        MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace, System.IO.Path.GetFileName(filename), MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //public static string ByteArrayToString(byte[] ba)
        //{
        //    return BitConverter.ToString(ba); //.Replace("-", "");
        //}

        //public static string ByteArrayToString2(byte[] ba)
        //{
        //    StringBuilder hex = new StringBuilder(ba.Length * 2);
        //    foreach (byte b in ba)
        //        hex.AppendFormat("{0:x2}", b);
        //    return hex.ToString();
        //}

        //private static byte[] StringToByteArray(string hex)
        //{
        //    int numberChars = hex.Length;
        //    int totalBytes = numberChars / 3;
        //    byte[] bytes = new byte[totalBytes];
        //    for (int i = 0; i < numberChars; i += 3)
        //        bytes[i / 3] = Convert.ToByte(hex.Substring(i, 2), 16);
        //    return bytes;
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    byte[] bytes = StringToByteArray("90-01-00-00-");
        //    bytes = StringToByteArray("40-25-66-15-");
        //    bytes = StringToByteArray("90-01-00-00-");

        //    string archivo = @"Y:\W7Pro64.vdi";
        //    //ReplaceData(archivo, 72, bytes);
        //    MessageBoxLeerCabecera(archivo, "ERROR-vd1-fix", false);
        //    /*
        //    string archivo = @"Y:\W7Pro64.vdi";
        //    ReplaceData(archivo, 72, bytes)
        //    MessageBoxLeerCabecera(archivo, "ERROR-vd1");
        //    */
        //}

        //private static void ReplaceData(string filename, int position, byte[] data)
        //{
        //    using (System.IO.Stream stream = System.IO.File.Open(filename, System.IO.FileMode.Open))
        //    {
        //        stream.Position = position;
        //        stream.Write(data, 0, data.Length);
        //    }
        //}

        //private void btnCopiarEncabezadoBinario_Click(object sender, EventArgs e)
        //{

        //    string archivo = @"Y:\W7Pro64.vdi";
        //    string header = @"Y:\W7Pro64-header.vdi";

        //    archivo = txtOrigen.Text;
        //    header = txtDestino.Text;

        //    int size = (int)nudBytes.Value; //2098176
        //    byte[] buffer = new byte[size];
        //    using (System.IO.FileStream fs =
        //        new System.IO.FileStream(archivo, System.IO.FileMode.Open, System.IO.FileAccess.Read))
        //    {
        //        fs.Read(buffer, 0, buffer.Length);
        //        fs.Close();
        //    }

        //    using (System.IO.Stream stream = System.IO.File.Open(header, System.IO.FileMode.OpenOrCreate))
        //    {
        //        stream.Position = 0;
        //        stream.Write(buffer, 0, buffer.Length);
        //    }

        //    MessageBox.Show("Done");

        //}

        private void nudOffset_ValueChanged(object sender, EventArgs e)
        {
            ActualzarOffsetHexa();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualzarOffsetHexa();

        }

        private void ActualzarOffsetHexa()
        {
            lblEscribirOffsetHexa.Text = string.Format("0x{0:x2}", (int)nudOffset.Value);
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            try
            {
                var copyMode = (rbBinario.Checked) ? BinaryHelper.CopyMode.binario : BinaryHelper.CopyMode.hexa_offset;
                BinaryHelper.CopyHeader(txtOrigen.Text, (int)nudBytes.Value, txtDestino.Text, copyMode);
                MessageBox.Show("Copia finalizada.");
            }
            catch (Exception exc)
            {
                ShowException(exc);
            }
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryHelper.Write(txtOrigen.Text, (int)nudOffset.Value, txtEscribirBytes.Text);
                MessageBox.Show("Escritura finalizada.");
            }
            catch (Exception exc)
            {
                ShowException(exc);
            }

        }

        void ShowException(Exception exc)
        {
            MessageBox.Show(exc.Message + Environment.NewLine + exc.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
