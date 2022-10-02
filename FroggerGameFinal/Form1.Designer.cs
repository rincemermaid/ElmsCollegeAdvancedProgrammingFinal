namespace FroggerGameFinal
{
    partial class Frogger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frogger));
            this.frogtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            
            // 
            // frogtimer
            // 
            this.frogtimer.Enabled = true;
            this.frogtimer.Tick += new System.EventHandler(this.frogtimer_Tick);
            // 
            // Frogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2224, 1382);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2250, 1442);
            this.MinimumSize = new System.Drawing.Size(2250, 1442);
            this.Name = "Frogger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Frogger";
            this.Load += new System.EventHandler(this.Frogger_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.move_frog);
            this.ResumeLayout(false);

        }

        #endregion

    
        private System.Windows.Forms.Timer frogtimer;
        
    }
}

