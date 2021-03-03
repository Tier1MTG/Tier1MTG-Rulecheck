
namespace Rulecheck
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._value = new System.Windows.Forms.TextBox();
            this._cmprice = new System.Windows.Forms.ComboBox();
            this._valueModifier = new System.Windows.Forms.ComboBox();
            this._valueSelector = new System.Windows.Forms.ComboBox();
            this._blockset = new System.Windows.Forms.TreeView();
            this._apply = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._updatesingles = new System.Windows.Forms.Button();
            this._single = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // _value
            // 
            this._value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._value.Location = new System.Drawing.Point(376, 394);
            this._value.Name = "_value";
            this._value.Size = new System.Drawing.Size(279, 26);
            this._value.TabIndex = 0;
            this._value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._value.TextChanged += new System.EventHandler(this._value_TextChanged);
            // 
            // _cmprice
            // 
            this._cmprice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmprice.FormattingEnabled = true;
            this._cmprice.Items.AddRange(new object[] {
            "Cheapest Seller",
            "Most Expensive Seller",
            "Trend Price"});
            this._cmprice.Location = new System.Drawing.Point(376, 494);
            this._cmprice.Name = "_cmprice";
            this._cmprice.Size = new System.Drawing.Size(277, 28);
            this._cmprice.TabIndex = 1;
            this._cmprice.SelectedIndexChanged += new System.EventHandler(this._cmprice_SelectedIndexChanged);
            // 
            // _valueModifier
            // 
            this._valueModifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._valueModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._valueModifier.FormattingEnabled = true;
            this._valueModifier.Items.AddRange(new object[] {
            "OVER",
            "UNDER"});
            this._valueModifier.Location = new System.Drawing.Point(376, 460);
            this._valueModifier.Name = "_valueModifier";
            this.helpProvider1.SetShowHelp(this._valueModifier, true);
            this._valueModifier.Size = new System.Drawing.Size(277, 28);
            this._valueModifier.TabIndex = 2;
            this._valueModifier.SelectedIndexChanged += new System.EventHandler(this._valueModifier_SelectedIndexChanged);
            // 
            // _valueSelector
            // 
            this._valueSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._valueSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._valueSelector.FormattingEnabled = true;
            this._valueSelector.Items.AddRange(new object[] {
            "%",
            "FLAT"});
            this._valueSelector.Location = new System.Drawing.Point(376, 426);
            this._valueSelector.Name = "_valueSelector";
            this._valueSelector.Size = new System.Drawing.Size(277, 28);
            this._valueSelector.TabIndex = 5;
            this._valueSelector.SelectedIndexChanged += new System.EventHandler(this._valueSelector_SelectedIndexChanged);
            // 
            // _blockset
            // 
            this._blockset.CheckBoxes = true;
            this._blockset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this._blockset.FullRowSelect = true;
            this._blockset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._blockset.Location = new System.Drawing.Point(12, 12);
            this._blockset.Name = "_blockset";
            this._blockset.Size = new System.Drawing.Size(357, 554);
            this._blockset.TabIndex = 6;
            this._blockset.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this._blockset_AfterCheck);
            // 
            // _apply
            // 
            this._apply.Location = new System.Drawing.Point(376, 528);
            this._apply.Name = "_apply";
            this._apply.Size = new System.Drawing.Size(277, 38);
            this._apply.TabIndex = 7;
            this._apply.Text = "Accepter";
            this._apply.UseVisualStyleBackColor = true;
            this._apply.Click += new System.EventHandler(this._apply_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // _updatesingles
            // 
            this._updatesingles.Location = new System.Drawing.Point(375, 352);
            this._updatesingles.Name = "_updatesingles";
            this._updatesingles.Size = new System.Drawing.Size(499, 23);
            this._updatesingles.TabIndex = 8;
            this._updatesingles.Text = "Opdatér Singles-tabel";
            this._updatesingles.UseVisualStyleBackColor = true;
            this._updatesingles.Click += new System.EventHandler(this._updatesingles_Click);
            // 
            // _single
            // 
            this._single.CheckBoxes = true;
            this._single.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this._single.Location = new System.Drawing.Point(374, 12);
            this._single.Name = "_single";
            this._single.ShowNodeToolTips = true;
            this._single.ShowPlusMinus = false;
            this._single.ShowRootLines = false;
            this._single.Size = new System.Drawing.Size(500, 334);
            this._single.TabIndex = 9;
            this._single.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this._single_AfterCheck);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 578);
            this.Controls.Add(this._single);
            this.Controls.Add(this._updatesingles);
            this.Controls.Add(this._apply);
            this.Controls.Add(this._blockset);
            this.Controls.Add(this._valueSelector);
            this.Controls.Add(this._valueModifier);
            this.Controls.Add(this._cmprice);
            this.Controls.Add(this._value);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _value;
        private System.Windows.Forms.ComboBox _cmprice;
        private System.Windows.Forms.ComboBox _valueModifier;
        private System.Windows.Forms.ComboBox _valueSelector;
        private System.Windows.Forms.TreeView _blockset;
        private System.Windows.Forms.Button _apply;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button _updatesingles;
        private System.Windows.Forms.TreeView _single;
    }
}

