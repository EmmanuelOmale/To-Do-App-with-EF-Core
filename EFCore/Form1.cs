using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFCore.Models;
using EFCore.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFCore;

public partial class Form1 : Form
{
    Context context = new Context();    
    public Form1()
    {
        InitializeComponent();
        Display();
    }

    private void Display()
    {
        var getTodos = context.Todos.Select(x => x).ToList();
        dataGridView1.DataSource = getTodos;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
    private void TaskID_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

    private void button2_Click(object sender, EventArgs e) 
    {
        DialogResult result = MessageBox.Show("Are you sure you want to update todo?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {

            int idToUpdate = Convert.ToInt32(TaskID.SelectedItem);
            var todo = context.Todos.FirstOrDefault(x => x.Id == idToUpdate);

            if (todo != null)
            {
                todo.TaaskTitle = TaskTitlebtn.Text;
                todo.TaaskDescription = TaskDesbtn.Text;
                todo.ScheduledDate = DateTime.Parse(dateTimePicker1.Text);
                todo.CompletionDate = DateTime.Parse(dateTimePicker2.Text);

                context.SaveChanges();
                MessageBox.Show("Successfully updated");
                Display();
            }
            else
            {
                MessageBox.Show("Todo not found");
            }
        }
    }
    private void Form1_Load(object sender, EventArgs e)
    { 
        SelectId();        
    }
    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
    }
    private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
    {
    }

    private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
    {

    }
    public void SelectId()
    {
        var ids = context.Todos.Select(x => x.Id);
        TaskID.Items.Clear();
        foreach (var id in ids)
        {
            TaskID.Items.Add(id);
        }
    }
    public void DeleteItem()
    {
        DialogResult result = MessageBox.Show("Are you sure you want to delete todo?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {

            try
            {
                var id = context.Todos.Find((int)TaskID.SelectedItem);
                if (id != null)
                {
                    context.Todos.Remove(id);
                    TaskID.Items.Remove(id.ToString());
                    context.SaveChanges();

                    Display();
                }
                MessageBox.Show("Todo deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

    private void button3_Click(object sender, EventArgs e)
    {
        DeleteItem();               
    }

    private void button4_Click(object sender, EventArgs e)
    {
        Todo todo = new Todo()
        {
            TaaskTitle = TaskTitlebtn.Text,
            TaaskDescription = TaskDesbtn.Text,
            ScheduledDate = DateTime.Parse(dateTimePicker1.Text),
            CompletionDate = DateTime.Parse(dateTimePicker2.Text),
        };

        context.Todos.Add(todo);
        context.SaveChanges();
        MessageBox.Show("Successfully saved");
        Display();

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
        string search = SearchTextbox.Text;
        var searchResult = context.Todos.Where(x => x.TaaskTitle.Contains(search)).ToList();
        dataGridView1.DataSource = searchResult;
        
    }

    private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void label8_Click(object sender, EventArgs e)
    {

    }    
}

