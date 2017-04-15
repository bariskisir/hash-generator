using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace hash_generator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnGenerateHash_Click(object sender, EventArgs e)
        {
            var text = txtString.Text;
            if (!string.IsNullOrWhiteSpace(text))
            {
                txtMd5.Text = Crypto.HashMD5(text);
                txtSha1.Text = Crypto.HashSHA1(text);
                txtSha256.Text = Crypto.HashSHA256(text);
                txtSha384.Text = Crypto.HashSHA384(text);
                txtSha512.Text = Crypto.HashSHA512(text);
            }
        }
        private void txtMd5_Click(object sender, EventArgs e)
        {
            txtMd5.SelectAll();
        }
        private void txtSha1_Click(object sender, EventArgs e)
        {
            txtSha1.SelectAll();
        }
        private void txtSha256_Click(object sender, EventArgs e)
        {
            txtSha256.SelectAll();
        }
        private void txtSha384_Click(object sender, EventArgs e)
        {
            txtSha384.SelectAll();
        }
        private void txtSha512_Click(object sender, EventArgs e)
        {
            txtSha512.SelectAll();
        }
    }
}
