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
            this.PopulationSizeTextBox = new System.Windows.Forms.TextBox();
            this.PopulationSizeLabel = new System.Windows.Forms.Label();
            this.AlgorithmBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.MutationProbabilityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RecombinationProbabilityTextBox = new System.Windows.Forms.TextBox();
            this.RecombinationProbabilityLabel = new System.Windows.Forms.Label();
            this.MutationProbabilityLabel = new System.Windows.Forms.Label();
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
            this.NumberOfGenerationsTextBox.Location = new System.Drawing.Point(205, 47);
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
            "Order One Crossover",
            "PMX Crossover"});
            this.CrossoverDropDown.Location = new System.Drawing.Point(205, 163);
            this.CrossoverDropDown.Name = "CrossoverDropDown";
            this.CrossoverDropDown.Size = new System.Drawing.Size(140, 21);
            this.CrossoverDropDown.TabIndex = 3;
            // 
            // CrossoverLabel
            // 
            this.CrossoverLabel.AutoSize = true;
            this.CrossoverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrossoverLabel.Location = new System.Drawing.Point(9, 164);
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
            "Insert Mutation",
            "Swap Mutation",
            "Inversion Mutation"});
            this.MutationDropDown.Location = new System.Drawing.Point(205, 200);
            this.MutationDropDown.Name = "MutationDropDown";
            this.MutationDropDown.Size = new System.Drawing.Size(140, 21);
            this.MutationDropDown.TabIndex = 5;
            // 
            // MutationLabel
            // 
            this.MutationLabel.AutoSize = true;
            this.MutationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MutationLabel.Location = new System.Drawing.Point(9, 201);
            this.MutationLabel.Name = "MutationLabel";
            this.MutationLabel.Size = new System.Drawing.Size(135, 16);
            this.MutationLabel.TabIndex = 6;
            this.MutationLabel.Text = "Mutation Operator:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Progress:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 269);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(308, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // ExecuteAlgorithmButton
            // 
            this.ExecuteAlgorithmButton.Enabled = false;
            this.ExecuteAlgorithmButton.Location = new System.Drawing.Point(12, 309);
            this.ExecuteAlgorithmButton.Name = "ExecuteAlgorithmButton";
            this.ExecuteAlgorithmButton.Size = new System.Drawing.Size(104, 23);
            this.ExecuteAlgorithmButton.TabIndex = 9;
            this.ExecuteAlgorithmButton.Text = "Go";
            this.ExecuteAlgorithmButton.UseVisualStyleBackColor = true;
            this.ExecuteAlgorithmButton.Click += new System.EventHandler(this.ExecuteAlgorithmButton_Click);
            // 
            // LoadBenchmarkOpenFileDialog
            // 
            this.LoadBenchmarkOpenFileDialog.Filter = "Benchmark files (*.bench)|*.bench";
            this.LoadBenchmarkOpenFileDialog.Title = "Open Benchmark File";
            // 
            // PopulationSizeTextBox
            // 
            this.PopulationSizeTextBox.Location = new System.Drawing.Point(205, 75);
            this.PopulationSizeTextBox.Name = "PopulationSizeTextBox";
            this.PopulationSizeTextBox.Size = new System.Drawing.Size(140, 20);
            this.PopulationSizeTextBox.TabIndex = 11;
            this.PopulationSizeTextBox.Text = "100";
            this.PopulationSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PopulationSizeLabel
            // 
            this.PopulationSizeLabel.AutoSize = true;
            this.PopulationSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopulationSizeLabel.Location = new System.Drawing.Point(9, 76);
            this.PopulationSizeLabel.Name = "PopulationSizeLabel";
            this.PopulationSizeLabel.Size = new System.Drawing.Size(120, 16);
            this.PopulationSizeLabel.TabIndex = 10;
            this.PopulationSizeLabel.Text = "Population Size:";
            // 
            // AlgorithmBackgroundWorker
            // 
            this.AlgorithmBackgroundWorker.WorkerReportsProgress = true;
            this.AlgorithmBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AlgorithmBackgroundWorker_DoWork);
            this.AlgorithmBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.AlgorithmBackgroundWorker_ProgressChanged);
            this.AlgorithmBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AlgorithmBackgroundWorker_RunWorkerCompleted);
            // 
            // MutationProbabilityTextBox
            // 
            this.MutationProbabilityTextBox.Location = new System.Drawing.Point(205, 129);
            this.MutationProbabilityTextBox.Name = "MutationProbabilityTextBox";
            this.MutationProbabilityTextBox.Size = new System.Drawing.Size(140, 20);
            this.MutationProbabilityTextBox.TabIndex = 15;
            this.MutationProbabilityTextBox.Text = "60";
            this.MutationProbabilityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 14;
            // 
            // RecombinationProbabilityTextBox
            // 
            this.RecombinationProbabilityTextBox.Location = new System.Drawing.Point(205, 101);
            this.RecombinationProbabilityTextBox.Name = "RecombinationProbabilityTextBox";
            this.RecombinationProbabilityTextBox.Size = new System.Drawing.Size(140, 20);
            this.RecombinationProbabilityTextBox.TabIndex = 13;
            this.RecombinationProbabilityTextBox.Text = "80";
            this.RecombinationProbabilityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RecombinationProbabilityLabel
            // 
            this.RecombinationProbabilityLabel.AutoSize = true;
            this.RecombinationProbabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecombinationProbabilityLabel.Location = new System.Drawing.Point(9, 102);
            this.RecombinationProbabilityLabel.Name = "RecombinationProbabilityLabel";
            this.RecombinationProbabilityLabel.Size = new System.Drawing.Size(195, 16);
            this.RecombinationProbabilityLabel.TabIndex = 12;
            this.RecombinationProbabilityLabel.Text = "Recombination Probability:";
            // 
            // MutationProbabilityLabel
            // 
            this.MutationProbabilityLabel.AutoSize = true;
            this.MutationProbabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MutationProbabilityLabel.Location = new System.Drawing.Point(9, 130);
            this.MutationProbabilityLabel.Name = "MutationProbabilityLabel";
            this.MutationProbabilityLabel.Size = new System.Drawing.Size(149, 16);
            this.MutationProbabilityLabel.TabIndex = 16;
            this.MutationProbabilityLabel.Text = "Mutation Probability:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 409);
            this.Controls.Add(this.MutationProbabilityLabel);
            this.Controls.Add(this.MutationProbabilityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RecombinationProbabilityTextBox);
            this.Controls.Add(this.RecombinationProbabilityLabel);
            this.Controls.Add(this.PopulationSizeTextBox);
            this.Controls.Add(this.PopulationSizeLabel);
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
        private System.Windows.Forms.TextBox PopulationSizeTextBox;
        private System.Windows.Forms.Label PopulationSizeLabel;
        private System.ComponentModel.BackgroundWorker AlgorithmBackgroundWorker;
        private System.Windows.Forms.TextBox MutationProbabilityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RecombinationProbabilityTextBox;
        private System.Windows.Forms.Label RecombinationProbabilityLabel;
        private System.Windows.Forms.Label MutationProbabilityLabel;
    }
}

