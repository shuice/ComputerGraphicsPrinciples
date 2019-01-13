namespace ComputerGraphics
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cubePosX = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.Label();
            this.cubePosY = new System.Windows.Forms.TextBox();
            this.cubePosZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cubeRotateZ = new System.Windows.Forms.TextBox();
            this.cubeRotateY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cubeRotateX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cubeScaleZ = new System.Windows.Forms.TextBox();
            this.cubeScaleY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cubeScaleX = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cameraPosX = new System.Windows.Forms.TextBox();
            this.cameraPosY = new System.Windows.Forms.TextBox();
            this.cameraPosZ = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cameraRotateX = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cameraRotateY = new System.Windows.Forms.TextBox();
            this.cameraRotateZ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(22, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(653, 454);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cubePosX
            // 
            this.cubePosX.Location = new System.Drawing.Point(66, 41);
            this.cubePosX.Name = "cubePosX";
            this.cubePosX.Size = new System.Drawing.Size(67, 21);
            this.cubePosX.TabIndex = 2;
            this.cubePosX.TextChanged += new System.EventHandler(this.cubePosX_TextChanged);
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(32, 26);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(53, 12);
            this.Position.TabIndex = 3;
            this.Position.Text = "Position";
            // 
            // cubePosY
            // 
            this.cubePosY.Location = new System.Drawing.Point(66, 68);
            this.cubePosY.Name = "cubePosY";
            this.cubePosY.Size = new System.Drawing.Size(67, 21);
            this.cubePosY.TabIndex = 4;
            this.cubePosY.TextChanged += new System.EventHandler(this.cubePosY_TextChanged);
            // 
            // cubePosZ
            // 
            this.cubePosZ.Location = new System.Drawing.Point(66, 95);
            this.cubePosZ.Name = "cubePosZ";
            this.cubePosZ.Size = new System.Drawing.Size(67, 21);
            this.cubePosZ.TabIndex = 5;
            this.cubePosZ.TextChanged += new System.EventHandler(this.cubePosZ_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Z:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "Z:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "X:";
            // 
            // cubeRotateZ
            // 
            this.cubeRotateZ.Location = new System.Drawing.Point(177, 95);
            this.cubeRotateZ.Name = "cubeRotateZ";
            this.cubeRotateZ.Size = new System.Drawing.Size(67, 21);
            this.cubeRotateZ.TabIndex = 12;
            this.cubeRotateZ.TextChanged += new System.EventHandler(this.cubeRotateZ_TextChanged);
            // 
            // cubeRotateY
            // 
            this.cubeRotateY.Location = new System.Drawing.Point(177, 68);
            this.cubeRotateY.Name = "cubeRotateY";
            this.cubeRotateY.Size = new System.Drawing.Size(67, 21);
            this.cubeRotateY.TabIndex = 11;
            this.cubeRotateY.TextChanged += new System.EventHandler(this.cubeRotateY_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rotation";
            // 
            // cubeRotateX
            // 
            this.cubeRotateX.Location = new System.Drawing.Point(177, 41);
            this.cubeRotateX.Name = "cubeRotateX";
            this.cubeRotateX.Size = new System.Drawing.Size(67, 21);
            this.cubeRotateX.TabIndex = 9;
            this.cubeRotateX.TextChanged += new System.EventHandler(this.cubeRotateX_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "Z:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "X:";
            // 
            // cubeScaleZ
            // 
            this.cubeScaleZ.Location = new System.Drawing.Point(290, 95);
            this.cubeScaleZ.Name = "cubeScaleZ";
            this.cubeScaleZ.Size = new System.Drawing.Size(67, 21);
            this.cubeScaleZ.TabIndex = 19;
            this.cubeScaleZ.TextChanged += new System.EventHandler(this.cubeScaleZ_TextChanged);
            // 
            // cubeScaleY
            // 
            this.cubeScaleY.Location = new System.Drawing.Point(290, 68);
            this.cubeScaleY.Name = "cubeScaleY";
            this.cubeScaleY.Size = new System.Drawing.Size(67, 21);
            this.cubeScaleY.TabIndex = 18;
            this.cubeScaleY.TextChanged += new System.EventHandler(this.cubeScaleY_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(256, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "Scale";
            // 
            // cubeScaleX
            // 
            this.cubeScaleX.Location = new System.Drawing.Point(290, 41);
            this.cubeScaleX.Name = "cubeScaleX";
            this.cubeScaleX.Size = new System.Drawing.Size(67, 21);
            this.cubeScaleX.TabIndex = 16;
            this.cubeScaleX.TextChanged += new System.EventHandler(this.cubeScaleX_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Position);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cubePosX);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cubePosY);
            this.groupBox1.Controls.Add(this.cubeScaleZ);
            this.groupBox1.Controls.Add(this.cubePosZ);
            this.groupBox1.Controls.Add(this.cubeScaleY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cubeScaleX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cubeRotateX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cubeRotateY);
            this.groupBox1.Controls.Add(this.cubeRotateZ);
            this.groupBox1.Location = new System.Drawing.Point(22, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 123);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "立方体属性";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cameraPosX);
            this.groupBox2.Controls.Add(this.cameraPosY);
            this.groupBox2.Controls.Add(this.cameraPosZ);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cameraRotateX);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.cameraRotateY);
            this.groupBox2.Controls.Add(this.cameraRotateZ);
            this.groupBox2.Location = new System.Drawing.Point(407, 488);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 123);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "相机属性";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "Position";
            // 
            // cameraPosX
            // 
            this.cameraPosX.Location = new System.Drawing.Point(66, 41);
            this.cameraPosX.Name = "cameraPosX";
            this.cameraPosX.Size = new System.Drawing.Size(67, 21);
            this.cameraPosX.TabIndex = 2;
            this.cameraPosX.TextChanged += new System.EventHandler(this.cameraPosX_TextChanged);
            // 
            // cameraPosY
            // 
            this.cameraPosY.Location = new System.Drawing.Point(66, 68);
            this.cameraPosY.Name = "cameraPosY";
            this.cameraPosY.Size = new System.Drawing.Size(67, 21);
            this.cameraPosY.TabIndex = 4;
            this.cameraPosY.TextChanged += new System.EventHandler(this.cameraPosY_TextChanged);
            // 
            // cameraPosZ
            // 
            this.cameraPosZ.Location = new System.Drawing.Point(66, 95);
            this.cameraPosZ.Name = "cameraPosZ";
            this.cameraPosZ.Size = new System.Drawing.Size(67, 21);
            this.cameraPosZ.TabIndex = 5;
            this.cameraPosZ.TextChanged += new System.EventHandler(this.cameraPosZ_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 6;
            this.label16.Text = "X:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(43, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 7;
            this.label18.Text = "Z:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(43, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 8;
            this.label19.Text = "Y:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(154, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 15;
            this.label20.Text = "Y:";
            // 
            // cameraRotateX
            // 
            this.cameraRotateX.Location = new System.Drawing.Point(177, 41);
            this.cameraRotateX.Name = "cameraRotateX";
            this.cameraRotateX.Size = new System.Drawing.Size(67, 21);
            this.cameraRotateX.TabIndex = 9;
            this.cameraRotateX.TextChanged += new System.EventHandler(this.cameraRotateX_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(154, 98);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 12);
            this.label21.TabIndex = 14;
            this.label21.Text = "Z:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(143, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 10;
            this.label22.Text = "Rotation";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(154, 44);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 12);
            this.label23.TabIndex = 13;
            this.label23.Text = "X:";
            // 
            // cameraRotateY
            // 
            this.cameraRotateY.Location = new System.Drawing.Point(177, 68);
            this.cameraRotateY.Name = "cameraRotateY";
            this.cameraRotateY.Size = new System.Drawing.Size(67, 21);
            this.cameraRotateY.TabIndex = 11;
            this.cameraRotateY.TextChanged += new System.EventHandler(this.cameraRotateY_TextChanged);
            // 
            // cameraRotateZ
            // 
            this.cameraRotateZ.Location = new System.Drawing.Point(177, 95);
            this.cameraRotateZ.Name = "cameraRotateZ";
            this.cameraRotateZ.Size = new System.Drawing.Size(67, 21);
            this.cameraRotateZ.TabIndex = 12;
            this.cameraRotateZ.TextChanged += new System.EventHandler(this.cameraRotateZ_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 617);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cubePosX;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.TextBox cubePosY;
        private System.Windows.Forms.TextBox cubePosZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cubeRotateZ;
        private System.Windows.Forms.TextBox cubeRotateY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cubeRotateX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cubeScaleZ;
        private System.Windows.Forms.TextBox cubeScaleY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cubeScaleX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cameraPosX;
        private System.Windows.Forms.TextBox cameraPosY;
        private System.Windows.Forms.TextBox cameraPosZ;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox cameraRotateX;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox cameraRotateY;
        private System.Windows.Forms.TextBox cameraRotateZ;
    }
}

