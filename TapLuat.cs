using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decision_Tree_ID3
{
    public partial class TapLuat : Form
    {
        public TapLuat()
        {
            InitializeComponent();
        }

        private void ShowRules(Node3 decisionTree, bool start, string rule)
        {
            string temp = "";
            if (start)
            {
                rule += "IF (" + decisionTree.name + "=";
            }
            else
                rule += "^ (" + decisionTree.name + "=";
            temp = rule;
            for (int i = 0; i < decisionTree.arrNodes.Count(); i++)
            {
                rule += decisionTree.arrNodes[i].name + ") ";
                Node3 node3 = decisionTree.arrNodes[i];
                if (node3.value == null) //nếu giá trị của Attribute ko chứa node lá => chứa 1 node Attribute khác(node nhánh)
                {
                    ShowRules(node3.arrNodes[0], false, rule);
                    rule = temp;
                }
                else
                {
                    //rule += "THEN " + arrClause[arrClause.Count - 1] + "=" + node3.value + "\r\n";
                    //txtID3_Algorithm.Text += rule;
                    //rule = temp;
                }
            }

            //private void TapLuat_Load(object sender, EventArgs e)
            //{

            //}
        }
    }
}
