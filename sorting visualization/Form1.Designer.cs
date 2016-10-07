namespace sorting_visualization
{
    partial class SortingVisualization
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
            this.NumberOfElements = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.SelectionSort = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SortingCounter = new System.Windows.Forms.Label();
            this.restoreOldUnsortList = new System.Windows.Forms.Button();
            this.InsertionSort = new System.Windows.Forms.Button();
            this.indicator = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NumberOfElements
            // 
            this.NumberOfElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberOfElements.Location = new System.Drawing.Point(1152, 24);
            this.NumberOfElements.MaxLength = 2;
            this.NumberOfElements.Name = "NumberOfElements";
            this.NumberOfElements.Size = new System.Drawing.Size(168, 20);
            this.NumberOfElements.TabIndex = 1;
            this.NumberOfElements.TextChanged += new System.EventHandler(this.NumberOfElements_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(955, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numbers of elements (max 23):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Next
            // 
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Next.Location = new System.Drawing.Point(1326, 23);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 22);
            this.Next.TabIndex = 3;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // BubbleSort
            // 
            this.BubbleSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BubbleSort.Location = new System.Drawing.Point(1152, 259);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(249, 59);
            this.BubbleSort.TabIndex = 4;
            this.BubbleSort.Text = "Bubble Sort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // SelectionSort
            // 
            this.SelectionSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectionSort.Location = new System.Drawing.Point(1152, 481);
            this.SelectionSort.Name = "SelectionSort";
            this.SelectionSort.Size = new System.Drawing.Size(249, 59);
            this.SelectionSort.TabIndex = 5;
            this.SelectionSort.Text = "Selection Sort";
            this.SelectionSort.UseVisualStyleBackColor = true;
            this.SelectionSort.Click += new System.EventHandler(this.SelectionSort_Click);
            // 
            // exit
            // 
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Location = new System.Drawing.Point(1152, 592);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(249, 59);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // SortingCounter
            // 
            this.SortingCounter.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortingCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SortingCounter.Location = new System.Drawing.Point(29, 633);
            this.SortingCounter.Name = "SortingCounter";
            this.SortingCounter.Size = new System.Drawing.Size(1083, 30);
            this.SortingCounter.TabIndex = 8;
            this.SortingCounter.Text = "Sorting Time (in steps) Bubble Sort:   --   Insertion Sort:   --   Selection Sort" +
    ":   --   ";
            // 
            // restoreOldUnsortList
            // 
            this.restoreOldUnsortList.Enabled = false;
            this.restoreOldUnsortList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restoreOldUnsortList.Location = new System.Drawing.Point(1152, 148);
            this.restoreOldUnsortList.Name = "restoreOldUnsortList";
            this.restoreOldUnsortList.Size = new System.Drawing.Size(249, 59);
            this.restoreOldUnsortList.TabIndex = 9;
            this.restoreOldUnsortList.Text = "Restore Old List";
            this.restoreOldUnsortList.UseVisualStyleBackColor = true;
            this.restoreOldUnsortList.Click += new System.EventHandler(this.restoreOldUnsortList_Click);
            // 
            // InsertionSort
            // 
            this.InsertionSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsertionSort.Location = new System.Drawing.Point(1152, 370);
            this.InsertionSort.Name = "InsertionSort";
            this.InsertionSort.Size = new System.Drawing.Size(249, 59);
            this.InsertionSort.TabIndex = 10;
            this.InsertionSort.Text = "Insertion Sort";
            this.InsertionSort.UseVisualStyleBackColor = true;
            this.InsertionSort.Click += new System.EventHandler(this.InsertionSort_Click_1);
            // 
            // indicator
            // 
            this.indicator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indicator.AutoEllipsis = true;
            this.indicator.Checked = true;
            this.indicator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.indicator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.indicator.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicator.Location = new System.Drawing.Point(1193, 82);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(208, 38);
            this.indicator.TabIndex = 11;
            this.indicator.Text = "Indicator for visualization";
            this.indicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.indicator.UseVisualStyleBackColor = true;
            // 
            // SortingVisualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1413, 680);
            this.Controls.Add(this.indicator);
            this.Controls.Add(this.InsertionSort);
            this.Controls.Add(this.restoreOldUnsortList);
            this.Controls.Add(this.SortingCounter);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.SelectionSort);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfElements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SortingVisualization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting Algorithm Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberOfElements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.Button SelectionSort;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label SortingCounter;
        private System.Windows.Forms.Button restoreOldUnsortList;
        private System.Windows.Forms.Button InsertionSort;
        private System.Windows.Forms.CheckBox indicator;

    }
}

