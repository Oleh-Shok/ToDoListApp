namespace ToDoList
{
    partial class ToDoListApp
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
            this.MandatoryToDoList = new System.Windows.Forms.ListBox();
            this.ToDoList = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.AddToDoListTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MandatoryToDoList
            // 
            this.MandatoryToDoList.BackColor = System.Drawing.SystemColors.Info;
            this.MandatoryToDoList.Font = new System.Drawing.Font("Barlow Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MandatoryToDoList.FormattingEnabled = true;
            this.MandatoryToDoList.ItemHeight = 20;
            this.MandatoryToDoList.Items.AddRange(new object[] {
            "Mandatory tasks:",
            "Teambuilding at 9 o\'clock.",
            "Send an e-mail to Petro about done work at 19 o\'clock."});
            this.MandatoryToDoList.Location = new System.Drawing.Point(5, 5);
            this.MandatoryToDoList.Name = "MandatoryToDoList";
            this.MandatoryToDoList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.MandatoryToDoList.Size = new System.Drawing.Size(640, 64);
            this.MandatoryToDoList.TabIndex = 0;
            this.MandatoryToDoList.SelectedIndexChanged += new System.EventHandler(this.MandatoryToDoList_SelectedIndexChanged);
            // 
            // ToDoList
            // 
            this.ToDoList.Font = new System.Drawing.Font("Barlow Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToDoList.FormattingEnabled = true;
            this.ToDoList.ItemHeight = 20;
            this.ToDoList.Location = new System.Drawing.Point(5, 68);
            this.ToDoList.Name = "ToDoList";
            this.ToDoList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ToDoList.Size = new System.Drawing.Size(640, 244);
            this.ToDoList.TabIndex = 1;
            this.ToDoList.SelectedIndexChanged += new System.EventHandler(this.ToDoList_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Barlow Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(5, 317);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(96, 30);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Task";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Barlow Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(107, 317);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 30);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save Tasks";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Barlow Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(209, 317);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(96, 30);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete Task";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClearAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClearAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllButton.Font = new System.Drawing.Font("Barlow Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearAllButton.Location = new System.Drawing.Point(311, 317);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(96, 30);
            this.ClearAllButton.TabIndex = 5;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = false;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Silver;
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.QuitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Barlow Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuitButton.Location = new System.Drawing.Point(549, 317);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(96, 30);
            this.QuitButton.TabIndex = 6;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // AddToDoListTextBox
            // 
            this.AddToDoListTextBox.Font = new System.Drawing.Font("Barlow Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddToDoListTextBox.Location = new System.Drawing.Point(5, 353);
            this.AddToDoListTextBox.Name = "AddToDoListTextBox";
            this.AddToDoListTextBox.PlaceholderText = "Write a task and click \'Add Task\'";
            this.AddToDoListTextBox.Size = new System.Drawing.Size(640, 25);
            this.AddToDoListTextBox.TabIndex = 7;
            this.AddToDoListTextBox.TextChanged += new System.EventHandler(this.AddToDoListTextBox_TextChanged);
            // 
            // ToDoListApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 383);
            this.Controls.Add(this.AddToDoListTextBox);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ToDoList);
            this.Controls.Add(this.MandatoryToDoList);
            this.MaximumSize = new System.Drawing.Size(666, 422);
            this.MinimumSize = new System.Drawing.Size(666, 422);
            this.Name = "ToDoListApp";
            this.Text = "To Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox MandatoryToDoList;
        private ListBox ToDoList;
        private Button AddButton;
        private Button SaveButton;
        private Button DeleteButton;
        private Button ClearAllButton;
        private Button QuitButton;
        private TextBox AddToDoListTextBox;
    }
}