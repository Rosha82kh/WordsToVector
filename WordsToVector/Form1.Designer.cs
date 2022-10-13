namespace WordsToVector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoudTrainSet = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnwords2vector = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnTrain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoudTrainSet
            // 
            this.btnLoudTrainSet.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLoudTrainSet.Location = new System.Drawing.Point(12, 33);
            this.btnLoudTrainSet.Name = "btnLoudTrainSet";
            this.btnLoudTrainSet.Size = new System.Drawing.Size(379, 29);
            this.btnLoudTrainSet.TabIndex = 0;
            this.btnLoudTrainSet.Text = "Loud TrainSet";
            this.btnLoudTrainSet.UseVisualStyleBackColor = false;
            this.btnLoudTrainSet.Click += new System.EventHandler(this.btnLoudTrainSet_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(379, 313);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnwords2vector
            // 
            this.btnwords2vector.Location = new System.Drawing.Point(12, 406);
            this.btnwords2vector.Name = "btnwords2vector";
            this.btnwords2vector.Size = new System.Drawing.Size(379, 29);
            this.btnwords2vector.TabIndex = 2;
            this.btnwords2vector.Text = "Words To Vector";
            this.btnwords2vector.UseVisualStyleBackColor = true;
            this.btnwords2vector.Click += new System.EventHandler(this.btnwords2vector_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(12, 443);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(379, 29);
            this.btnTrain.TabIndex = 3;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 541);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnwords2vector);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnLoudTrainSet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLoudTrainSet;
        private RichTextBox richTextBox1;
        private Button btnwords2vector;
        private OpenFileDialog openFileDialog1;
        private Button btnTrain;
    }
}