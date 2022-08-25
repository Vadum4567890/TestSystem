﻿
namespace TestConstructor
{
    partial class AddEditQuestion
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
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPoints = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.dataGridViewAnswers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonAddAnswer = new System.Windows.Forms.Button();
            this.buttonEditAnswer = new System.Windows.Forms.Button();
            this.buttonDeleteAnswer = new System.Windows.Forms.Button();
            this.labelErrorText = new System.Windows.Forms.Label();
            this.labelErrorAnswers = new System.Windows.Forms.Label();
            this.buttonClearImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(11, 24);
            this.textBoxText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(260, 42);
            this.textBoxText.TabIndex = 0;
            this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Points:";
            // 
            // numericUpDownPoints
            // 
            this.numericUpDownPoints.Location = new System.Drawing.Point(9, 84);
            this.numericUpDownPoints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPoints.Name = "numericUpDownPoints";
            this.numericUpDownPoints.Size = new System.Drawing.Size(262, 20);
            this.numericUpDownPoints.TabIndex = 4;
            this.numericUpDownPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPoints.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPoints.ValueChanged += new System.EventHandler(this.numericUpDownPoints_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Image for question:";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Location = new System.Drawing.Point(11, 120);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(260, 324);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 6;
            this.pictureBoxImage.TabStop = false;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadImage.ForeColor = System.Drawing.Color.Blue;
            this.buttonLoadImage.Location = new System.Drawing.Point(11, 462);
            this.buttonLoadImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(123, 25);
            this.buttonLoadImage.TabIndex = 7;
            this.buttonLoadImage.Text = "Load image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // dataGridViewAnswers
            // 
            this.dataGridViewAnswers.AllowUserToAddRows = false;
            this.dataGridViewAnswers.AllowUserToDeleteRows = false;
            this.dataGridViewAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnswers.Location = new System.Drawing.Point(284, 53);
            this.dataGridViewAnswers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAnswers.Name = "dataGridViewAnswers";
            this.dataGridViewAnswers.ReadOnly = true;
            this.dataGridViewAnswers.RowHeadersWidth = 51;
            this.dataGridViewAnswers.RowTemplate.Height = 24;
            this.dataGridViewAnswers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewAnswers.Size = new System.Drawing.Size(346, 391);
            this.dataGridViewAnswers.TabIndex = 9;
            this.dataGridViewAnswers.SelectionChanged += new System.EventHandler(this.dataGridViewAnswers_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Answers:";
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSave.Location = new System.Drawing.Point(284, 463);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(169, 24);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(461, 463);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(169, 24);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonAddAnswer
            // 
            this.buttonAddAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddAnswer.ForeColor = System.Drawing.Color.Green;
            this.buttonAddAnswer.Location = new System.Drawing.Point(284, 24);
            this.buttonAddAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddAnswer.Name = "buttonAddAnswer";
            this.buttonAddAnswer.Size = new System.Drawing.Size(112, 24);
            this.buttonAddAnswer.TabIndex = 13;
            this.buttonAddAnswer.Text = "Add";
            this.buttonAddAnswer.UseVisualStyleBackColor = true;
            this.buttonAddAnswer.Click += new System.EventHandler(this.buttonAddAnswer_Click);
            // 
            // buttonEditAnswer
            // 
            this.buttonEditAnswer.Enabled = false;
            this.buttonEditAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditAnswer.ForeColor = System.Drawing.Color.Blue;
            this.buttonEditAnswer.Location = new System.Drawing.Point(400, 24);
            this.buttonEditAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditAnswer.Name = "buttonEditAnswer";
            this.buttonEditAnswer.Size = new System.Drawing.Size(112, 24);
            this.buttonEditAnswer.TabIndex = 14;
            this.buttonEditAnswer.Text = "Edit";
            this.buttonEditAnswer.UseVisualStyleBackColor = true;
            this.buttonEditAnswer.Click += new System.EventHandler(this.buttonEditAnswer_Click);
            // 
            // buttonDeleteAnswer
            // 
            this.buttonDeleteAnswer.Enabled = false;
            this.buttonDeleteAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteAnswer.ForeColor = System.Drawing.Color.Black;
            this.buttonDeleteAnswer.Location = new System.Drawing.Point(518, 24);
            this.buttonDeleteAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteAnswer.Name = "buttonDeleteAnswer";
            this.buttonDeleteAnswer.Size = new System.Drawing.Size(112, 24);
            this.buttonDeleteAnswer.TabIndex = 15;
            this.buttonDeleteAnswer.Text = "Delete";
            this.buttonDeleteAnswer.UseVisualStyleBackColor = true;
            this.buttonDeleteAnswer.Click += new System.EventHandler(this.buttonDeleteAnswer_Click);
            // 
            // labelErrorText
            // 
            this.labelErrorText.AutoSize = true;
            this.labelErrorText.ForeColor = System.Drawing.Color.Red;
            this.labelErrorText.Location = new System.Drawing.Point(98, 7);
            this.labelErrorText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErrorText.Name = "labelErrorText";
            this.labelErrorText.Size = new System.Drawing.Size(115, 13);
            this.labelErrorText.TabIndex = 16;
            this.labelErrorText.Text = "Incorrect, field is empty";
            // 
            // labelErrorAnswers
            // 
            this.labelErrorAnswers.AutoSize = true;
            this.labelErrorAnswers.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAnswers.Location = new System.Drawing.Point(334, 7);
            this.labelErrorAnswers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErrorAnswers.Name = "labelErrorAnswers";
            this.labelErrorAnswers.Size = new System.Drawing.Size(210, 13);
            this.labelErrorAnswers.TabIndex = 17;
            this.labelErrorAnswers.Text = "Incorrect, at least one answer must be right";
            // 
            // buttonClearImage
            // 
            this.buttonClearImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearImage.Location = new System.Drawing.Point(148, 463);
            this.buttonClearImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClearImage.Name = "buttonClearImage";
            this.buttonClearImage.Size = new System.Drawing.Size(123, 25);
            this.buttonClearImage.TabIndex = 18;
            this.buttonClearImage.Text = "Delete image";
            this.buttonClearImage.UseVisualStyleBackColor = true;
            this.buttonClearImage.Click += new System.EventHandler(this.buttonClearImage_Click);
            // 
            // AddEditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 517);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClearImage);
            this.Controls.Add(this.labelErrorAnswers);
            this.Controls.Add(this.labelErrorText);
            this.Controls.Add(this.buttonDeleteAnswer);
            this.Controls.Add(this.buttonEditAnswer);
            this.Controls.Add(this.buttonAddAnswer);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewAnswers);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddEditQuestion";
            this.Text = "AddEditQuestion";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnswers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.DataGridView dataGridViewAnswers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonAddAnswer;
        private System.Windows.Forms.Button buttonEditAnswer;
        private System.Windows.Forms.Button buttonDeleteAnswer;
        private System.Windows.Forms.Label labelErrorText;
        private System.Windows.Forms.Label labelErrorAnswers;
        private System.Windows.Forms.Button buttonClearImage;
    }
}