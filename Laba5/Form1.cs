using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

//p(1, 2) = P1 * P2
//p(4, 5) = P4 * P5
//p(6, 8) = P6 * P8
//p(3070) = 1 - (1 - (P1 * P2)) * (1 - (P4 * P5)) * (1 - (P6 * P8))

//p(1, 2) = P1 * P2
//p(4, 6) = 1 - (1 - P4) * (1 - P6)
//p(5, 8) = 1 - (1 - P5) * (1 - P8)
//p(3071) = 1 - (1 - (P1 * P2)) * (1 - ((1 - (1 - P4) * (1 - P6)) * (1 - (1 - P5) * (1 - P8))))

//p(30) = P(7)*P(3071)+(1-P7)*(3070)

//p(1, 4) = 1 - (1 - P1) * (1 - P4)
//p(2, 5) = 1 - (1 - P2) * (1 - P5)
//p(6, 8) = P6 * P8
//p(3170) = 1 - (1 - ((1 - (1 - P1) * (1 - P4)) * (1 - (1 - P2) * (1 - P5)))) * (1 - (P6 * P8))

//p(4, 6) = 1 - (1 - P4) * (1 - P6)
//p(2, 5) = 1 - (1 - P2) * (1 - P5)
//p(3171) = (1 - (1 - P1) * (1 - (1 - (1 - P4) * (1 - P6)))) * (1 - (1 - (1 - (1 - P2) * (1 - P5))) * (1 - P8))

//p(31) = P(7)*P(3171)+(1-P7)*(3170)

//P = P(3)*P(31)+(1-P3)*P(30)