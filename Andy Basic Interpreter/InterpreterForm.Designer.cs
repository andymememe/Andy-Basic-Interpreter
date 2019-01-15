namespace Andy_Basic_Interpreter
{
    partial class InterpreterForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.codeBox = new System.Windows.Forms.RichTextBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codeBox
            // 
            this.codeBox.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBox.Location = new System.Drawing.Point(12, 12);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(486, 388);
            this.codeBox.TabIndex = 0;
            this.codeBox.Text = "print \"Hello, world!\"";
            this.codeBox.WordWrap = false;
            // 
            // runBtn
            // 
            this.runBtn.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.runBtn.Location = new System.Drawing.Point(806, 331);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(109, 69);
            this.runBtn.TabIndex = 2;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.AutoSize = true;
            this.resultBox.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultBox.Location = new System.Drawing.Point(504, 12);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(280, 22);
            this.resultBox.TabIndex = 3;
            this.resultBox.Text = "[Press Run button to run the code]";
            // 
            // InterpreterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 412);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.codeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InterpreterForm";
            this.Text = "Andy Basic Interpreter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox codeBox;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Label resultBox;
    }
}

