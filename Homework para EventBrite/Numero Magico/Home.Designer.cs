namespace Numero_Magico
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.vsComputer = new System.Windows.Forms.RadioButton();
            this.vsHuman = new System.Windows.Forms.RadioButton();
            this.vsComputerGroup = new System.Windows.Forms.GroupBox();
            this.vsHumanGroup = new System.Windows.Forms.GroupBox();
            this.vsComputerLog = new System.Windows.Forms.RichTextBox();
            this.NumeroTxtBox = new System.Windows.Forms.TextBox();
            this.preguntaBtn = new System.Windows.Forms.Button();
            this.vsHumanLog = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.radioGroup.SuspendLayout();
            this.vsComputerGroup.SuspendLayout();
            this.vsHumanGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioGroup
            // 
            this.radioGroup.Controls.Add(this.vsHumanGroup);
            this.radioGroup.Controls.Add(this.vsComputerGroup);
            this.radioGroup.Controls.Add(this.vsHuman);
            this.radioGroup.Controls.Add(this.vsComputer);
            this.radioGroup.Location = new System.Drawing.Point(12, 12);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(932, 528);
            this.radioGroup.TabIndex = 0;
            this.radioGroup.TabStop = false;
            this.radioGroup.Text = "Modo de Juego";
            // 
            // vsComputer
            // 
            this.vsComputer.AutoSize = true;
            this.vsComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsComputer.Location = new System.Drawing.Point(129, 42);
            this.vsComputer.Name = "vsComputer";
            this.vsComputer.Size = new System.Drawing.Size(194, 29);
            this.vsComputer.TabIndex = 0;
            this.vsComputer.TabStop = true;
            this.vsComputer.Text = "Adivina mi Número";
            this.vsComputer.UseVisualStyleBackColor = true;
            this.vsComputer.CheckedChanged += new System.EventHandler(this.vsComputer_CheckedChanged);
            // 
            // vsHuman
            // 
            this.vsHuman.AutoSize = true;
            this.vsHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsHuman.Location = new System.Drawing.Point(601, 42);
            this.vsHuman.Name = "vsHuman";
            this.vsHuman.Size = new System.Drawing.Size(207, 29);
            this.vsHuman.TabIndex = 1;
            this.vsHuman.TabStop = true;
            this.vsHuman.Text = "Adivinaré tu Numero";
            this.vsHuman.UseVisualStyleBackColor = true;
            // 
            // vsComputerGroup
            // 
            this.vsComputerGroup.Controls.Add(this.preguntaBtn);
            this.vsComputerGroup.Controls.Add(this.NumeroTxtBox);
            this.vsComputerGroup.Controls.Add(this.vsComputerLog);
            this.vsComputerGroup.Location = new System.Drawing.Point(6, 77);
            this.vsComputerGroup.Name = "vsComputerGroup";
            this.vsComputerGroup.Size = new System.Drawing.Size(445, 445);
            this.vsComputerGroup.TabIndex = 2;
            this.vsComputerGroup.TabStop = false;
            // 
            // vsHumanGroup
            // 
            this.vsHumanGroup.Controls.Add(this.button4);
            this.vsHumanGroup.Controls.Add(this.button3);
            this.vsHumanGroup.Controls.Add(this.button2);
            this.vsHumanGroup.Controls.Add(this.vsHumanLog);
            this.vsHumanGroup.Location = new System.Drawing.Point(481, 77);
            this.vsHumanGroup.Name = "vsHumanGroup";
            this.vsHumanGroup.Size = new System.Drawing.Size(445, 445);
            this.vsHumanGroup.TabIndex = 3;
            this.vsHumanGroup.TabStop = false;
            // 
            // vsComputerLog
            // 
            this.vsComputerLog.Location = new System.Drawing.Point(7, 20);
            this.vsComputerLog.Name = "vsComputerLog";
            this.vsComputerLog.ReadOnly = true;
            this.vsComputerLog.Size = new System.Drawing.Size(432, 301);
            this.vsComputerLog.TabIndex = 0;
            this.vsComputerLog.Text = "";
            // 
            // NumeroTxtBox
            // 
            this.NumeroTxtBox.Location = new System.Drawing.Point(7, 328);
            this.NumeroTxtBox.Name = "NumeroTxtBox";
            this.NumeroTxtBox.Size = new System.Drawing.Size(289, 20);
            this.NumeroTxtBox.TabIndex = 1;
            this.NumeroTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroTxtBox_KeyPress);
            // 
            // preguntaBtn
            // 
            this.preguntaBtn.Location = new System.Drawing.Point(303, 328);
            this.preguntaBtn.Name = "preguntaBtn";
            this.preguntaBtn.Size = new System.Drawing.Size(136, 23);
            this.preguntaBtn.TabIndex = 2;
            this.preguntaBtn.Text = "Es tu Número?";
            this.preguntaBtn.UseVisualStyleBackColor = true;
            this.preguntaBtn.Click += new System.EventHandler(this.preguntaBtn_Click);
            // 
            // vsHumanLog
            // 
            this.vsHumanLog.Location = new System.Drawing.Point(7, 20);
            this.vsHumanLog.Name = "vsHumanLog";
            this.vsHumanLog.ReadOnly = true;
            this.vsHumanLog.Size = new System.Drawing.Size(432, 301);
            this.vsHumanLog.TabIndex = 0;
            this.vsHumanLog.Text = "";
            this.vsHumanLog.TextChanged += new System.EventHandler(this.vsHumanLog_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(7, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Menor";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(329, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Mayor";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(167, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Correcto!";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 552);
            this.Controls.Add(this.radioGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Numero Mágico";
            this.radioGroup.ResumeLayout(false);
            this.radioGroup.PerformLayout();
            this.vsComputerGroup.ResumeLayout(false);
            this.vsComputerGroup.PerformLayout();
            this.vsHumanGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox radioGroup;
        private System.Windows.Forms.GroupBox vsHumanGroup;
        private System.Windows.Forms.GroupBox vsComputerGroup;
        private System.Windows.Forms.RadioButton vsHuman;
        private System.Windows.Forms.RadioButton vsComputer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox vsHumanLog;
        private System.Windows.Forms.Button preguntaBtn;
        private System.Windows.Forms.TextBox NumeroTxtBox;
        private System.Windows.Forms.RichTextBox vsComputerLog;
    }
}

