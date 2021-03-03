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

        string[] blockset; //Blockset consists of an array of set abbreviations.
        string[] single;
        int value = -0;
        string valueSelector = "";
        string valueModifier = "";
        string[] cmprice = new string[2];
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

                    treeNode.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
                        treeNodeChild
                    });

                }

            }
   
        }

        private void _blockset_AfterCheck(object sender, TreeViewEventArgs e)
        {

            List<string> selectedNodesList = new List<string>();

            foreach(TreeNode tn in _blockset.Nodes)
            {
                foreach(TreeNode tnc in tn.Nodes)
                {
                    if (tnc.Checked)
                    {
                        selectedNodesList.Add(tnc.Name);
                    }
                }
            }

            blockset = selectedNodesList.ToArray();

        }

        private void _single_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _value_TextChanged(object sender, EventArgs e)
        {

            value = -0;

            int number;

            bool success = Int32.TryParse(_value.Text, out number);

            if (success)
            {
                value = number;
                Console.WriteLine(value);
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
                case "Follow Seller":
                    cmprice[0] = _cmprice.Text;
                    //TODO: Alert for input to cmprice[1]
                    break;

                default:
                    cmprice[0] = _cmprice.Text;
                    break;
            }
        }

        private void _apply_Click(object sender, EventArgs e)
        {
            Console.WriteLine(blockset+" - "+single+" - "+value+" - "+valueSelector+" - "+valueModifier+" - "+cmprice[0]);
        }

    }

}
