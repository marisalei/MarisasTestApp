namespace MarisaTestApp
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
            HinzufügenButton = new Button();
            VornameTextBox = new TextBox();
            AnzeigePersonenListBox = new ListBox();
            IDLabel = new Label();
            NachnameTextBox = new TextBox();
            ÄndernButton = new Button();
            LöschenButton = new Button();
            TextfelderLeerenButton = new Button();
            NachAlterSortierenAufwärtsButton = new Button();
            NachAlterSortierenAbwärtsButton = new Button();
            GeschlechtLabel = new Label();
            GeschlechtComboBox = new ComboBox();
            AlterLabel = new Label();
            AlterNumericUpDown = new NumericUpDown();
            NachIDSortierenButton = new Button();
            NachGeschlechtUndAlterSortierenButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AlterNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // HinzufügenButton
            // 
            HinzufügenButton.Location = new Point(833, 474);
            HinzufügenButton.Margin = new Padding(5, 6, 5, 6);
            HinzufügenButton.Name = "HinzufügenButton";
            HinzufügenButton.Size = new Size(127, 63);
            HinzufügenButton.TabIndex = 5;
            HinzufügenButton.Text = "Hinzufügen";
            HinzufügenButton.UseVisualStyleBackColor = true;
            HinzufügenButton.Click += OnHinzufügenButton_Click;
            // 
            // VornameTextBox
            // 
            VornameTextBox.Location = new Point(698, 135);
            VornameTextBox.Margin = new Padding(5, 6, 5, 6);
            VornameTextBox.Name = "VornameTextBox";
            VornameTextBox.PlaceholderText = "Vorname";
            VornameTextBox.Size = new Size(394, 31);
            VornameTextBox.TabIndex = 1;
            // 
            // AnzeigePersonenListBox
            // 
            AnzeigePersonenListBox.FormattingEnabled = true;
            AnzeigePersonenListBox.ItemHeight = 25;
            AnzeigePersonenListBox.Location = new Point(52, 81);
            AnzeigePersonenListBox.Margin = new Padding(5, 6, 5, 6);
            AnzeigePersonenListBox.Name = "AnzeigePersonenListBox";
            AnzeigePersonenListBox.Size = new Size(451, 604);
            AnzeigePersonenListBox.TabIndex = 90;
            AnzeigePersonenListBox.TabStop = false;
            AnzeigePersonenListBox.UseTabStops = false;
            AnzeigePersonenListBox.SelectedIndexChanged += OnAnzeigePersonenListBox_SelectedValueChanged;
            AnzeigePersonenListBox.SelectedValueChanged += OnAnzeigePersonenListBox_SelectedValueChanged;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(693, 62);
            IDLabel.Margin = new Padding(5, 0, 5, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(0, 25);
            IDLabel.TabIndex = 3;
            // 
            // NachnameTextBox
            // 
            NachnameTextBox.Location = new Point(698, 225);
            NachnameTextBox.Margin = new Padding(5, 6, 5, 6);
            NachnameTextBox.Name = "NachnameTextBox";
            NachnameTextBox.PlaceholderText = "Nachname";
            NachnameTextBox.Size = new Size(394, 31);
            NachnameTextBox.TabIndex = 2;
            // 
            // ÄndernButton
            // 
            ÄndernButton.Location = new Point(698, 474);
            ÄndernButton.Margin = new Padding(5, 6, 5, 6);
            ÄndernButton.Name = "ÄndernButton";
            ÄndernButton.Size = new Size(125, 63);
            ÄndernButton.TabIndex = 6;
            ÄndernButton.TabStop = false;
            ÄndernButton.Text = "Ändern";
            ÄndernButton.UseVisualStyleBackColor = true;
            ÄndernButton.Click += OnÄndernButton_Click;
            // 
            // LöschenButton
            // 
            LöschenButton.Location = new Point(967, 474);
            LöschenButton.Margin = new Padding(5, 6, 5, 6);
            LöschenButton.Name = "LöschenButton";
            LöschenButton.Size = new Size(125, 63);
            LöschenButton.TabIndex = 7;
            LöschenButton.TabStop = false;
            LöschenButton.Text = "Löschen";
            LöschenButton.UseVisualStyleBackColor = true;
            LöschenButton.Click += OnLöschenButton_Click;
            // 
            // TextfelderLeerenButton
            // 
            TextfelderLeerenButton.Location = new Point(1125, 169);
            TextfelderLeerenButton.Name = "TextfelderLeerenButton";
            TextfelderLeerenButton.Size = new Size(127, 58);
            TextfelderLeerenButton.TabIndex = 8;
            TextfelderLeerenButton.TabStop = false;
            TextfelderLeerenButton.Text = "Textfelder Leeren";
            TextfelderLeerenButton.UseVisualStyleBackColor = true;
            TextfelderLeerenButton.Click += OnTextfelderLeerenButton_Click;
            // 
            // NachAlterSortierenAufwärtsButton
            // 
            NachAlterSortierenAufwärtsButton.Location = new Point(200, 705);
            NachAlterSortierenAufwärtsButton.Name = "NachAlterSortierenAufwärtsButton";
            NachAlterSortierenAufwärtsButton.Size = new Size(155, 85);
            NachAlterSortierenAufwärtsButton.TabIndex = 10;
            NachAlterSortierenAufwärtsButton.TabStop = false;
            NachAlterSortierenAufwärtsButton.Text = "Nach Alter sortieren (aufwärts)";
            NachAlterSortierenAufwärtsButton.UseVisualStyleBackColor = true;
            NachAlterSortierenAufwärtsButton.Click += OnNachAlterSortierenAufwärtsButton_Click;
            // 
            // NachAlterSortierenAbwärtsButton
            // 
            NachAlterSortierenAbwärtsButton.Location = new Point(361, 705);
            NachAlterSortierenAbwärtsButton.Name = "NachAlterSortierenAbwärtsButton";
            NachAlterSortierenAbwärtsButton.Size = new Size(142, 85);
            NachAlterSortierenAbwärtsButton.TabIndex = 11;
            NachAlterSortierenAbwärtsButton.TabStop = false;
            NachAlterSortierenAbwärtsButton.Text = "Nach Alter sortieren (abwärts)";
            NachAlterSortierenAbwärtsButton.UseVisualStyleBackColor = true;
            NachAlterSortierenAbwärtsButton.Click += OnNachAlterSortierenAbwärtsButton_Click;
            // 
            // GeschlechtLabel
            // 
            GeschlechtLabel.AutoSize = true;
            GeschlechtLabel.Font = new Font("Segoe UI", 9F);
            GeschlechtLabel.Location = new Point(872, 285);
            GeschlechtLabel.Name = "GeschlechtLabel";
            GeschlechtLabel.Size = new Size(100, 25);
            GeschlechtLabel.TabIndex = 92;
            GeschlechtLabel.Text = "Geschlecht:";
            // 
            // GeschlechtComboBox
            // 
            GeschlechtComboBox.FormattingEnabled = true;
            GeschlechtComboBox.Location = new Point(978, 285);
            GeschlechtComboBox.Name = "GeschlechtComboBox";
            GeschlechtComboBox.Size = new Size(114, 33);
            GeschlechtComboBox.TabIndex = 4;
            // 
            // AlterLabel
            // 
            AlterLabel.AutoSize = true;
            AlterLabel.Font = new Font("Segoe UI", 9F);
            AlterLabel.Location = new Point(698, 285);
            AlterLabel.Name = "AlterLabel";
            AlterLabel.Size = new Size(53, 25);
            AlterLabel.TabIndex = 94;
            AlterLabel.Text = "Alter:";
            // 
            // AlterNumericUpDown
            // 
            AlterNumericUpDown.Location = new Point(769, 283);
            AlterNumericUpDown.Name = "AlterNumericUpDown";
            AlterNumericUpDown.Size = new Size(66, 31);
            AlterNumericUpDown.TabIndex = 3;
            AlterNumericUpDown.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // NachIDSortierenButton
            // 
            NachIDSortierenButton.Location = new Point(52, 705);
            NachIDSortierenButton.Name = "NachIDSortierenButton";
            NachIDSortierenButton.Size = new Size(142, 85);
            NachIDSortierenButton.TabIndex = 9;
            NachIDSortierenButton.TabStop = false;
            NachIDSortierenButton.Text = "Nach ID sortieren";
            NachIDSortierenButton.UseVisualStyleBackColor = true;
            NachIDSortierenButton.Click += OnNachIDSortierenButton_Click;
            // 
            // NachGeschlechtUndAlterSortierenButton
            // 
            NachGeschlechtUndAlterSortierenButton.Location = new Point(509, 705);
            NachGeschlechtUndAlterSortierenButton.Name = "NachGeschlechtUndAlterSortierenButton";
            NachGeschlechtUndAlterSortierenButton.Size = new Size(142, 85);
            NachGeschlechtUndAlterSortierenButton.TabIndex = 95;
            NachGeschlechtUndAlterSortierenButton.TabStop = false;
            NachGeschlechtUndAlterSortierenButton.Text = "Nach Geschlecht und Alter sortieren (abwärts)";
            NachGeschlechtUndAlterSortierenButton.UseVisualStyleBackColor = true;
            NachGeschlechtUndAlterSortierenButton.Click += OnNachGeschlechtUndAlterSortierenButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 865);
            Controls.Add(NachGeschlechtUndAlterSortierenButton);
            Controls.Add(NachIDSortierenButton);
            Controls.Add(AlterNumericUpDown);
            Controls.Add(AlterLabel);
            Controls.Add(GeschlechtComboBox);
            Controls.Add(GeschlechtLabel);
            Controls.Add(NachAlterSortierenAbwärtsButton);
            Controls.Add(NachAlterSortierenAufwärtsButton);
            Controls.Add(TextfelderLeerenButton);
            Controls.Add(LöschenButton);
            Controls.Add(ÄndernButton);
            Controls.Add(NachnameTextBox);
            Controls.Add(IDLabel);
            Controls.Add(AnzeigePersonenListBox);
            Controls.Add(VornameTextBox);
            Controls.Add(HinzufügenButton);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Personenverwaltung";
            ((System.ComponentModel.ISupportInitialize)AlterNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button HinzufügenButton;
		private System.Windows.Forms.TextBox VornameTextBox;
		private System.Windows.Forms.ListBox AnzeigePersonenListBox;
		private System.Windows.Forms.Label IDLabel;
		private System.Windows.Forms.TextBox NachnameTextBox;
		private System.Windows.Forms.Button ÄndernButton;
		private System.Windows.Forms.Button LöschenButton;
        private Button TextfelderLeerenButton;
        private Button NachAlterSortierenAufwärtsButton;
        private Button NachAlterSortierenAbwärtsButton;
        private Label GeschlechtLabel;
        private ComboBox GeschlechtComboBox;
        private Label AlterLabel;
        private NumericUpDown AlterNumericUpDown;
        private Button NachIDSortierenButton;
        private Button NachGeschlechtUndAlterSortierenButton;
    }
}

