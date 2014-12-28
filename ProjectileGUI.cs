using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projectile_Maker
{
    public partial class ProjectileGUI : Form
    {
        public ProjectileGUI()
        {
            InitializeComponent();
        }

        public string projId;
        public string objId;
        public string spd;
        public string damage;
        public string size;
        public string ltMS;

        private void TriggerTexture_Click(object sender, EventArgs e)
        {
            if (TriggerTexture.Text == "Client")
            {
                TriggerTexture.Text = "Remote";
                indexBox.Visible = true;
                textureFileBox.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = false;
                remoteTextureBox.Visible = false;
            }
            else
            {
                TriggerTexture.Text = "Client";
                indexBox.Visible = false;
                textureFileBox.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                remoteTextureBox.Visible = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            projId = projIdBox.Text;
            objId = objIdBox.Text;
            spd = speedBox.Text;
            ltMS = lifetimeBox.Text;
            ProjectileExecute();
        }
        public void ProjectileExecute()
        {
            using(var writer = new StreamWriter("Projectile.txt", true))
            {
                writer.WriteLine(@"<Projectile id=""" + projId + @""">");
                writer.WriteLine("<ObjectId>" + objId + "</ObjectId>");
                writer.WriteLine("<Speed>" + spd + "</Speed>");
                writer.WriteLine("<LifetimeMS>" + ltMS + "</LifetimeMS>");
                writer.WriteLine("</Projectile>");
            }
        }

    }
}
