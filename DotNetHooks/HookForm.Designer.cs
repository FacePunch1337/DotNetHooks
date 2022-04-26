
namespace DotNetHooks
{
    partial class HookForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageKeyboard = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNewKey = new System.Windows.Forms.TextBox();
            this.buttonAddReplace = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSourceKey = new System.Windows.Forms.TextBox();
            this.listBoxReplaces = new System.Windows.Forms.ListBox();
            this.buttonStopKb = new System.Windows.Forms.Button();
            this.richTextBoxKbDemo = new System.Windows.Forms.RichTextBox();
            this.buttonStartKb = new System.Windows.Forms.Button();
            this.richTextBoxKb = new System.Windows.Forms.RichTextBox();
            this.tabPageMouse = new System.Windows.Forms.TabPage();
            this.labelRes = new System.Windows.Forms.Label();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.buttonStopMs = new System.Windows.Forms.Button();
            this.buttonStartMs = new System.Windows.Forms.Button();
            this.listBoxMs = new System.Windows.Forms.ListBox();
            this.kbHookStatus = new System.Windows.Forms.Label();
            this.msHookStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageKeyboard.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageMouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageKeyboard);
            this.tabControl.Controls.Add(this.tabPageMouse);
            this.tabControl.Location = new System.Drawing.Point(301, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(487, 426);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageKeyboard
            // 
            this.tabPageKeyboard.Controls.Add(this.groupBox1);
            this.tabPageKeyboard.Controls.Add(this.buttonStopKb);
            this.tabPageKeyboard.Controls.Add(this.richTextBoxKbDemo);
            this.tabPageKeyboard.Controls.Add(this.buttonStartKb);
            this.tabPageKeyboard.Controls.Add(this.richTextBoxKb);
            this.tabPageKeyboard.Location = new System.Drawing.Point(4, 22);
            this.tabPageKeyboard.Name = "tabPageKeyboard";
            this.tabPageKeyboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKeyboard.Size = new System.Drawing.Size(479, 400);
            this.tabPageKeyboard.TabIndex = 0;
            this.tabPageKeyboard.Text = "Keyboard";
            this.tabPageKeyboard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNewKey);
            this.groupBox1.Controls.Add(this.buttonAddReplace);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSourceKey);
            this.groupBox1.Controls.Add(this.listBoxReplaces);
            this.groupBox1.Location = new System.Drawing.Point(6, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replaces";
            // 
            // textBoxNewKey
            // 
            this.textBoxNewKey.Location = new System.Drawing.Point(154, 139);
            this.textBoxNewKey.Name = "textBoxNewKey";
            this.textBoxNewKey.Size = new System.Drawing.Size(49, 20);
            this.textBoxNewKey.TabIndex = 5;
            this.textBoxNewKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNewKey_KeyDown);
            // 
            // buttonAddReplace
            // 
            this.buttonAddReplace.Location = new System.Drawing.Point(86, 158);
            this.buttonAddReplace.Name = "buttonAddReplace";
            this.buttonAddReplace.Size = new System.Drawing.Size(39, 22);
            this.buttonAddReplace.TabIndex = 4;
            this.buttonAddReplace.Text = "+";
            this.buttonAddReplace.UseVisualStyleBackColor = true;
            this.buttonAddReplace.Click += new System.EventHandler(this.buttonAddReplace_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "-->";
            // 
            // textBoxSourceKey
            // 
            this.textBoxSourceKey.Location = new System.Drawing.Point(7, 139);
            this.textBoxSourceKey.Name = "textBoxSourceKey";
            this.textBoxSourceKey.Size = new System.Drawing.Size(49, 20);
            this.textBoxSourceKey.TabIndex = 1;
            this.textBoxSourceKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSourceKey_KeyDown);
            // 
            // listBoxReplaces
            // 
            this.listBoxReplaces.FormattingEnabled = true;
            this.listBoxReplaces.Location = new System.Drawing.Point(7, 19);
            this.listBoxReplaces.Name = "listBoxReplaces";
            this.listBoxReplaces.Size = new System.Drawing.Size(196, 108);
            this.listBoxReplaces.TabIndex = 0;
            // 
            // buttonStopKb
            // 
            this.buttonStopKb.Location = new System.Drawing.Point(87, 6);
            this.buttonStopKb.Name = "buttonStopKb";
            this.buttonStopKb.Size = new System.Drawing.Size(75, 23);
            this.buttonStopKb.TabIndex = 2;
            this.buttonStopKb.Text = "Stop";
            this.buttonStopKb.UseVisualStyleBackColor = true;
            this.buttonStopKb.Click += new System.EventHandler(this.buttonStopKb_Click);
            // 
            // richTextBoxKbDemo
            // 
            this.richTextBoxKbDemo.Location = new System.Drawing.Point(227, 87);
            this.richTextBoxKbDemo.Name = "richTextBoxKbDemo";
            this.richTextBoxKbDemo.Size = new System.Drawing.Size(246, 130);
            this.richTextBoxKbDemo.TabIndex = 1;
            this.richTextBoxKbDemo.Text = "";
            // 
            // buttonStartKb
            // 
            this.buttonStartKb.Location = new System.Drawing.Point(6, 6);
            this.buttonStartKb.Name = "buttonStartKb";
            this.buttonStartKb.Size = new System.Drawing.Size(75, 23);
            this.buttonStartKb.TabIndex = 1;
            this.buttonStartKb.Text = "Start";
            this.buttonStartKb.UseVisualStyleBackColor = true;
            this.buttonStartKb.Click += new System.EventHandler(this.buttonStartKb_Click);
            // 
            // richTextBoxKb
            // 
            this.richTextBoxKb.Location = new System.Drawing.Point(227, 6);
            this.richTextBoxKb.Name = "richTextBoxKb";
            this.richTextBoxKb.Size = new System.Drawing.Size(246, 78);
            this.richTextBoxKb.TabIndex = 0;
            this.richTextBoxKb.Text = "";
            // 
            // tabPageMouse
            // 
            this.tabPageMouse.Controls.Add(this.labelRes);
            this.tabPageMouse.Controls.Add(this.panelDisplay);
            this.tabPageMouse.Controls.Add(this.buttonStopMs);
            this.tabPageMouse.Controls.Add(this.buttonStartMs);
            this.tabPageMouse.Controls.Add(this.listBoxMs);
            this.tabPageMouse.Location = new System.Drawing.Point(4, 22);
            this.tabPageMouse.Name = "tabPageMouse";
            this.tabPageMouse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMouse.Size = new System.Drawing.Size(479, 400);
            this.tabPageMouse.TabIndex = 1;
            this.tabPageMouse.Text = "Mouse";
            this.tabPageMouse.UseVisualStyleBackColor = true;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(206, 167);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(22, 13);
            this.labelRes.TabIndex = 5;
            this.labelRes.Text = "[...]";
            // 
            // panelDisplay
            // 
            this.panelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDisplay.Location = new System.Drawing.Point(209, 6);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(254, 147);
            this.panelDisplay.TabIndex = 5;
            // 
            // buttonStopMs
            // 
            this.buttonStopMs.Location = new System.Drawing.Point(6, 35);
            this.buttonStopMs.Name = "buttonStopMs";
            this.buttonStopMs.Size = new System.Drawing.Size(75, 23);
            this.buttonStopMs.TabIndex = 4;
            this.buttonStopMs.Text = "Stop";
            this.buttonStopMs.UseVisualStyleBackColor = true;
            this.buttonStopMs.Click += new System.EventHandler(this.buttonStopMs_Click);
            // 
            // buttonStartMs
            // 
            this.buttonStartMs.Location = new System.Drawing.Point(6, 6);
            this.buttonStartMs.Name = "buttonStartMs";
            this.buttonStartMs.Size = new System.Drawing.Size(75, 23);
            this.buttonStartMs.TabIndex = 3;
            this.buttonStartMs.Text = "Start";
            this.buttonStartMs.UseVisualStyleBackColor = true;
            this.buttonStartMs.Click += new System.EventHandler(this.buttonStartMs_Click);
            // 
            // listBoxMs
            // 
            this.listBoxMs.FormattingEnabled = true;
            this.listBoxMs.Location = new System.Drawing.Point(87, 6);
            this.listBoxMs.Name = "listBoxMs";
            this.listBoxMs.Size = new System.Drawing.Size(97, 147);
            this.listBoxMs.TabIndex = 0;
            // 
            // kbHookStatus
            // 
            this.kbHookStatus.AutoSize = true;
            this.kbHookStatus.ForeColor = System.Drawing.Color.Red;
            this.kbHookStatus.Location = new System.Drawing.Point(66, 34);
            this.kbHookStatus.Name = "kbHookStatus";
            this.kbHookStatus.Size = new System.Drawing.Size(57, 13);
            this.kbHookStatus.TabIndex = 1;
            this.kbHookStatus.Text = "non-active";
            // 
            // msHookStatus
            // 
            this.msHookStatus.AutoSize = true;
            this.msHookStatus.ForeColor = System.Drawing.Color.Red;
            this.msHookStatus.Location = new System.Drawing.Point(66, 69);
            this.msHookStatus.Name = "msHookStatus";
            this.msHookStatus.Size = new System.Drawing.Size(57, 13);
            this.msHookStatus.TabIndex = 2;
            this.msHookStatus.Text = "non-active";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Keyboard: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mouse: ";
            // 
            // HookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msHookStatus);
            this.Controls.Add(this.kbHookStatus);
            this.Controls.Add(this.tabControl);
            this.Name = "HookForm";
            this.Text = "HookForm";
            this.Load += new System.EventHandler(this.HookForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageKeyboard.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageMouse.ResumeLayout(false);
            this.tabPageMouse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageKeyboard;
        private System.Windows.Forms.TabPage tabPageMouse;
        private System.Windows.Forms.RichTextBox richTextBoxKb;
        private System.Windows.Forms.Button buttonStartKb;
        private System.Windows.Forms.Button buttonStopKb;
        private System.Windows.Forms.RichTextBox richTextBoxKbDemo;
        private System.Windows.Forms.Button buttonStopMs;
        private System.Windows.Forms.Button buttonStartMs;
        private System.Windows.Forms.ListBox listBoxMs;
        private System.Windows.Forms.Label kbHookStatus;
        private System.Windows.Forms.Label msHookStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNewKey;
        private System.Windows.Forms.Button buttonAddReplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSourceKey;
        private System.Windows.Forms.ListBox listBoxReplaces;
    }
}