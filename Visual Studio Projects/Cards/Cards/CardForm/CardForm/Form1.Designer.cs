namespace CardForm
{
    partial class CardGeneratorIndex
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
            this.title = new System.Windows.Forms.Label();
            this.generateDeck = new System.Windows.Forms.Button();
            this.Organize = new System.Windows.Forms.Button();
            this.chooseDeck = new System.Windows.Forms.CheckedListBox();
            this.blackPanel = new System.Windows.Forms.Panel();
            this.redPanel = new System.Windows.Forms.Panel();
            this.textWindow = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.Database = new System.Windows.Forms.Button();
            this.HandDeck = new System.Windows.Forms.Button();
            this.HandCard = new System.Windows.Forms.Button();
            this.HandHalf = new System.Windows.Forms.Button();
            this.HandWhole = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(701, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(213, 34);
            this.title.TabIndex = 0;
            this.title.Text = "Card Generator";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // generateDeck
            // 
            this.generateDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateDeck.Location = new System.Drawing.Point(701, 381);
            this.generateDeck.Name = "generateDeck";
            this.generateDeck.Size = new System.Drawing.Size(166, 61);
            this.generateDeck.TabIndex = 1;
            this.generateDeck.Text = "Generate Deck of Cards";
            this.generateDeck.UseVisualStyleBackColor = true;
            this.generateDeck.Click += new System.EventHandler(this.generateDeck_Click);
            // 
            // Organize
            // 
            this.Organize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Organize.Location = new System.Drawing.Point(869, 408);
            this.Organize.Name = "Organize";
            this.Organize.Size = new System.Drawing.Size(150, 34);
            this.Organize.TabIndex = 2;
            this.Organize.Text = "Delete History";
            this.Organize.UseVisualStyleBackColor = true;
            this.Organize.Click += new System.EventHandler(this.missingCard_Click);
            // 
            // chooseDeck
            // 
            this.chooseDeck.BackColor = System.Drawing.SystemColors.Control;
            this.chooseDeck.CheckOnClick = true;
            this.chooseDeck.FormattingEnabled = true;
            this.chooseDeck.Items.AddRange(new object[] {
            "With Jokers",
            "Only two Types",
            "No Picture Cards"});
            this.chooseDeck.Location = new System.Drawing.Point(464, 381);
            this.chooseDeck.Name = "chooseDeck";
            this.chooseDeck.Size = new System.Drawing.Size(142, 72);
            this.chooseDeck.TabIndex = 3;
            this.chooseDeck.SelectedIndexChanged += new System.EventHandler(this.chooseDeck_SelectedIndexChanged);
            // 
            // blackPanel
            // 
            this.blackPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blackPanel.Location = new System.Drawing.Point(-1, 0);
            this.blackPanel.Name = "blackPanel";
            this.blackPanel.Size = new System.Drawing.Size(86, 450);
            this.blackPanel.TabIndex = 4;
            // 
            // redPanel
            // 
            this.redPanel.BackColor = System.Drawing.Color.Red;
            this.redPanel.Location = new System.Drawing.Point(1551, 0);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(86, 459);
            this.redPanel.TabIndex = 5;
            // 
            // textWindow
            // 
            this.textWindow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textWindow.Location = new System.Drawing.Point(91, 238);
            this.textWindow.Multiline = true;
            this.textWindow.Name = "textWindow";
            this.textWindow.Size = new System.Drawing.Size(1404, 137);
            this.textWindow.TabIndex = 7;
            this.textWindow.TextChanged += new System.EventHandler(this.textWindow_TextChanged);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(1025, 412);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(57, 31);
            this.exit.TabIndex = 8;
            this.exit.Text = "Close";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Database
            // 
            this.Database.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Database.Location = new System.Drawing.Point(869, 381);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(213, 34);
            this.Database.TabIndex = 9;
            this.Database.Text = "Send to Database";
            this.Database.UseVisualStyleBackColor = true;
            this.Database.Click += new System.EventHandler(this.Database_Click);
            // 
            // HandDeck
            // 
            this.HandDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandDeck.Location = new System.Drawing.Point(612, 379);
            this.HandDeck.Name = "HandDeck";
            this.HandDeck.Size = new System.Drawing.Size(30, 34);
            this.HandDeck.TabIndex = 10;
            this.HandDeck.Text = "7";
            this.HandDeck.UseVisualStyleBackColor = true;
            this.HandDeck.Click += new System.EventHandler(this.HandDeck_Click);
            // 
            // HandCard
            // 
            this.HandCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandCard.Location = new System.Drawing.Point(639, 379);
            this.HandCard.Name = "HandCard";
            this.HandCard.Size = new System.Drawing.Size(32, 34);
            this.HandCard.TabIndex = 11;
            this.HandCard.Text = "1";
            this.HandCard.UseVisualStyleBackColor = true;
            this.HandCard.Click += new System.EventHandler(this.HandCard_Click);
            // 
            // HandHalf
            // 
            this.HandHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandHalf.Location = new System.Drawing.Point(612, 412);
            this.HandHalf.Name = "HandHalf";
            this.HandHalf.Size = new System.Drawing.Size(45, 34);
            this.HandHalf.TabIndex = 12;
            this.HandHalf.Text = "26";
            this.HandHalf.UseVisualStyleBackColor = true;
            this.HandHalf.Click += new System.EventHandler(this.HandHalf_Click);
            // 
            // HandWhole
            // 
            this.HandWhole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandWhole.Location = new System.Drawing.Point(654, 412);
            this.HandWhole.Name = "HandWhole";
            this.HandWhole.Size = new System.Drawing.Size(46, 34);
            this.HandWhole.TabIndex = 13;
            this.HandWhole.Text = "52";
            this.HandWhole.UseVisualStyleBackColor = true;
            this.HandWhole.Click += new System.EventHandler(this.HandWhole_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(668, 379);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(32, 34);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "R";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // CardGeneratorIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 450);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.HandWhole);
            this.Controls.Add(this.HandHalf);
            this.Controls.Add(this.HandCard);
            this.Controls.Add(this.HandDeck);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.textWindow);
            this.Controls.Add(this.redPanel);
            this.Controls.Add(this.blackPanel);
            this.Controls.Add(this.chooseDeck);
            this.Controls.Add(this.Organize);
            this.Controls.Add(this.generateDeck);
            this.Controls.Add(this.title);
            this.Name = "CardGeneratorIndex";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button generateDeck;
        private System.Windows.Forms.Button Organize;
        private System.Windows.Forms.CheckedListBox chooseDeck;
        private System.Windows.Forms.Panel blackPanel;
        private System.Windows.Forms.Panel redPanel;
        private System.Windows.Forms.TextBox textWindow;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Database;
        private System.Windows.Forms.Button HandDeck;
        private System.Windows.Forms.Button HandCard;
        private System.Windows.Forms.Button HandHalf;
        private System.Windows.Forms.Button HandWhole;
        private System.Windows.Forms.Button Reset;
    }
}

