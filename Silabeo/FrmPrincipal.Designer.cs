namespace Silabeo
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.TxtTextoOriginal = new System.Windows.Forms.TextBox();
            this.CmdSeparar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTextoSeparado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbSeparador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTextoOriginal
            // 
            this.TxtTextoOriginal.Location = new System.Drawing.Point(15, 46);
            this.TxtTextoOriginal.Multiline = true;
            this.TxtTextoOriginal.Name = "TxtTextoOriginal";
            this.TxtTextoOriginal.Size = new System.Drawing.Size(332, 485);
            this.TxtTextoOriginal.TabIndex = 0;
            // 
            // CmdSeparar
            // 
            this.CmdSeparar.Location = new System.Drawing.Point(359, 254);
            this.CmdSeparar.Name = "CmdSeparar";
            this.CmdSeparar.Size = new System.Drawing.Size(75, 23);
            this.CmdSeparar.TabIndex = 2;
            this.CmdSeparar.Text = "Separar";
            this.CmdSeparar.UseVisualStyleBackColor = true;
            this.CmdSeparar.Click += new System.EventHandler(this.CmdSeparar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto Original";
            // 
            // TxtTextoSeparado
            // 
            this.TxtTextoSeparado.Location = new System.Drawing.Point(454, 46);
            this.TxtTextoSeparado.Multiline = true;
            this.TxtTextoSeparado.Name = "TxtTextoSeparado";
            this.TxtTextoSeparado.Size = new System.Drawing.Size(304, 485);
            this.TxtTextoSeparado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto Separado por silabas";
            // 
            // CmbSeparador
            // 
            this.CmbSeparador.FormattingEnabled = true;
            this.CmbSeparador.Items.AddRange(new object[] {
            "+",
            "-"});
            this.CmbSeparador.Location = new System.Drawing.Point(359, 214);
            this.CmbSeparador.Name = "CmbSeparador";
            this.CmbSeparador.Size = new System.Drawing.Size(75, 21);
            this.CmbSeparador.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Separador de SIlaba";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de..";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 565);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbSeparador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTextoSeparado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdSeparar);
            this.Controls.Add(this.TxtTextoOriginal);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silabeo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTextoOriginal;
        private System.Windows.Forms.Button CmdSeparar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTextoSeparado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbSeparador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

