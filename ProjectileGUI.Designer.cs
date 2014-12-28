namespace Projectile_Maker
{
    partial class ProjectileGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.remoteTextureBox = new System.Windows.Forms.TextBox();
            this.indexBox = new System.Windows.Forms.TextBox();
            this.textureFileBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TriggerTexture = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.projIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.objIdBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.damageBox = new System.Windows.Forms.TextBox();
            this.lifetimeBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // remoteTextureBox
            // 
            this.remoteTextureBox.Location = new System.Drawing.Point(145, 34);
            this.remoteTextureBox.Name = "remoteTextureBox";
            this.remoteTextureBox.Size = new System.Drawing.Size(129, 20);
            this.remoteTextureBox.TabIndex = 204;
            this.remoteTextureBox.Visible = false;
            // 
            // indexBox
            // 
            this.indexBox.Location = new System.Drawing.Point(280, 34);
            this.indexBox.Name = "indexBox";
            this.indexBox.Size = new System.Drawing.Size(129, 20);
            this.indexBox.TabIndex = 202;
            // 
            // textureFileBox
            // 
            this.textureFileBox.Location = new System.Drawing.Point(9, 34);
            this.textureFileBox.Name = "textureFileBox";
            this.textureFileBox.Size = new System.Drawing.Size(129, 20);
            this.textureFileBox.TabIndex = 201;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 206;
            this.label5.Text = "Remote Texture";
            this.label5.Visible = false;
            // 
            // TriggerTexture
            // 
            this.TriggerTexture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TriggerTexture.Location = new System.Drawing.Point(173, 95);
            this.TriggerTexture.Name = "TriggerTexture";
            this.TriggerTexture.Size = new System.Drawing.Size(80, 23);
            this.TriggerTexture.TabIndex = 205;
            this.TriggerTexture.Text = "Remote";
            this.TriggerTexture.UseVisualStyleBackColor = true;
            this.TriggerTexture.Click += new System.EventHandler(this.TriggerTexture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 203;
            this.label4.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 200;
            this.label3.Text = "Texture File";
            // 
            // projIdBox
            // 
            this.projIdBox.Location = new System.Drawing.Point(9, 135);
            this.projIdBox.Name = "projIdBox";
            this.projIdBox.Size = new System.Drawing.Size(129, 20);
            this.projIdBox.TabIndex = 207;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 208;
            this.label1.Text = "Projectile Id (usually 0)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 209;
            this.label2.Text = "Speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 210;
            this.label6.Text = "Damage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 211;
            this.label7.Text = "Object Id";
            // 
            // objIdBox
            // 
            this.objIdBox.Location = new System.Drawing.Point(280, 135);
            this.objIdBox.Name = "objIdBox";
            this.objIdBox.Size = new System.Drawing.Size(129, 20);
            this.objIdBox.TabIndex = 212;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 214;
            this.label8.Text = "Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 215;
            this.label9.Text = "LifetimeMS";
            // 
            // speedBox
            // 
            this.speedBox.Location = new System.Drawing.Point(12, 202);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(95, 20);
            this.speedBox.TabIndex = 219;
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(214, 202);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(95, 20);
            this.sizeBox.TabIndex = 220;
            // 
            // damageBox
            // 
            this.damageBox.Location = new System.Drawing.Point(113, 202);
            this.damageBox.Name = "damageBox";
            this.damageBox.Size = new System.Drawing.Size(95, 20);
            this.damageBox.TabIndex = 221;
            // 
            // lifetimeBox
            // 
            this.lifetimeBox.Location = new System.Drawing.Point(315, 202);
            this.lifetimeBox.Name = "lifetimeBox";
            this.lifetimeBox.Size = new System.Drawing.Size(95, 20);
            this.lifetimeBox.TabIndex = 222;
            this.lifetimeBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 223;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProjectileGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(421, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lifetimeBox);
            this.Controls.Add(this.damageBox);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.objIdBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projIdBox);
            this.Controls.Add(this.remoteTextureBox);
            this.Controls.Add(this.indexBox);
            this.Controls.Add(this.textureFileBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TriggerTexture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "ProjectileGUI";
            this.Text = "Projectile Creator - Versified";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox remoteTextureBox;
        private System.Windows.Forms.TextBox indexBox;
        private System.Windows.Forms.TextBox textureFileBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TriggerTexture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox projIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox objIdBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox speedBox;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.TextBox damageBox;
        private System.Windows.Forms.TextBox lifetimeBox;
        private System.Windows.Forms.Button button1;
    }
}

