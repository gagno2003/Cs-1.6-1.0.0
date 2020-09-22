namespace cs1._6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FireArms = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Awp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Player1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Player2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Player1selected = new System.Windows.Forms.Label();
            this.Player2selected = new System.Windows.Forms.Label();
            this.Versus = new System.Windows.Forms.Label();
            this.FireArmWeaponsMenu = new cs1._6.FireArmsMenu();
            this.AwpWeaponsMenu = new cs1._6.AwpMenu();
            this.SuspendLayout();
            // 
            // FireArms
            // 
            this.FireArms.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(10)))));
            this.FireArms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.FireArms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FireArms.BorderRadius = 0;
            this.FireArms.ButtonText = "FireArms";
            this.FireArms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FireArms.DisabledColor = System.Drawing.Color.Gray;
            this.FireArms.Iconcolor = System.Drawing.Color.Transparent;
            this.FireArms.Iconimage = null;
            this.FireArms.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("FireArms.Iconimage_right")));
            this.FireArms.Iconimage_right_Selected = null;
            this.FireArms.Iconimage_Selected = null;
            this.FireArms.IconMarginLeft = 64;
            this.FireArms.IconMarginRight = 0;
            this.FireArms.IconRightVisible = true;
            this.FireArms.IconRightZoom = 0D;
            this.FireArms.IconVisible = true;
            this.FireArms.IconZoom = 40D;
            this.FireArms.IsTab = false;
            this.FireArms.Location = new System.Drawing.Point(12, 39);
            this.FireArms.Name = "FireArms";
            this.FireArms.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.FireArms.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(10)))));
            this.FireArms.OnHoverTextColor = System.Drawing.Color.White;
            this.FireArms.selected = false;
            this.FireArms.Size = new System.Drawing.Size(180, 28);
            this.FireArms.TabIndex = 0;
            this.FireArms.Text = "FireArms";
            this.FireArms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FireArms.Textcolor = System.Drawing.Color.White;
            this.FireArms.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireArms.Click += new System.EventHandler(this.FireArms_Click);
            // 
            // Awp
            // 
            this.Awp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(10)))));
            this.Awp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.Awp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Awp.BorderRadius = 0;
            this.Awp.ButtonText = "Awp";
            this.Awp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Awp.DisabledColor = System.Drawing.Color.Gray;
            this.Awp.Iconcolor = System.Drawing.Color.Transparent;
            this.Awp.Iconimage = null;
            this.Awp.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("Awp.Iconimage_right")));
            this.Awp.Iconimage_right_Selected = null;
            this.Awp.Iconimage_Selected = null;
            this.Awp.IconMarginLeft = 75;
            this.Awp.IconMarginRight = 0;
            this.Awp.IconRightVisible = true;
            this.Awp.IconRightZoom = 0D;
            this.Awp.IconVisible = true;
            this.Awp.IconZoom = 40D;
            this.Awp.IsTab = false;
            this.Awp.Location = new System.Drawing.Point(12, 73);
            this.Awp.Name = "Awp";
            this.Awp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.Awp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(10)))));
            this.Awp.OnHoverTextColor = System.Drawing.Color.White;
            this.Awp.selected = false;
            this.Awp.Size = new System.Drawing.Size(180, 28);
            this.Awp.TabIndex = 2;
            this.Awp.Text = "Awp";
            this.Awp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Awp.Textcolor = System.Drawing.Color.White;
            this.Awp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Awp.Click += new System.EventHandler(this.Awp_Click);
            // 
            // Player1
            // 
            this.Player1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(10)))));
            this.Player1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.Player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player1.BorderRadius = 0;
            this.Player1.ButtonText = "Player I";
            this.Player1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Player1.DisabledColor = System.Drawing.Color.Gray;
            this.Player1.Iconcolor = System.Drawing.Color.Transparent;
            this.Player1.Iconimage = ((System.Drawing.Image)(resources.GetObject("Player1.Iconimage")));
            this.Player1.Iconimage_right = null;
            this.Player1.Iconimage_right_Selected = null;
            this.Player1.Iconimage_Selected = null;
            this.Player1.IconMarginLeft = 0;
            this.Player1.IconMarginRight = 0;
            this.Player1.IconRightVisible = true;
            this.Player1.IconRightZoom = 0D;
            this.Player1.IconVisible = true;
            this.Player1.IconZoom = 50D;
            this.Player1.IsTab = false;
            this.Player1.Location = new System.Drawing.Point(12, 358);
            this.Player1.Name = "Player1";
            this.Player1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.Player1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(10)))));
            this.Player1.OnHoverTextColor = System.Drawing.Color.White;
            this.Player1.selected = false;
            this.Player1.Size = new System.Drawing.Size(180, 28);
            this.Player1.TabIndex = 4;
            this.Player1.Text = "Player I";
            this.Player1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Player1.Textcolor = System.Drawing.Color.White;
            this.Player1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Click += new System.EventHandler(this.Player1_Click);
            // 
            // Player2
            // 
            this.Player2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(10)))));
            this.Player2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.Player2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player2.BorderRadius = 0;
            this.Player2.ButtonText = "Player II";
            this.Player2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Player2.DisabledColor = System.Drawing.Color.Gray;
            this.Player2.Iconcolor = System.Drawing.Color.Transparent;
            this.Player2.Iconimage = ((System.Drawing.Image)(resources.GetObject("Player2.Iconimage")));
            this.Player2.Iconimage_right = null;
            this.Player2.Iconimage_right_Selected = null;
            this.Player2.Iconimage_Selected = null;
            this.Player2.IconMarginLeft = 0;
            this.Player2.IconMarginRight = 0;
            this.Player2.IconRightVisible = true;
            this.Player2.IconRightZoom = 0D;
            this.Player2.IconVisible = true;
            this.Player2.IconZoom = 50D;
            this.Player2.IsTab = false;
            this.Player2.Location = new System.Drawing.Point(317, 358);
            this.Player2.Name = "Player2";
            this.Player2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.Player2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(10)))));
            this.Player2.OnHoverTextColor = System.Drawing.Color.White;
            this.Player2.selected = false;
            this.Player2.Size = new System.Drawing.Size(180, 28);
            this.Player2.TabIndex = 5;
            this.Player2.Text = "Player II";
            this.Player2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Player2.Textcolor = System.Drawing.Color.White;
            this.Player2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.Click += new System.EventHandler(this.Player2_Click);
            // 
            // Player1selected
            // 
            this.Player1selected.AutoSize = true;
            this.Player1selected.BackColor = System.Drawing.Color.Transparent;
            this.Player1selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1selected.ForeColor = System.Drawing.Color.White;
            this.Player1selected.Location = new System.Drawing.Point(6, 389);
            this.Player1selected.Name = "Player1selected";
            this.Player1selected.Size = new System.Drawing.Size(0, 31);
            this.Player1selected.TabIndex = 6;
            // 
            // Player2selected
            // 
            this.Player2selected.AutoSize = true;
            this.Player2selected.BackColor = System.Drawing.Color.Transparent;
            this.Player2selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2selected.ForeColor = System.Drawing.Color.White;
            this.Player2selected.Location = new System.Drawing.Point(311, 389);
            this.Player2selected.Name = "Player2selected";
            this.Player2selected.Size = new System.Drawing.Size(0, 31);
            this.Player2selected.TabIndex = 7;
            // 
            // Versus
            // 
            this.Versus.AutoSize = true;
            this.Versus.BackColor = System.Drawing.Color.Transparent;
            this.Versus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Versus.ForeColor = System.Drawing.Color.White;
            this.Versus.Location = new System.Drawing.Point(230, 358);
            this.Versus.Name = "Versus";
            this.Versus.Size = new System.Drawing.Size(50, 31);
            this.Versus.TabIndex = 8;
            this.Versus.Text = "VS";
            this.Versus.Click += new System.EventHandler(this.Versus_Click);
            // 
            // FireArmWeaponsMenu
            // 
            this.FireArmWeaponsMenu.BackColor = System.Drawing.Color.Transparent;
            this.FireArmWeaponsMenu.Location = new System.Drawing.Point(284, 110);
            this.FireArmWeaponsMenu.Name = "FireArmWeaponsMenu";
            this.FireArmWeaponsMenu.Size = new System.Drawing.Size(213, 141);
            this.FireArmWeaponsMenu.TabIndex = 1;
            // 
            // AwpWeaponsMenu
            // 
            this.AwpWeaponsMenu.BackColor = System.Drawing.Color.Transparent;
            this.AwpWeaponsMenu.Location = new System.Drawing.Point(284, 110);
            this.AwpWeaponsMenu.Name = "AwpWeaponsMenu";
            this.AwpWeaponsMenu.Size = new System.Drawing.Size(213, 158);
            this.AwpWeaponsMenu.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(509, 449);
            this.Controls.Add(this.AwpWeaponsMenu);
            this.Controls.Add(this.Versus);
            this.Controls.Add(this.Player2selected);
            this.Controls.Add(this.Player1selected);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Awp);
            this.Controls.Add(this.FireArmWeaponsMenu);
            this.Controls.Add(this.FireArms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cs 1.6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton FireArms;
        private FireArmsMenu FireArmWeaponsMenu;
        private Bunifu.Framework.UI.BunifuFlatButton Awp;
        private Bunifu.Framework.UI.BunifuFlatButton Player1;
        private Bunifu.Framework.UI.BunifuFlatButton Player2;
        private System.Windows.Forms.Label Player1selected;
        private System.Windows.Forms.Label Player2selected;
        private System.Windows.Forms.Label Versus;
        private AwpMenu AwpWeaponsMenu;
    }
}

