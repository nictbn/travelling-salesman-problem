namespace TravellingSalesmanProblem
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
            this.LoadDatasetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfGenerationsTextBox = new System.Windows.Forms.TextBox();
            this.CrossoverDropDown = new System.Windows.Forms.ComboBox();
            this.CrossoverLabel = new System.Windows.Forms.Label();
            this.MutationDropDown = new System.Windows.Forms.ComboBox();
            this.MutationLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ExecuteAlgorithmButton = new System.Windows.Forms.Button();
            this.LoadBenchmarkOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // LoadDatasetButton
            // 
            this.LoadDatasetButton.Location = new System.Drawing.Point(12, 12);
            this.LoadDatasetButton.Name = "LoadDatasetButton";
            this.LoadDatasetButton.Size = new System.Drawing.Size(104, 23);
            this.LoadDatasetButton.TabIndex = 0;
            this.LoadDatasetButton.Text = "Load Dataset";
            this.LoadDatasetButton.UseVisualStyleBackColor = true;
            this.LoadDatasetButton.Click += new System.EventHandler(this.LoadDatasetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Generations:";
            // 
            // NumberOfGenerationsTextBox
            // 
            this.NumberOfGenerationsTextBox.Location = new System.Drawing.Point(180, 47);
            this.NumberOfGenerationsTextBox.Name = "NumberOfGenerationsTextBox";
            this.NumberOfGenerationsTextBox.Size = new System.Drawing.Size(140, 20);
            this.NumberOfGenerationsTextBox.TabIndex = 2;
            this.NumberOfGenerationsTextBox.Text = "10000";
            this.NumberOfGenerationsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CrossoverDropDown
            // 
            this.CrossoverDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CrossoverDropDown.FormattingEnabled = true;
            this.CrossoverDropDown.Items.AddRange(new object[] {
            "First Crossover",
            "Second Crossover"});
            this.CrossoverDropDown.Location = new System.Drawing.Point(180, 83);
            this.CrossoverDropDown.Name = "CrossoverDropDown";
            this.CrossoverDropDown.Size = new System.Drawing.Size(140, 21);
            this.CrossoverDropDown.TabIndex = 3;
            // 
            // CrossoverLabel
            // 
            this.CrossoverLabel.AutoSize = true;
            this.CrossoverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrossoverLabel.Location = new System.Drawing.Point(9, 84);
            this.CrossoverLabel.Name = "CrossoverLabel";
            this.CrossoverLabel.Size = new System.Drawing.Size(148, 16);
            this.CrossoverLabel.TabIndex = 4;
            this.CrossoverLabel.Text = "Crossover Operator:";
            // 
            // MutationDropDown
            // 
            this.MutationDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MutationDropDown.FormattingEnabled = true;
            this.MutationDropDown.Items.AddRange(new object[] {
            "First Mutation",
            "Second Mutation",
            "Third Mutation"});
            this.MutationDropDown.Location = new System.Drawing.Point(180, 120);
            this.MutationDropDown.Name = "MutationDropDown";
            this.MutationDropDown.Size = new System.Drawing.Size(140, 21);
            this.MutationDropDown.TabIndex = 5;
            // 
            // MutationLabel
            // 
            this.MutationLabel.AutoSize = true;
            this.MutationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MutationLabel.Location = new System.Drawing.Point(9, 121);
            this.MutationLabel.Name = "MutationLabel";
            this.MutationLabel.Size = new System.Drawing.Size(135, 16);
            this.MutationLabel.TabIndex = 6;
            this.MutationLabel.Text = "Mutation Operator:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Progress:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 182);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(308, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // ExecuteAlgorithmButton
            // 
            this.ExecuteAlgorithmButton.Enabled = false;
            this.ExecuteAlgorithmButton.Location = new System.Drawing.Point(12, 232);
            this.ExecuteAlgorithmButton.Name = "ExecuteAlgorithmButton";
            this.ExecuteAlgorithmButton.Size = new System.Drawing.Size(104, 23);
            this.ExecuteAlgorithmButton.TabIndex = 9;
            this.ExecuteAlgorithmButton.Text = "Go";
            this.ExecuteAlgorithmButton.UseVisualStyleBackColor = true;
            this.ExecuteAlgorithmButton.Click += new System.EventHandler(this.ExecuteAlgorithmButton_Click);
            // 
            // LoadBenchmarkOpenFileDialog
            // 
            this.LoadBenchmarkOpenFileDialog.Filter = "Benchmark files | *.bench ";
            this.LoadBenchmarkOpenFileDialog.Title = "Open Benchmark File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 279);
            this.Controls.Add(this.ExecuteAlgorithmButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MutationLabel);
            this.Controls.Add(this.MutationDropDown);
            this.Controls.Add(this.CrossoverLabel);
            this.Controls.Add(this.CrossoverDropDown);
            this.Controls.Add(this.NumberOfGenerationsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadDatasetButton);
            this.Name = "Form1";
            this.Text = "The Travelling Salesman Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadDatasetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberOfGenerationsTextBox;
        private System.Windows.Forms.ComboBox CrossoverDropDown;
        private System.Windows.Forms.Label CrossoverLabel;
        private System.Windows.Forms.ComboBox MutationDropDown;
        private System.Windows.Forms.Label MutationLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ExecuteAlgorithmButton;
        private System.Windows.Forms.OpenFileDialog LoadBenchmarkOpenFileDialog;
    }
}

