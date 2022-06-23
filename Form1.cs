using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class VectorForm : Form
    {

        public VectorForm()
        {
            InitializeComponent();
        }
        public NumericUpDown GetVectorDimension()
        {
            return VectorDimension;
        }
        private NumericUpDown[] numb;
        private Vector Vector1;

        private void Addbtn_Click(object sender, EventArgs e) //введення другого вектора
        {
            Vector1 = createVector();
            VectorDimension.Enabled = false;
            for (int i = 0; i < (int)VectorDimension.Value; i++)
            {
                ((NumericUpDown)numb[i]).Value = 0;
            }

        }

        private void AddEqualBtn_Click(object sender, EventArgs e) //додавання векторів
        {
            decimal[] Cords = new decimal[(int)VectorDimension.Value];
            for (int i = 0; i < Cords.Length; i++)
            {
                Cords[i] = ((NumericUpDown)numb[i]).Value + Vector1.Cords[i];
            }
            for (int i = 0; i < Cords.Length; i++)
            {
                ((NumericUpDown)numb[i]).Value = Cords[i];
            }
            VectorDimension.Enabled = true;

        }

        private void VectorForm_Shown(object sender, EventArgs e) 
        {
            for (int i = 0; i < 5; i++)
            {
                ((NumericUpDown)numb[i]).Visible = (int)VectorDimension.Value > i; ;
            }
            for (int i = 0; i < (int)VectorDimension.Value; i++)
            {
                ((NumericUpDown)numb[i]).Value = 0;
            }

        }

        private void VectorForm_Load(object sender, EventArgs e)
        {
            numb = new NumericUpDown[5] { numericUpDown0, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4 };
        }

        private void VectorDimension_ValueChanged(object sender, EventArgs e)
        {
            VectorForm_Shown(sender, e);
        }
        private Vector createVector()
        {
            decimal[] Cords = new decimal[(int)VectorDimension.Value];
            for (int i = 0; i < Cords.Length; i++)
            {
                Cords[i] = ((NumericUpDown)numb[i]).Value;
            }
            return new Vector((int)VectorDimension.Value, Cords);
        }
        private void outputVector(Vector Vector1)
        {
            for (int i = 0; i < 5; i++)
            {
                ((NumericUpDown)numb[i]).Value = 0;
                ((NumericUpDown)numb[i]).Visible = Vector1.Dimension > i; ;
            }
            for (int i = 0; i < Vector1.Dimension; i++)
            {
                ((NumericUpDown)numb[i]).Value = Vector1.Cords[i];
            }
            VectorDimension.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           outputVector((Vector1.MinusVector(createVector())));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            scalarSB.Value = Vector1.MultiVector(createVector());
        }


        private void LengthButton_Click(object sender, EventArgs e)
        {
            scalarSB.Value = createVector().lengthVector();
        }

        private void MulticonstButton_Click(object sender, EventArgs e)
        {
            outputVector(createVector().multConst(xConst.Value));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            createVector().SaveVector();
        }
        
        private void LoadBtn_Click(object sender, EventArgs e)
        {
        
            outputVector(createVector().LoadVector());
        }

        
    }
}

