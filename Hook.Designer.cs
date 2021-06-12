
namespace GHook
{
    partial class Ghook
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
            this.btnSpoof = new System.Windows.Forms.Button();
            this.ProcessHook = new System.Windows.Forms.TextBox();
            this.ProcessClient = new System.Windows.Forms.TextBox();
            this.HideProcess = new System.Windows.Forms.Button();
            this.HookButton = new System.Windows.Forms.Button();
            this.NewTitle = new System.Windows.Forms.TextBox();
            this.btnParentBrowse = new System.Windows.Forms.Button();
            this.btnChildBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpoof
            // 
            this.btnSpoof.Location = new System.Drawing.Point(12, 70);
            this.btnSpoof.Name = "btnSpoof";
            this.btnSpoof.Size = new System.Drawing.Size(100, 23);
            this.btnSpoof.TabIndex = 1;
            this.btnSpoof.Text = "Spoof";
            this.btnSpoof.UseVisualStyleBackColor = true;
            this.btnSpoof.Click += new System.EventHandler(this.BtnSpoof_Click);
            // 
            // ProcessHook
            // 
            this.ProcessHook.Location = new System.Drawing.Point(118, 14);
            this.ProcessHook.Name = "ProcessHook";
            this.ProcessHook.Size = new System.Drawing.Size(186, 20);
            this.ProcessHook.TabIndex = 2;
            // 
            // ProcessClient
            // 
            this.ProcessClient.Location = new System.Drawing.Point(118, 43);
            this.ProcessClient.Name = "ProcessClient";
            this.ProcessClient.Size = new System.Drawing.Size(186, 20);
            this.ProcessClient.TabIndex = 3;
            // 
            // HideProcess
            // 
            this.HideProcess.Location = new System.Drawing.Point(12, 41);
            this.HideProcess.Name = "HideProcess";
            this.HideProcess.Size = new System.Drawing.Size(100, 23);
            this.HideProcess.TabIndex = 4;
            this.HideProcess.Text = "Hide Process";
            this.HideProcess.UseVisualStyleBackColor = true;
            this.HideProcess.Click += new System.EventHandler(this.HideProcess_Click);
            // 
            // HookButton
            // 
            this.HookButton.Location = new System.Drawing.Point(12, 12);
            this.HookButton.Name = "HookButton";
            this.HookButton.Size = new System.Drawing.Size(100, 23);
            this.HookButton.TabIndex = 5;
            this.HookButton.Text = "Hook";
            this.HookButton.UseVisualStyleBackColor = true;
            this.HookButton.Click += new System.EventHandler(this.Hook_Click);
            // 
            // NewTitle
            // 
            this.NewTitle.Location = new System.Drawing.Point(118, 72);
            this.NewTitle.Name = "NewTitle";
            this.NewTitle.Size = new System.Drawing.Size(186, 20);
            this.NewTitle.TabIndex = 6;
            // 
            // btnParentBrowse
            // 
            this.btnParentBrowse.Location = new System.Drawing.Point(310, 14);
            this.btnParentBrowse.Name = "btnParentBrowse";
            this.btnParentBrowse.Size = new System.Drawing.Size(24, 23);
            this.btnParentBrowse.TabIndex = 7;
            this.btnParentBrowse.Text = "...";
            this.btnParentBrowse.UseVisualStyleBackColor = true;
            this.btnParentBrowse.Click += new System.EventHandler(this.BtnParentBrowse_Click);
            // 
            // btnChildBrowse
            // 
            this.btnChildBrowse.Location = new System.Drawing.Point(310, 41);
            this.btnChildBrowse.Name = "btnChildBrowse";
            this.btnChildBrowse.Size = new System.Drawing.Size(24, 23);
            this.btnChildBrowse.TabIndex = 8;
            this.btnChildBrowse.Text = "...";
            this.btnChildBrowse.UseVisualStyleBackColor = true;
            this.btnChildBrowse.Click += new System.EventHandler(this.BtnChildBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 105);
            this.Controls.Add(this.btnChildBrowse);
            this.Controls.Add(this.btnParentBrowse);
            this.Controls.Add(this.NewTitle);
            this.Controls.Add(this.HookButton);
            this.Controls.Add(this.HideProcess);
            this.Controls.Add(this.ProcessClient);
            this.Controls.Add(this.ProcessHook);
            this.Controls.Add(this.btnSpoof);
            this.Name = "Form1";
            this.Text = "GHook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSpoof;
        private System.Windows.Forms.TextBox ProcessHook;
        private System.Windows.Forms.TextBox ProcessClient;
        private System.Windows.Forms.Button HideProcess;
        private System.Windows.Forms.Button HookButton;
        private System.Windows.Forms.TextBox NewTitle;
        private System.Windows.Forms.Button btnParentBrowse;
        private System.Windows.Forms.Button btnChildBrowse;
    }
}

