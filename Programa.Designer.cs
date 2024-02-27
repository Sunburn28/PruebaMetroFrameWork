namespace PruebaMetroFrameWork
{
    partial class Programa
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
            this.Precio = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Numero = new MetroFramework.Controls.MetroTextBox();
            this.Calcular = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chkesMedicamento = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Precio
            // 
            // 
            // 
            // 
            this.Precio.CustomButton.Image = null;
            this.Precio.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.Precio.CustomButton.Name = "";
            this.Precio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Precio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Precio.CustomButton.TabIndex = 1;
            this.Precio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Precio.CustomButton.UseSelectable = true;
            this.Precio.CustomButton.Visible = false;
            this.Precio.Lines = new string[0];
            this.Precio.Location = new System.Drawing.Point(87, 151);
            this.Precio.MaxLength = 32767;
            this.Precio.Name = "Precio";
            this.Precio.PasswordChar = '\0';
            this.Precio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Precio.SelectedText = "";
            this.Precio.SelectionLength = 0;
            this.Precio.SelectionStart = 0;
            this.Precio.ShortcutsEnabled = true;
            this.Precio.Size = new System.Drawing.Size(125, 23);
            this.Precio.TabIndex = 0;
            this.Precio.UseSelectable = true;
            this.Precio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Precio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(87, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(268, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Introduce el precio del producto";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(500, 100);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(291, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Introduce la cantidad de productos";
            // 
            // Numero
            // 
            // 
            // 
            // 
            this.Numero.CustomButton.Image = null;
            this.Numero.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.Numero.CustomButton.Name = "";
            this.Numero.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Numero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Numero.CustomButton.TabIndex = 1;
            this.Numero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Numero.CustomButton.UseSelectable = true;
            this.Numero.CustomButton.Visible = false;
            this.Numero.Lines = new string[0];
            this.Numero.Location = new System.Drawing.Point(500, 151);
            this.Numero.MaxLength = 32767;
            this.Numero.Name = "Numero";
            this.Numero.PasswordChar = '\0';
            this.Numero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Numero.SelectedText = "";
            this.Numero.SelectionLength = 0;
            this.Numero.SelectionStart = 0;
            this.Numero.ShortcutsEnabled = true;
            this.Numero.Size = new System.Drawing.Size(125, 23);
            this.Numero.TabIndex = 2;
            this.Numero.UseSelectable = true;
            this.Numero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Numero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Calcular
            // 
            this.Calcular.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Calcular.Location = new System.Drawing.Point(317, 301);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(146, 47);
            this.Calcular.TabIndex = 4;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseSelectable = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(23, 224);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(281, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "¿El producto es un medicamento?";
            // 
            // chkesMedicamento
            // 
            this.chkesMedicamento.AutoSize = true;
            this.chkesMedicamento.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkesMedicamento.Location = new System.Drawing.Point(32, 262);
            this.chkesMedicamento.Name = "chkesMedicamento";
            this.chkesMedicamento.Size = new System.Drawing.Size(37, 20);
            this.chkesMedicamento.TabIndex = 6;
            this.chkesMedicamento.Text = "Si";
            this.chkesMedicamento.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(573, 365);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(97, 44);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Salir";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Programa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.chkesMedicamento);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Precio);
            this.Name = "Programa";
            this.Text = "Impuesto";
            this.Load += new System.EventHandler(this.Programa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox Precio;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox Numero;
        private MetroFramework.Controls.MetroButton Calcular;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox chkesMedicamento;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

