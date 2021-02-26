
namespace CrearRegistroConDetalle.UI.Registros
{
    partial class RegistroPermisos
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
            this.components = new System.ComponentModel.Container();
            this.PermisoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.RolIdLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.PermisosErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PermisoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PermisosErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PermisoIdNumericUpDown
            // 
            this.PermisoIdNumericUpDown.Location = new System.Drawing.Point(108, 18);
            this.PermisoIdNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PermisoIdNumericUpDown.Name = "PermisoIdNumericUpDown";
            this.PermisoIdNumericUpDown.Size = new System.Drawing.Size(131, 23);
            this.PermisoIdNumericUpDown.TabIndex = 32;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(108, 58);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(192, 23);
            this.DescripcionTextBox.TabIndex = 31;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(8, 61);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(69, 15);
            this.DescripcionLabel.TabIndex = 30;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // RolIdLabel
            // 
            this.RolIdLabel.AutoSize = true;
            this.RolIdLabel.Location = new System.Drawing.Point(8, 20);
            this.RolIdLabel.Name = "RolIdLabel";
            this.RolIdLabel.Size = new System.Drawing.Size(69, 15);
            this.RolIdLabel.TabIndex = 29;
            this.RolIdLabel.Text = "Permisos ID";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(245, 18);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(55, 23);
            this.BuscarButton.TabIndex = 33;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(8, 95);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 38);
            this.NuevoButton.TabIndex = 34;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(117, 95);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 38);
            this.GuardarButton.TabIndex = 35;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(225, 95);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 38);
            this.EliminarButton.TabIndex = 36;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // PermisosErrorProvider
            // 
            this.PermisosErrorProvider.ContainerControl = this;
            // 
            // RegistroPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 149);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.PermisoIdNumericUpDown);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.RolIdLabel);
            this.Name = "RegistroPermisos";
            this.Text = "RegistroPermisos";
            ((System.ComponentModel.ISupportInitialize)(this.PermisoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PermisosErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PermisoIdNumericUpDown;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label RolIdLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider PermisosErrorProvider;
    }
}