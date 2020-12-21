using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class frmBuscarFichero : Form
    {
        public frmBuscarFichero()
        {
            InitializeComponent();
        }

        private void btnBuscarFichero_Click(object sender, EventArgs e)
        {
            String md5Code;

            fdBuscarFichero.ShowDialog();

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            FileStream f = new FileStream(fdBuscarFichero.FileName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
            md5.ComputeHash(f);
            //Object ObjFSO = new Object();
            // = getFile(fdBuscarFichero.FileName);

            byte[] hash = md5.Hash;
            StringBuilder buff = new StringBuilder();
        
            foreach (byte hashbyte in hash)
            {
                buff.Append(String.Format("{0:X01}", hashbyte));
            }

            md5Code = buff.ToString();

            textBox1.Text = md5Code;
        }

        private void fdBuscarFichero_FileOk(object sender, CancelEventArgs e)
        {
            tbFilePath.Text = fdBuscarFichero.FileName;
        }
    }
}
