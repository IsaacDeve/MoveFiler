namespace Zamestitel
{
    partial class App
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.main = new System.Windows.Forms.Button();
            this.BeforeFolder = new System.Windows.Forms.TextBox();
            this.AfterFolder = new System.Windows.Forms.TextBox();
            this.moveTo = new System.Windows.Forms.Label();
            this.MoveMessage = new System.Windows.Forms.CheckBox();
            this.build = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Move = new System.Windows.Forms.CheckedListBox();
            this.WhatToMove = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Meverything = new System.Windows.Forms.CheckBox();
            this.Mfolders = new System.Windows.Forms.CheckBox();
            this.Mzip = new System.Windows.Forms.CheckBox();
            this.M7z = new System.Windows.Forms.CheckBox();
            this.Mbat = new System.Windows.Forms.CheckBox();
            this.Mexe = new System.Windows.Forms.CheckBox();
            this.MRar = new System.Windows.Forms.CheckBox();
            this.Mtxt = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CusOne = new System.Windows.Forms.TextBox();
            this.CusTwo = new System.Windows.Forms.TextBox();
            this.CusThree = new System.Windows.Forms.TextBox();
            this.CusFour = new System.Windows.Forms.TextBox();
            this.CusOneCheck = new System.Windows.Forms.CheckBox();
            this.CusTwoCheck = new System.Windows.Forms.CheckBox();
            this.CusThreeCheck = new System.Windows.Forms.CheckBox();
            this.CusFourCheck = new System.Windows.Forms.CheckBox();
            this.Ext = new System.Windows.Forms.Label();
            this.Extt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Location = new System.Drawing.Point(12, 125);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(89, 50);
            this.main.TabIndex = 0;
            this.main.Text = "Move files from folder";
            this.main.UseVisualStyleBackColor = true;
            this.main.Click += new System.EventHandler(this.main_Click);
            // 
            // BeforeFolder
            // 
            this.BeforeFolder.Location = new System.Drawing.Point(13, 25);
            this.BeforeFolder.Name = "BeforeFolder";
            this.BeforeFolder.Size = new System.Drawing.Size(363, 20);
            this.BeforeFolder.TabIndex = 2;
            this.BeforeFolder.TextChanged += new System.EventHandler(this.BeforeFolder_TextChanged);
            // 
            // AfterFolder
            // 
            this.AfterFolder.Location = new System.Drawing.Point(13, 84);
            this.AfterFolder.Name = "AfterFolder";
            this.AfterFolder.Size = new System.Drawing.Size(363, 20);
            this.AfterFolder.TabIndex = 3;
            this.AfterFolder.TextChanged += new System.EventHandler(this.AfterFolder_TextChanged);
            // 
            // moveTo
            // 
            this.moveTo.AutoSize = true;
            this.moveTo.Location = new System.Drawing.Point(12, 58);
            this.moveTo.Name = "moveTo";
            this.moveTo.Size = new System.Drawing.Size(46, 13);
            this.moveTo.TabIndex = 4;
            this.moveTo.Text = "Move to";
            // 
            // MoveMessage
            // 
            this.MoveMessage.AutoSize = true;
            this.MoveMessage.Location = new System.Drawing.Point(191, 58);
            this.MoveMessage.Name = "MoveMessage";
            this.MoveMessage.Size = new System.Drawing.Size(185, 17);
            this.MoveMessage.TabIndex = 5;
            this.MoveMessage.Text = "Get a message about moving files";
            this.MoveMessage.UseVisualStyleBackColor = true;
            // 
            // build
            // 
            this.build.AutoSize = true;
            this.build.Location = new System.Drawing.Point(226, 107);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(47, 13);
            this.build.TabIndex = 6;
            this.build.Text = "build_v1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "can\'t transfer folders for now, this feature will be added in the next update";
            // 
            // Move
            // 
            this.Move.FormattingEnabled = true;
            this.Move.Location = new System.Drawing.Point(107, 125);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(269, 139);
            this.Move.TabIndex = 1;
            this.Move.SelectedIndexChanged += new System.EventHandler(this.Move_SelectedIndexChanged);
            // 
            // WhatToMove
            // 
            this.WhatToMove.AutoSize = true;
            this.WhatToMove.Location = new System.Drawing.Point(107, 110);
            this.WhatToMove.Name = "WhatToMove";
            this.WhatToMove.Size = new System.Drawing.Size(34, 13);
            this.WhatToMove.TabIndex = 8;
            this.WhatToMove.Text = "Move";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "From";
            // 
            // Meverything
            // 
            this.Meverything.AutoSize = true;
            this.Meverything.Location = new System.Drawing.Point(110, 127);
            this.Meverything.Name = "Meverything";
            this.Meverything.Size = new System.Drawing.Size(76, 17);
            this.Meverything.TabIndex = 10;
            this.Meverything.Text = "Everything";
            this.Meverything.UseVisualStyleBackColor = true;
            this.Meverything.CheckedChanged += new System.EventHandler(this.Meverything_CheckedChanged);
            // 
            // Mfolders
            // 
            this.Mfolders.AutoSize = true;
            this.Mfolders.Enabled = false;
            this.Mfolders.Location = new System.Drawing.Point(126, 143);
            this.Mfolders.Name = "Mfolders";
            this.Mfolders.Size = new System.Drawing.Size(60, 17);
            this.Mfolders.TabIndex = 11;
            this.Mfolders.Text = "Folders";
            this.Mfolders.UseVisualStyleBackColor = true;
            // 
            // Mzip
            // 
            this.Mzip.AutoSize = true;
            this.Mzip.Location = new System.Drawing.Point(126, 159);
            this.Mzip.Name = "Mzip";
            this.Mzip.Size = new System.Drawing.Size(43, 17);
            this.Mzip.TabIndex = 12;
            this.Mzip.Text = "ZIP";
            this.Mzip.UseVisualStyleBackColor = true;
            // 
            // M7z
            // 
            this.M7z.AutoSize = true;
            this.M7z.Location = new System.Drawing.Point(126, 175);
            this.M7z.Name = "M7z";
            this.M7z.Size = new System.Drawing.Size(37, 17);
            this.M7z.TabIndex = 13;
            this.M7z.Text = "7z";
            this.M7z.UseVisualStyleBackColor = true;
            // 
            // Mbat
            // 
            this.Mbat.AutoSize = true;
            this.Mbat.Location = new System.Drawing.Point(126, 220);
            this.Mbat.Name = "Mbat";
            this.Mbat.Size = new System.Drawing.Size(47, 17);
            this.Mbat.TabIndex = 16;
            this.Mbat.Text = "BAT";
            this.Mbat.UseVisualStyleBackColor = true;
            // 
            // Mexe
            // 
            this.Mexe.AutoSize = true;
            this.Mexe.Location = new System.Drawing.Point(126, 205);
            this.Mexe.Name = "Mexe";
            this.Mexe.Size = new System.Drawing.Size(47, 17);
            this.Mexe.TabIndex = 15;
            this.Mexe.Text = "EXE";
            this.Mexe.UseVisualStyleBackColor = true;
            // 
            // MRar
            // 
            this.MRar.AutoSize = true;
            this.MRar.Location = new System.Drawing.Point(126, 190);
            this.MRar.Name = "MRar";
            this.MRar.Size = new System.Drawing.Size(49, 17);
            this.MRar.TabIndex = 14;
            this.MRar.Text = "RAR";
            this.MRar.UseVisualStyleBackColor = true;
            // 
            // Mtxt
            // 
            this.Mtxt.AutoSize = true;
            this.Mtxt.Location = new System.Drawing.Point(126, 235);
            this.Mtxt.Name = "Mtxt";
            this.Mtxt.Size = new System.Drawing.Size(47, 17);
            this.Mtxt.TabIndex = 17;
            this.Mtxt.Text = "TXT";
            this.Mtxt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Made by IsaacDeve";
            // 
            // CusOne
            // 
            this.CusOne.Location = new System.Drawing.Point(295, 159);
            this.CusOne.Name = "CusOne";
            this.CusOne.Size = new System.Drawing.Size(68, 20);
            this.CusOne.TabIndex = 20;
            // 
            // CusTwo
            // 
            this.CusTwo.Location = new System.Drawing.Point(295, 185);
            this.CusTwo.Name = "CusTwo";
            this.CusTwo.Size = new System.Drawing.Size(68, 20);
            this.CusTwo.TabIndex = 21;
            // 
            // CusThree
            // 
            this.CusThree.Location = new System.Drawing.Point(295, 211);
            this.CusThree.Name = "CusThree";
            this.CusThree.Size = new System.Drawing.Size(68, 20);
            this.CusThree.TabIndex = 22;
            // 
            // CusFour
            // 
            this.CusFour.Location = new System.Drawing.Point(295, 238);
            this.CusFour.Name = "CusFour";
            this.CusFour.Size = new System.Drawing.Size(68, 20);
            this.CusFour.TabIndex = 23;
            // 
            // CusOneCheck
            // 
            this.CusOneCheck.AutoSize = true;
            this.CusOneCheck.Location = new System.Drawing.Point(274, 162);
            this.CusOneCheck.Name = "CusOneCheck";
            this.CusOneCheck.Size = new System.Drawing.Size(15, 14);
            this.CusOneCheck.TabIndex = 24;
            this.CusOneCheck.UseVisualStyleBackColor = true;
            // 
            // CusTwoCheck
            // 
            this.CusTwoCheck.AutoSize = true;
            this.CusTwoCheck.Location = new System.Drawing.Point(274, 188);
            this.CusTwoCheck.Name = "CusTwoCheck";
            this.CusTwoCheck.Size = new System.Drawing.Size(15, 14);
            this.CusTwoCheck.TabIndex = 25;
            this.CusTwoCheck.UseVisualStyleBackColor = true;
            // 
            // CusThreeCheck
            // 
            this.CusThreeCheck.AutoSize = true;
            this.CusThreeCheck.Location = new System.Drawing.Point(274, 214);
            this.CusThreeCheck.Name = "CusThreeCheck";
            this.CusThreeCheck.Size = new System.Drawing.Size(15, 14);
            this.CusThreeCheck.TabIndex = 26;
            this.CusThreeCheck.UseVisualStyleBackColor = true;
            // 
            // CusFourCheck
            // 
            this.CusFourCheck.AutoSize = true;
            this.CusFourCheck.Location = new System.Drawing.Point(274, 241);
            this.CusFourCheck.Name = "CusFourCheck";
            this.CusFourCheck.Size = new System.Drawing.Size(15, 14);
            this.CusFourCheck.TabIndex = 27;
            this.CusFourCheck.UseVisualStyleBackColor = true;
            // 
            // Ext
            // 
            this.Ext.AutoSize = true;
            this.Ext.Location = new System.Drawing.Point(263, 131);
            this.Ext.Name = "Ext";
            this.Ext.Size = new System.Drawing.Size(100, 13);
            this.Ext.TabIndex = 28;
            this.Ext.Text = "Your own extension";
            // 
            // Extt
            // 
            this.Extt.AutoSize = true;
            this.Extt.Location = new System.Drawing.Point(271, 144);
            this.Extt.Name = "Extt";
            this.Extt.Size = new System.Drawing.Size(92, 13);
            this.Extt.TabIndex = 29;
            this.Extt.Text = "Examples: ico, jpg";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 285);
            this.Controls.Add(this.Extt);
            this.Controls.Add(this.Ext);
            this.Controls.Add(this.CusFourCheck);
            this.Controls.Add(this.CusThreeCheck);
            this.Controls.Add(this.CusTwoCheck);
            this.Controls.Add(this.CusOneCheck);
            this.Controls.Add(this.CusFour);
            this.Controls.Add(this.CusThree);
            this.Controls.Add(this.CusTwo);
            this.Controls.Add(this.CusOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mtxt);
            this.Controls.Add(this.Mbat);
            this.Controls.Add(this.Mexe);
            this.Controls.Add(this.MRar);
            this.Controls.Add(this.M7z);
            this.Controls.Add(this.Mzip);
            this.Controls.Add(this.Mfolders);
            this.Controls.Add(this.Meverything);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WhatToMove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.build);
            this.Controls.Add(this.MoveMessage);
            this.Controls.Add(this.moveTo);
            this.Controls.Add(this.AfterFolder);
            this.Controls.Add(this.BeforeFolder);
            this.Controls.Add(this.Move);
            this.Controls.Add(this.main);
            this.Name = "App";
            this.Text = "MoveFiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button main;
        private System.Windows.Forms.TextBox BeforeFolder;
        private System.Windows.Forms.TextBox AfterFolder;
        private System.Windows.Forms.Label moveTo;
        private System.Windows.Forms.CheckBox MoveMessage;
        private System.Windows.Forms.Label build;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox Move;
        private System.Windows.Forms.Label WhatToMove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Meverything;
        private System.Windows.Forms.CheckBox Mfolders;
        private System.Windows.Forms.CheckBox Mzip;
        private System.Windows.Forms.CheckBox M7z;
        private System.Windows.Forms.CheckBox Mbat;
        private System.Windows.Forms.CheckBox Mexe;
        private System.Windows.Forms.CheckBox MRar;
        private System.Windows.Forms.CheckBox Mtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CusOne;
        private System.Windows.Forms.TextBox CusTwo;
        private System.Windows.Forms.TextBox CusThree;
        private System.Windows.Forms.TextBox CusFour;
        private System.Windows.Forms.CheckBox CusOneCheck;
        private System.Windows.Forms.CheckBox CusTwoCheck;
        private System.Windows.Forms.CheckBox CusThreeCheck;
        private System.Windows.Forms.CheckBox CusFourCheck;
        private System.Windows.Forms.Label Ext;
        private System.Windows.Forms.Label Extt;
    }
}

