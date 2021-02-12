namespace nortwind.Folderek
{
    partial class Produkty
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
            this.categoriesTableAdapter1 = new nortwind.NORTHWNDDataSetTableAdapters.CategoriesTableAdapter();
            this.regionTableAdapter1 = new nortwind.NORTHWNDDataSetTableAdapters.RegionTableAdapter();
            this.SuspendLayout();
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // regionTableAdapter1
            // 
            this.regionTableAdapter1.ClearBeforeFill = true;
            // 
            // Produkty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Produkty";
            this.Text = "Produkty";
            this.ResumeLayout(false);

        }

        #endregion

        private NORTHWNDDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private NORTHWNDDataSetTableAdapters.RegionTableAdapter regionTableAdapter1;
    }
}