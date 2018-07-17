namespace TaxCalc
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.priceBox = new System.Windows.Forms.TextBox();
            this.taxpricebox = new System.Windows.Forms.TextBox();
            this.taxcalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(231, 41);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(172, 19);
            this.priceBox.TabIndex = 0;
            // 
            // taxpricebox
            // 
            this.taxpricebox.Enabled = false;
            this.taxpricebox.Location = new System.Drawing.Point(232, 116);
            this.taxpricebox.Name = "taxpricebox";
            this.taxpricebox.Size = new System.Drawing.Size(171, 19);
            this.taxpricebox.TabIndex = 1;
            // 
            // taxcalc
            // 
            this.taxcalc.Location = new System.Drawing.Point(300, 179);
            this.taxcalc.Name = "taxcalc";
            this.taxcalc.Size = new System.Drawing.Size(102, 36);
            this.taxcalc.TabIndex = 2;
            this.taxcalc.Text = "計算する";
            this.taxcalc.UseVisualStyleBackColor = true;
            this.taxcalc.Click += new System.EventHandler(this.taxcalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "税抜価格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "税込価格";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 242);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taxcalc);
            this.Controls.Add(this.taxpricebox);
            this.Controls.Add(this.priceBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox taxpricebox;
        private System.Windows.Forms.Button taxcalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

