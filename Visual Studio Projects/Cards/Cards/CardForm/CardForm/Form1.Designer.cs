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
            this.missingCard = new System.Windows.Forms.Button();
            this.chooseDeck = new System.Windows.Forms.CheckedListBox();
            this.blackPanel = new System.Windows.Forms.Panel();
            this.redPanel = new System.Windows.Forms.Panel();
            this.userWindow = new System.Windows.Forms.ListBox();
            this.textWindow = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.Database = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(281, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(213, 34);
            this.title.TabIndex = 0;
            this.title.Text = "Card Generator";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // generateDeck
            // 
            this.generateDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateDeck.Location = new System.Drawing.Point(308, 377);
            this.generateDeck.Name = "generateDeck";
            this.generateDeck.Size = new System.Drawing.Size(166, 61);
            this.generateDeck.TabIndex = 1;
            this.generateDeck.Text = "Generate Deck of Cards";
            this.generateDeck.UseVisualStyleBackColor = true;
            this.generateDeck.Click += new System.EventHandler(this.generateDeck_Click);
            // 
            // missingCard
            // 
            this.missingCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missingCard.Location = new System.Drawing.Point(480, 404);
            this.missingCard.Name = "missingCard";
            this.missingCard.Size = new System.Drawing.Size(105, 34);
            this.missingCard.TabIndex = 2;
            this.missingCard.Text = "Organize";
            this.missingCard.UseVisualStyleBackColor = true;
            this.missingCard.Click += new System.EventHandler(this.missingCard_Click);
            // 
            // chooseDeck
            // 
            this.chooseDeck.BackColor = System.Drawing.SystemColors.Control;
            this.chooseDeck.CheckOnClick = true;
            this.chooseDeck.FormattingEnabled = true;
            this.chooseDeck.Items.AddRange(new object[] {
            "No Jokers",
            "Only two Types",
            "No Picture Cards"});
            this.chooseDeck.Location = new System.Drawing.Point(157, 377);
            this.chooseDeck.Name = "chooseDeck";
            this.chooseDeck.Size = new System.Drawing.Size(145, 72);
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
            this.redPanel.Location = new System.Drawing.Point(715, 0);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(86, 450);
            this.redPanel.TabIndex = 5;
            // 
            // userWindow
            // 
            this.userWindow.FormattingEnabled = true;
            this.userWindow.ItemHeight = 16;
            this.userWindow.Location = new System.Drawing.Point(91, 51);
            this.userWindow.Name = "userWindow";
            this.userWindow.Size = new System.Drawing.Size(618, 324);
            this.userWindow.TabIndex = 6;
            this.userWindow.SelectedIndexChanged += new System.EventHandler(this.userWindow_SelectedIndexChanged);
            // 
            // textWindow
            // 
            this.textWindow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textWindow.Location = new System.Drawing.Point(91, 51);
            this.textWindow.Multiline = true;
            this.textWindow.Name = "textWindow";
            this.textWindow.Size = new System.Drawing.Size(618, 296);
            this.textWindow.TabIndex = 7;
            this.textWindow.TextChanged += new System.EventHandler(this.textWindow_TextChanged);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(652, 404);
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
            this.Database.Location = new System.Drawing.Point(480, 377);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(105, 34);
            this.Database.TabIndex = 9;
            this.Database.Text = "Database";
            this.Database.UseVisualStyleBackColor = true;
            this.Database.Click += new System.EventHandler(this.Database_Click);
            // 
            // CardGeneratorIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.textWindow);
            this.Controls.Add(this.userWindow);
            this.Controls.Add(this.redPanel);
            this.Controls.Add(this.blackPanel);
            this.Controls.Add(this.chooseDeck);
            this.Controls.Add(this.missingCard);
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
        private System.Windows.Forms.Button missingCard;
        private System.Windows.Forms.CheckedListBox chooseDeck;
        private System.Windows.Forms.Panel blackPanel;
        private System.Windows.Forms.Panel redPanel;
        private System.Windows.Forms.ListBox userWindow;
        private System.Windows.Forms.TextBox textWindow;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Database;
    }
}

