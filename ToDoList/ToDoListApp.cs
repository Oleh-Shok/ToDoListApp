namespace ToDoList
{
    public partial class ToDoListApp : Form
    {
        public bool SaveButtonClicked { get; private set; }

        public ToDoListApp()
        {
            InitializeComponent();
            string[] tasks = File.ReadAllLines("tasks.txt");
            foreach (string task in tasks)
            {
                ToDoList.Items.Add(task);
            }
            this.ControlBox = false;
        }

        private void MandatoryToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddToDoListTextBox.Text))
            {
                MessageBox.Show("This field cannot be empty! Please write a task and click 'Add Task' again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ToDoList.Items.Add(AddToDoListTextBox.Text);
            }
            ToDoList.Text = "";
            AddToDoListTextBox.Focus();
            AddToDoListTextBox.Clear();
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            const string sPath = "tasks.txt";

            StreamWriter SaveFile = new(sPath);
            foreach (var item in ToDoList.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();
            MessageBox.Show("Tasks saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SaveButtonClicked = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            for (int i = ToDoList.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int idx = ToDoList.SelectedIndices[i];
                ToDoList.Items.RemoveAt(idx);
            }

            for (int i = MandatoryToDoList.SelectedIndices.Count - 1; i >= 0; i--)
            {
                _ = MandatoryToDoList.SelectedIndices[i];
                _ = MessageBox.Show("You can't delete Mandatory task. This task is important. Just do it!", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            ToDoList.Items.Clear();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (!SaveButtonClicked)
            {
                DialogResult result = MessageBox.Show("Are you sure want to quit without saving?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void AddToDoListTextBox_TextChanged(object sender, EventArgs e)
        {

        }        
    }
}