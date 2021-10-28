using System;
using System.IO;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        Variable[] P;
        int C = 0;
        public Form1()
        {
            InitializeComponent();
            P = new Variable[10];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter archivo = new StreamWriter(Path.Combine(dialogo.FileName)))

                for (int i = 0; i < P.Length; i++)
                {
                        if (P[i] !=null)
                        {
                         archivo.WriteLineAsync(P[i].ToString());
                        }
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
                var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Variable m = new Variable();
            m.Nombre = txtNombre.Text;
            m.matricula = (txtMatricula.Text);

            P[C] = m;
            ListArreglo.Items.Add(P[C]);

            C++;

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
