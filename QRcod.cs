using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.WebRequestMethods;

namespace repair
{
    public partial class QRcod : Form
    {
        public QRcod()
        {
            InitializeComponent();
        }

        private void QRcod_Load(object sender, EventArgs e)
        {

            string qrtext = "https://";
            qrtext += "www.youtube.com/watch?v=bMiZkmqMIK0";
            QRCodeEncoder encoder = new QRCodeEncoder(); 
            Bitmap qrcode = encoder.Encode(qrtext); 
            pictureBox1.Image = qrcode as Image;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
