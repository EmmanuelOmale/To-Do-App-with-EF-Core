namespace EFCore;

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
        label1 = new Label();
        label3 = new Label();
        label4 = new Label();
        TaskDesbtn = new TextBox();
        TaskTitlebtn = new TextBox();
        Searchbtn = new Button();
        Updatebtn = new Button();
        Deletebtn = new Button();
        Insertbtn = new Button();
        label7 = new Label();
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        label8 = new Label();
        fileSystemWatcher1 = new FileSystemWatcher();
        label2 = new Label();
        TaskID = new ComboBox();
        dateTimePicker1 = new DateTimePicker();
        dateTimePicker2 = new DateTimePicker();
        dataGridView1 = new DataGridView();
        SearchTextbox = new TextBox();
        ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("French Script MT", 25F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(257, 10);
        label1.Name = "label1";
        label1.Size = new Size(146, 38);
        label1.TabIndex = 0;
        label1.Text = "To-Do App";
        label1.Click += label1_Click_1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Script MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(12, 67);
        label3.Name = "label3";
        label3.Size = new Size(96, 23);
        label3.TabIndex = 0;
        label3.Text = "Task Tittle";
        label3.Click += label3_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Script MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(9, 105);
        label4.Name = "label4";
        label4.Size = new Size(141, 23);
        label4.TabIndex = 0;
        label4.Text = "Task Description";
        label4.Click += label4_Click;
        // 
        // TaskDesbtn
        // 
        TaskDesbtn.BorderStyle = BorderStyle.FixedSingle;
        TaskDesbtn.Location = new Point(156, 105);
        TaskDesbtn.Name = "TaskDesbtn";
        TaskDesbtn.Size = new Size(350, 23);
        TaskDesbtn.TabIndex = 1;
        TaskDesbtn.TextChanged += textBox2_TextChanged;
        // 
        // TaskTitlebtn
        // 
        TaskTitlebtn.BorderStyle = BorderStyle.FixedSingle;
        TaskTitlebtn.ForeColor = SystemColors.HotTrack;
        TaskTitlebtn.Location = new Point(156, 67);
        TaskTitlebtn.Name = "TaskTitlebtn";
        TaskTitlebtn.Size = new Size(350, 23);
        TaskTitlebtn.TabIndex = 1;
        TaskTitlebtn.TextChanged += textBox3_TextChanged;
        // 
        // Searchbtn
        // 
        Searchbtn.FlatAppearance.MouseDownBackColor = Color.Lime;
        Searchbtn.FlatStyle = FlatStyle.Flat;
        Searchbtn.ForeColor = Color.MediumVioletRed;
        Searchbtn.Location = new Point(430, 311);
        Searchbtn.Name = "Searchbtn";
        Searchbtn.Size = new Size(75, 23);
        Searchbtn.TabIndex = 2;
        Searchbtn.Text = "Search";
        Searchbtn.UseVisualStyleBackColor = true;
        Searchbtn.Click += button1_Click;
        // 
        // Updatebtn
        // 
        Updatebtn.FlatStyle = FlatStyle.Popup;
        Updatebtn.Location = new Point(339, 311);
        Updatebtn.Name = "Updatebtn";
        Updatebtn.Size = new Size(75, 23);
        Updatebtn.TabIndex = 2;
        Updatebtn.Text = "Update";
        Updatebtn.UseVisualStyleBackColor = true;
        Updatebtn.Click += button2_Click;
        // 
        // Deletebtn
        // 
        Deletebtn.FlatAppearance.MouseDownBackColor = Color.Red;
        Deletebtn.FlatStyle = FlatStyle.Popup;
        Deletebtn.ForeColor = Color.Red;
        Deletebtn.Location = new Point(248, 311);
        Deletebtn.Name = "Deletebtn";
        Deletebtn.Size = new Size(75, 23);
        Deletebtn.TabIndex = 2;
        Deletebtn.Text = "Delete";
        Deletebtn.UseVisualStyleBackColor = true;
        Deletebtn.Click += button3_Click;
        // 
        // Insertbtn
        // 
        Insertbtn.FlatStyle = FlatStyle.Popup;
        Insertbtn.ForeColor = Color.Lime;
        Insertbtn.Location = new Point(156, 311);
        Insertbtn.Name = "Insertbtn";
        Insertbtn.Size = new Size(75, 23);
        Insertbtn.TabIndex = 2;
        Insertbtn.Text = "Insert";
        Insertbtn.UseVisualStyleBackColor = true;
        Insertbtn.Click += button4_Click;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Script MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
        label7.Location = new Point(9, 146);
        label7.Name = "label7";
        label7.Size = new Size(142, 23);
        label7.TabIndex = 0;
        label7.Text = "Make a Schedule";
        label7.Click += label4_Click;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Script MT Bold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        label8.Location = new Point(802, 25);
        label8.Name = "label8";
        label8.Size = new Size(85, 23);
        label8.TabIndex = 5;
        label8.Text = "Task List";
        label8.Click += label8_Click;
        // 
        // fileSystemWatcher1
        // 
        fileSystemWatcher1.EnableRaisingEvents = true;
        fileSystemWatcher1.SynchronizingObject = this;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Script MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(9, 185);
        label2.Name = "label2";
        label2.Size = new Size(135, 23);
        label2.TabIndex = 0;
        label2.Text = "Completion Date";
        label2.Click += label4_Click;
        // 
        // TaskID
        // 
        TaskID.FormattingEnabled = true;
        TaskID.Location = new Point(249, 282);
        TaskID.Name = "TaskID";
        TaskID.Size = new Size(74, 23);
        TaskID.TabIndex = 6;
        TaskID.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new Point(156, 146);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(75, 23);
        dateTimePicker1.TabIndex = 3;
        dateTimePicker1.ValueChanged += dateTimePicker3_ValueChanged;
        // 
        // dateTimePicker2
        // 
        dateTimePicker2.Location = new Point(156, 185);
        dateTimePicker2.Name = "dateTimePicker2";
        dateTimePicker2.Size = new Size(75, 23);
        dateTimePicker2.TabIndex = 3;
        dateTimePicker2.ValueChanged += dateTimePicker3_ValueChanged;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(531, 67);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(644, 267);
        dataGridView1.TabIndex = 7;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
        // 
        // SearchTextbox
        // 
        SearchTextbox.BorderStyle = BorderStyle.FixedSingle;
        SearchTextbox.ForeColor = SystemColors.HotTrack;
        SearchTextbox.Location = new Point(430, 282);
        SearchTextbox.Name = "SearchTextbox";
        SearchTextbox.Size = new Size(76, 23);
        SearchTextbox.TabIndex = 1;
        SearchTextbox.TextChanged += textBox3_TextChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1292, 507);
        Controls.Add(dataGridView1);
        Controls.Add(TaskID);
        Controls.Add(label8);
        Controls.Add(dateTimePicker1);
        Controls.Add(dateTimePicker2);
        Controls.Add(Insertbtn);
        Controls.Add(Deletebtn);
        Controls.Add(Updatebtn);
        Controls.Add(label2);
        Controls.Add(Searchbtn);
        Controls.Add(label7);
        Controls.Add(TaskDesbtn);
        Controls.Add(SearchTextbox);
        Controls.Add(TaskTitlebtn);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox TaskDesbtn;
    private System.Windows.Forms.TextBox TaskTitlebtn;
    private System.Windows.Forms.Button Searchbtn;
    private System.Windows.Forms.Button Updatebtn;
    private System.Windows.Forms.Button Deletebtn;
    private System.Windows.Forms.Button Insertbtn;
    private System.Windows.Forms.Label label7;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.Label label8;
    private System.IO.FileSystemWatcher fileSystemWatcher1;
    private System.Windows.Forms.ComboBox TaskID;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.DateTimePicker dateTimePicker2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.TextBox SearchTextbox;
}