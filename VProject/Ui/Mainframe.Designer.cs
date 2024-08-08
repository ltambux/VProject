namespace VProject.Ui{
    partial class Mainframe{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components=null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
            if(disposing && (components!=null)){
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cmbDiam = new System.Windows.Forms.ComboBox();
            this.lblWd = new System.Windows.Forms.Label();
            this.cmbWidth = new System.Windows.Forms.ComboBox();
            this.cmbPerc = new System.Windows.Forms.ComboBox();
            this.boxWtot = new System.Windows.Forms.TextBox();
            this.lblWdRes = new System.Windows.Forms.Label();
            this.lblGear = new System.Windows.Forms.Label();
            this.cmbGearSelection = new System.Windows.Forms.ComboBox();
            this.boxGear = new System.Windows.Forms.TextBox();
            this.lblFDrive = new System.Windows.Forms.Label();
            this.boxFDrive = new System.Windows.Forms.TextBox();
            this.lblCar = new System.Windows.Forms.Label();
            this.cmbCar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbDiam
            // 
            this.cmbDiam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiam.FormattingEnabled = true;
            this.cmbDiam.Location = new System.Drawing.Point(138, 81);
            this.cmbDiam.Margin = new System.Windows.Forms.Padding(0);
            this.cmbDiam.Name = "cmbDiam";
            this.cmbDiam.Size = new System.Drawing.Size(80, 26);
            this.cmbDiam.TabIndex = 0;
            this.cmbDiam.SelectedIndexChanged += new System.EventHandler(this.cmbDiam_IndexChange);
            // 
            // lblWd
            // 
            this.lblWd.ForeColor = System.Drawing.SystemColors.Window;
            this.lblWd.Location = new System.Drawing.Point(16, 80);
            this.lblWd.Margin = new System.Windows.Forms.Padding(0);
            this.lblWd.Name = "lblWd";
            this.lblWd.Size = new System.Drawing.Size(120, 22);
            this.lblWd.TabIndex = 1;
            this.lblWd.Text = "Wheel diameter";
            // 
            // cmbWidth
            // 
            this.cmbWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWidth.FormattingEnabled = true;
            this.cmbWidth.Location = new System.Drawing.Point(220, 81);
            this.cmbWidth.Margin = new System.Windows.Forms.Padding(0);
            this.cmbWidth.Name = "cmbWidth";
            this.cmbWidth.Size = new System.Drawing.Size(100, 26);
            this.cmbWidth.TabIndex = 2;
            this.cmbWidth.SelectedIndexChanged += new System.EventHandler(this.cmbWidth_IndexChange);
            // 
            // cmbPerc
            // 
            this.cmbPerc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerc.FormattingEnabled = true;
            this.cmbPerc.Location = new System.Drawing.Point(322, 81);
            this.cmbPerc.Margin = new System.Windows.Forms.Padding(0);
            this.cmbPerc.Name = "cmbPerc";
            this.cmbPerc.Size = new System.Drawing.Size(60, 26);
            this.cmbPerc.TabIndex = 3;
            this.cmbPerc.SelectedIndexChanged += new System.EventHandler(this.cmbPerc_IndexChange);
            // 
            // boxWtot
            // 
            this.boxWtot.Enabled = false;
            this.boxWtot.Location = new System.Drawing.Point(592, 81);
            this.boxWtot.Margin = new System.Windows.Forms.Padding(0);
            this.boxWtot.Name = "boxWtot";
            this.boxWtot.Size = new System.Drawing.Size(100, 26);
            this.boxWtot.TabIndex = 4;
            // 
            // lblWdRes
            // 
            this.lblWdRes.ForeColor = System.Drawing.SystemColors.Window;
            this.lblWdRes.Location = new System.Drawing.Point(432, 81);
            this.lblWdRes.Margin = new System.Windows.Forms.Padding(0);
            this.lblWdRes.Name = "lblWdRes";
            this.lblWdRes.Size = new System.Drawing.Size(160, 22);
            this.lblWdRes.TabIndex = 5;
            this.lblWdRes.Text = "Wheel total diameter";
            this.lblWdRes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGear
            // 
            this.lblGear.ForeColor = System.Drawing.SystemColors.Window;
            this.lblGear.Location = new System.Drawing.Point(16, 194);
            this.lblGear.Margin = new System.Windows.Forms.Padding(0);
            this.lblGear.Name = "lblGear";
            this.lblGear.Size = new System.Drawing.Size(120, 22);
            this.lblGear.TabIndex = 7;
            this.lblGear.Text = "Selected Gear";
            // 
            // cmbGearSelection
            // 
            this.cmbGearSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGearSelection.FormattingEnabled = true;
            this.cmbGearSelection.Location = new System.Drawing.Point(136, 192);
            this.cmbGearSelection.Margin = new System.Windows.Forms.Padding(0);
            this.cmbGearSelection.Name = "cmbGearSelection";
            this.cmbGearSelection.Size = new System.Drawing.Size(80, 26);
            this.cmbGearSelection.TabIndex = 6;
            this.cmbGearSelection.SelectedIndexChanged += new System.EventHandler(this.cmbGear_Change);
            // 
            // boxGear
            // 
            this.boxGear.Enabled = false;
            this.boxGear.Location = new System.Drawing.Point(218, 192);
            this.boxGear.Margin = new System.Windows.Forms.Padding(0);
            this.boxGear.Name = "boxGear";
            this.boxGear.Size = new System.Drawing.Size(100, 26);
            this.boxGear.TabIndex = 8;
            // 
            // lblFDrive
            // 
            this.lblFDrive.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFDrive.Location = new System.Drawing.Point(452, 147);
            this.lblFDrive.Margin = new System.Windows.Forms.Padding(0);
            this.lblFDrive.Name = "lblFDrive";
            this.lblFDrive.Size = new System.Drawing.Size(140, 22);
            this.lblFDrive.TabIndex = 10;
            this.lblFDrive.Text = "Final Drive Ratio";
            this.lblFDrive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // boxFDrive
            // 
            this.boxFDrive.Enabled = false;
            this.boxFDrive.Location = new System.Drawing.Point(592, 147);
            this.boxFDrive.Margin = new System.Windows.Forms.Padding(0);
            this.boxFDrive.Name = "boxFDrive";
            this.boxFDrive.Size = new System.Drawing.Size(100, 26);
            this.boxFDrive.TabIndex = 9;
            // 
            // lblCar
            // 
            this.lblCar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCar.Location = new System.Drawing.Point(16, 150);
            this.lblCar.Margin = new System.Windows.Forms.Padding(0);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(120, 22);
            this.lblCar.TabIndex = 11;
            this.lblCar.Text = "Select Car";
            // 
            // cmbCar
            // 
            this.cmbCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCar.FormattingEnabled = true;
            this.cmbCar.Location = new System.Drawing.Point(136, 147);
            this.cmbCar.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCar.Name = "cmbCar";
            this.cmbCar.Size = new System.Drawing.Size(182, 26);
            this.cmbCar.TabIndex = 12;
            this.cmbCar.SelectedIndexChanged += new System.EventHandler(this.cmbCar_Change);
            // 
            // Mainframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(704, 381);
            this.Controls.Add(this.cmbCar);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblFDrive);
            this.Controls.Add(this.boxFDrive);
            this.Controls.Add(this.boxGear);
            this.Controls.Add(this.lblGear);
            this.Controls.Add(this.cmbGearSelection);
            this.Controls.Add(this.lblWdRes);
            this.Controls.Add(this.boxWtot);
            this.Controls.Add(this.cmbPerc);
            this.Controls.Add(this.cmbWidth);
            this.Controls.Add(this.lblWd);
            this.Controls.Add(this.cmbDiam);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mainframe";
            this.Text = "Mainframe";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cmbCar;
        private System.Windows.Forms.Label lblGear;
        private System.Windows.Forms.ComboBox cmbGearSelection;
        private System.Windows.Forms.TextBox boxGear;
        private System.Windows.Forms.Label lblFDrive;
        private System.Windows.Forms.TextBox boxFDrive;
        private System.Windows.Forms.Label lblWdRes;
        private System.Windows.Forms.TextBox boxWtot;
        private System.Windows.Forms.ComboBox cmbDiam;
        private System.Windows.Forms.ComboBox cmbWidth;
        private System.Windows.Forms.ComboBox cmbPerc;
        private System.Windows.Forms.Label lblWd;
        #endregion
    }
}