namespace EingabeAusgabe
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdLotto = new System.Windows.Forms.Button();
            this.cmdMsgBoxInformation = new System.Windows.Forms.Button();
            this.cmdMsgBoxRetryCancel = new System.Windows.Forms.Button();
            this.cmdMsgBoxAbortRetryIgnore = new System.Windows.Forms.Button();
            this.cmdMsgBoxYesNoCancel = new System.Windows.Forms.Button();
            this.cmdMsgBoxYesNo = new System.Windows.Forms.Button();
            this.cmdMsgBoxOkOnly = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.cmdInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdLotto
            // 
            this.cmdLotto.Location = new System.Drawing.Point(152, 48);
            this.cmdLotto.Name = "cmdLotto";
            this.cmdLotto.Size = new System.Drawing.Size(120, 23);
            this.cmdLotto.TabIndex = 43;
            this.cmdLotto.Text = "Lotto";
            this.cmdLotto.UseVisualStyleBackColor = true;
            this.cmdLotto.Click += new System.EventHandler(this.cmdLotto_Click);
            // 
            // cmdMsgBoxInformation
            // 
            this.cmdMsgBoxInformation.Location = new System.Drawing.Point(12, 135);
            this.cmdMsgBoxInformation.Name = "cmdMsgBoxInformation";
            this.cmdMsgBoxInformation.Size = new System.Drawing.Size(120, 23);
            this.cmdMsgBoxInformation.TabIndex = 42;
            this.cmdMsgBoxInformation.Text = "Information";
            this.cmdMsgBoxInformation.UseVisualStyleBackColor = true;
            this.cmdMsgBoxInformation.Click += new System.EventHandler(this.cmdMsgBoxInformation_Click);
            // 
            // cmdMsgBoxRetryCancel
            // 
            this.cmdMsgBoxRetryCancel.Location = new System.Drawing.Point(152, 164);
            this.cmdMsgBoxRetryCancel.Name = "cmdMsgBoxRetryCancel";
            this.cmdMsgBoxRetryCancel.Size = new System.Drawing.Size(120, 23);
            this.cmdMsgBoxRetryCancel.TabIndex = 41;
            this.cmdMsgBoxRetryCancel.Text = "Retry Cancel";
            this.cmdMsgBoxRetryCancel.UseVisualStyleBackColor = true;
            this.cmdMsgBoxRetryCancel.Click += new System.EventHandler(this.cmdMsgBoxRetryCancel_Click);
            // 
            // cmdMsgBoxAbortRetryIgnore
            // 
            this.cmdMsgBoxAbortRetryIgnore.Location = new System.Drawing.Point(152, 193);
            this.cmdMsgBoxAbortRetryIgnore.Name = "cmdMsgBoxAbortRetryIgnore";
            this.cmdMsgBoxAbortRetryIgnore.Size = new System.Drawing.Size(120, 23);
            this.cmdMsgBoxAbortRetryIgnore.TabIndex = 40;
            this.cmdMsgBoxAbortRetryIgnore.Text = "Abort Retry Ignore";
            this.cmdMsgBoxAbortRetryIgnore.UseVisualStyleBackColor = true;
            this.cmdMsgBoxAbortRetryIgnore.Click += new System.EventHandler(this.cmdMsgBoxAbortRetryIgnore_Click);
            // 
            // cmdMsgBoxYesNoCancel
            // 
            this.cmdMsgBoxYesNoCancel.Location = new System.Drawing.Point(152, 135);
            this.cmdMsgBoxYesNoCancel.Name = "cmdMsgBoxYesNoCancel";
            this.cmdMsgBoxYesNoCancel.Size = new System.Drawing.Size(120, 23);
            this.cmdMsgBoxYesNoCancel.TabIndex = 39;
            this.cmdMsgBoxYesNoCancel.Text = "Yes No Cancel";
            this.cmdMsgBoxYesNoCancel.UseVisualStyleBackColor = true;
            this.cmdMsgBoxYesNoCancel.Click += new System.EventHandler(this.cmdMsgBoxYesNoCancel_Click);
            // 
            // cmdMsgBoxYesNo
            // 
            this.cmdMsgBoxYesNo.Location = new System.Drawing.Point(152, 106);
            this.cmdMsgBoxYesNo.Name = "cmdMsgBoxYesNo";
            this.cmdMsgBoxYesNo.Size = new System.Drawing.Size(120, 23);
            this.cmdMsgBoxYesNo.TabIndex = 38;
            this.cmdMsgBoxYesNo.Text = "Yes No";
            this.cmdMsgBoxYesNo.UseVisualStyleBackColor = true;
            this.cmdMsgBoxYesNo.Click += new System.EventHandler(this.cmdMsgBoxYesNo_Click);
            // 
            // cmdMsgBoxOkOnly
            // 
            this.cmdMsgBoxOkOnly.Location = new System.Drawing.Point(12, 106);
            this.cmdMsgBoxOkOnly.Name = "cmdMsgBoxOkOnly";
            this.cmdMsgBoxOkOnly.Size = new System.Drawing.Size(120, 23);
            this.cmdMsgBoxOkOnly.TabIndex = 37;
            this.cmdMsgBoxOkOnly.Text = "Ok";
            this.cmdMsgBoxOkOnly.UseVisualStyleBackColor = true;
            this.cmdMsgBoxOkOnly.Click += new System.EventHandler(this.cmdMsgBoxOkOnly_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 12);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 36;
            // 
            // cmdInput
            // 
            this.cmdInput.Location = new System.Drawing.Point(12, 48);
            this.cmdInput.Name = "cmdInput";
            this.cmdInput.Size = new System.Drawing.Size(120, 23);
            this.cmdInput.TabIndex = 35;
            this.cmdInput.Text = "Input";
            this.cmdInput.UseVisualStyleBackColor = true;
            this.cmdInput.Click += new System.EventHandler(this.cmdInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdLotto);
            this.Controls.Add(this.cmdMsgBoxInformation);
            this.Controls.Add(this.cmdMsgBoxRetryCancel);
            this.Controls.Add(this.cmdMsgBoxAbortRetryIgnore);
            this.Controls.Add(this.cmdMsgBoxYesNoCancel);
            this.Controls.Add(this.cmdMsgBoxYesNo);
            this.Controls.Add(this.cmdMsgBoxOkOnly);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmdInput);
            this.Name = "Form1";
            this.Text = "Eingabe und Ausgabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdLotto;
        internal System.Windows.Forms.Button cmdMsgBoxInformation;
        internal System.Windows.Forms.Button cmdMsgBoxRetryCancel;
        internal System.Windows.Forms.Button cmdMsgBoxAbortRetryIgnore;
        internal System.Windows.Forms.Button cmdMsgBoxYesNoCancel;
        internal System.Windows.Forms.Button cmdMsgBoxYesNo;
        internal System.Windows.Forms.Button cmdMsgBoxOkOnly;
        internal System.Windows.Forms.Label lblA;
        internal System.Windows.Forms.Button cmdInput;
    }
}

