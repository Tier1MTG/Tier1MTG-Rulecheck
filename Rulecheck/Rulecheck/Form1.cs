using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Rulecheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

            sql = new SQLQuery();

            Expansion[] expansions = sql.getLookupTable("tier1mtg_mkm_lookup");
            Block[] blocks = createBlocks(expansions);

            insertExpansions(blocks, expansions);
            populateTree(blocks);
            _blockset.ExpandAll();

        }

        TreeNode[] blockset; //Blockset consists of an array of set abbreviations.
        TreeNode[] single; //Singles consist of selected singles.
        int value = -0;
        string valueSelector = "";
        string valueModifier = "";
        string cmprice = "";
        SQLQuery sql;

        /*
        * Function that creates block-objects.
        */
        private Block[] createBlocks(Expansion[] sets)
        {

            Block[] blocks;
            List<Block> blocksList = new List<Block>();

            string[] blockNames = sql.getUniqueBlocks("tier1mtg_mkm_lookup");

            for(int i = 0; i < blockNames.Length; i++)
            {
                string sBlockName = blockNames[i];
                string[] sblockNames = sBlockName.Split('|');
                blocksList.Add(new Block(sblockNames[0], sblockNames[1]));
            }

            blocks = blocksList.ToArray();

            return blocks;

        }

        /*
        * Function that inserts the relevant expansion-objects into their respective blocks.
        */
        private void insertExpansions(Block[] blocks, Expansion[] expansions)
        {

            for(int i = 0; i < expansions.Length; i++)
            {

                string blockAbbr = expansions[i].blockAbbr;

                for (int j = 0; j < blocks.Length; j++)
                {
                    if (blocks[j].blockAbbr == blockAbbr)
                    {
                        blocks[j].addExpansion(expansions[i]);
                    }
                }
            }

        }

        /*
        * Function that populates the tree-view checkbox, with the blocks and expansions
        */
        private void populateTree(Block[] blocks)
        {

            for (int i = 0; i < blocks.Length; i++)
            {
                
                System.Windows.Forms.TreeNode treeNode = new System.Windows.Forms.TreeNode(blocks[i].blockAbbr);
                treeNode.Name = blocks[i].blockAbbr;
                treeNode.Text = blocks[i].blockName;

                _blockset.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
                    treeNode
                });

                for(int j = 0; j < blocks[i].expansions.Length; j++)
                {
                    System.Windows.Forms.TreeNode treeNodeChild = new System.Windows.Forms.TreeNode(blocks[i].expansions[j].expansionAbbr);
                    treeNodeChild.Name = blocks[i].expansions[j].expansionAbbr;
                    treeNodeChild.Text = blocks[i].expansions[j].expansionName;
                    treeNodeChild.Tag = blocks[i].expansions[j].blockAbbr;

                    treeNode.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
                        treeNodeChild
                    });

                }

            }
   
        }

        private void _blockset_AfterCheck(object sender, TreeViewEventArgs e)
        {

            List<TreeNode> selectedNodesList = new List<TreeNode>();
            
            try
            {

                foreach (TreeNode tn in _blockset.Nodes)
                {
                    foreach (TreeNode tnc in tn.Nodes)
                    {
                        if (tnc.Checked)
                        {
                            selectedNodesList.Add(tnc);
                        }
                    }
                }

                blockset = selectedNodesList.ToArray();

            } catch(Exception ex)
            {

            }

        }

        private void _single_AfterCheck(object sender, TreeViewEventArgs e)
        {

            List<TreeNode> selectedNodesList = new List<TreeNode>();

            try
            {
                foreach (TreeNode tn in _single.Nodes)
                {
                    foreach (TreeNode tnc in tn.Nodes)
                    {
                        if (tnc.Checked)
                        {
                            selectedNodesList.Add(tnc);
                        }
                    }
                }

                single = selectedNodesList.ToArray();

                foreach (TreeNode tn in single)
                {

                }

            } catch(Exception ex)
            {

            }

        }

        private void _value_TextChanged(object sender, EventArgs e)
        {

            value = -0;

            int number;

            bool success = Int32.TryParse(_value.Text, out number);

            if (success && value==-0)
            {
                value = number;
            }

        }

        private void _valueSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueSelector = _valueSelector.Text;
        }


        private void _valueModifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueModifier = _valueModifier.Text;
        }

        private void _cmprice_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (_cmprice.Text)
            {

                case "Trend Price":
                    cmprice = "TREND";
                    break;

                case "Cheapest Seller":
                    cmprice = "CHEAP";
                    break;

                case "Most Expensive Seller":
                    cmprice = "EXPENSIVE";
                    break;

                default:
                    break;
            }
        }

        private void _apply_Click(object sender, EventArgs e)
        {
            /*
            string single = "";
            int value = -0;
            string valueSelector = "";
            string valueModifier = "";
            string cmprice = "";
            */

            if (value == -0 || valueSelector == "" || valueModifier == "" || cmprice == "" || blockset.Length < 0)
            {
                //Missing information.
                MessageBox.Show("Error");
            } else
            {
                //Rule succesfull, confirm creation.
            }
        
        }

        private void _updatesingles_Click(object sender, EventArgs e)
        {

            try {

                _single.Nodes.Clear();
                
                foreach (TreeNode tn in blockset)
                {

                    string[] selectedExpansions = sql.getSingles("tier1mtg_mkm_lookup", Convert.ToString(tn.Tag), Convert.ToString(tn.Text));

                    foreach (string s in selectedExpansions)
                    {

                        string[] sSingleNames = s.Split('|');

                        System.Windows.Forms.TreeNode treeNode = new System.Windows.Forms.TreeNode(sSingleNames[0]);
                        treeNode.Name = sSingleNames[0];
                        treeNode.Text = "[" + sSingleNames[2] + "] " + sSingleNames[0];
                        treeNode.Tag = sSingleNames[1];

                        _single.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
                        treeNode
                    });

                    }


                }
            } catch(Exception ex)
            {

            }
            
        }

    }

}
