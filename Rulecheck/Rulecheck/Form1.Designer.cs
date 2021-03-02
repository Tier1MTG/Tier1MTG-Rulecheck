
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
            this._value = new System.Windows.Forms.TextBox();
            this._cmprice = new System.Windows.Forms.ComboBox();
            this._valueModifier = new System.Windows.Forms.ComboBox();
            this._single = new System.Windows.Forms.CheckedListBox();
            this._blockset = new System.Windows.Forms.CheckedListBox();
            this._valueSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _value
            // 
            this._value.Location = new System.Drawing.Point(693, 196);
            this._value.Name = "_value";
            this._value.Size = new System.Drawing.Size(35, 20);
            this._value.TabIndex = 0;
            this._value.TextChanged += new System.EventHandler(this._value_TextChanged);
            // 
            // _cmprice
            // 
            this._cmprice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmprice.FormattingEnabled = true;
            this._cmprice.Items.AddRange(new object[] {
            "Cheapest Seller",
            "Most Expensive Seller",
            "Trend Price",
            "Follow Seller"});
            this._cmprice.Location = new System.Drawing.Point(471, 195);
            this._cmprice.Name = "_cmprice";
            this._cmprice.Size = new System.Drawing.Size(175, 21);
            this._cmprice.TabIndex = 1;
            this._cmprice.SelectedIndexChanged += new System.EventHandler(this._cmprice_TextUpdate);
            // 
            // _valueModifier
            // 
            this._valueModifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._valueModifier.FormattingEnabled = true;
            this._valueModifier.Items.AddRange(new object[] {
            "Over",
            "Under"});
            this._valueModifier.Location = new System.Drawing.Point(365, 195);
            this._valueModifier.Name = "_valueModifier";
            this._valueModifier.Size = new System.Drawing.Size(100, 21);
            this._valueModifier.TabIndex = 2;
            this._valueModifier.TextUpdate += new System.EventHandler(this._valueModifier_TextUpdate);
            // 
            // _single
            // 
            this._single.FormattingEnabled = true;
            this._single.Location = new System.Drawing.Point(239, 195);
            this._single.Name = "_single";
            this._single.Size = new System.Drawing.Size(120, 94);
            this._single.TabIndex = 3;
            // 
            // _blockset
            // 
            this._blockset.FormattingEnabled = true;
            this._blockset.Location = new System.Drawing.Point(113, 195);
            this._blockset.Name = "_blockset";
            this._blockset.Size = new System.Drawing.Size(120, 94);
            this._blockset.TabIndex = 4;
            // 
            // _valueSelector
            // 
            this._valueSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._valueSelector.FormattingEnabled = true;
            this._valueSelector.Items.AddRange(new object[] {
            "%",
            "+",
            "-"});
            this._valueSelector.Location = new System.Drawing.Point(652, 195);
            this._valueSelector.Name = "_valueSelector";
            this._valueSelector.Size = new System.Drawing.Size(35, 21);
            this._valueSelector.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 578);
            this.Controls.Add(this._valueSelector);
            this.Controls.Add(this._blockset);
            this.Controls.Add(this._single);
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
        private System.Windows.Forms.CheckedListBox _single;
        private System.Windows.Forms.CheckedListBox _blockset;
        private System.Windows.Forms.ComboBox _valueSelector;
    }
}

