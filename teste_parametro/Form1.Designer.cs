namespace teste_parametro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_teste = new Button();
            SuspendLayout();
            // 
            // bt_teste
            // 
            bt_teste.Location = new Point(282, 245);
            bt_teste.Name = "bt_teste";
            bt_teste.Size = new Size(164, 34);
            bt_teste.TabIndex = 0;
            bt_teste.Text = "texto qualquer";
            bt_teste.UseVisualStyleBackColor = true;
            bt_teste.Click += bt_teste_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_teste);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bt_teste;
    }
}
