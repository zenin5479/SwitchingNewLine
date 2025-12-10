namespace SwitchingNewLine
{
   partial class FormOne
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         ButtonRichTextBox = new System.Windows.Forms.Button();
         ButtonClear = new System.Windows.Forms.Button();
         ButtonListBox = new System.Windows.Forms.Button();
         RichTextBoxReader = new System.Windows.Forms.RichTextBox();
         ListBoxReader = new System.Windows.Forms.ListBox();
         ButtonTextBox = new System.Windows.Forms.Button();
         TextBoxReader = new System.Windows.Forms.TextBox();
         SuspendLayout();
         // 
         // ButtonRichTextBox
         // 
         ButtonRichTextBox.Location = new System.Drawing.Point(204, 12);
         ButtonRichTextBox.Name = "ButtonRichTextBox";
         ButtonRichTextBox.Size = new System.Drawing.Size(110, 23);
         ButtonRichTextBox.TabIndex = 14;
         ButtonRichTextBox.Text = "RichTextBox";
         ButtonRichTextBox.UseVisualStyleBackColor = true;
         // 
         // ButtonClear
         // 
         ButtonClear.Location = new System.Drawing.Point(668, 12);
         ButtonClear.Name = "ButtonClear";
         ButtonClear.Size = new System.Drawing.Size(90, 23);
         ButtonClear.TabIndex = 13;
         ButtonClear.Text = "Clear";
         ButtonClear.UseVisualStyleBackColor = true;
         // 
         // ButtonListBox
         // 
         ButtonListBox.Location = new System.Drawing.Point(108, 12);
         ButtonListBox.Name = "ButtonListBox";
         ButtonListBox.Size = new System.Drawing.Size(90, 23);
         ButtonListBox.TabIndex = 12;
         ButtonListBox.Text = "ListBox";
         ButtonListBox.UseVisualStyleBackColor = true;
         // 
         // RichTextBoxReader
         // 
         RichTextBoxReader.Location = new System.Drawing.Point(12, 227);
         RichTextBoxReader.Name = "RichTextBoxReader";
         RichTextBoxReader.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
         RichTextBoxReader.Size = new System.Drawing.Size(370, 180);
         RichTextBoxReader.TabIndex = 11;
         RichTextBoxReader.Text = "";
         // 
         // ListBoxReader
         // 
         ListBoxReader.FormattingEnabled = true;
         ListBoxReader.ItemHeight = 15;
         ListBoxReader.Location = new System.Drawing.Point(388, 41);
         ListBoxReader.Name = "ListBoxReader";
         ListBoxReader.ScrollAlwaysVisible = true;
         ListBoxReader.Size = new System.Drawing.Size(370, 184);
         ListBoxReader.TabIndex = 10;
         // 
         // ButtonTextBox
         // 
         ButtonTextBox.Location = new System.Drawing.Point(12, 12);
         ButtonTextBox.Name = "ButtonTextBox";
         ButtonTextBox.Size = new System.Drawing.Size(90, 23);
         ButtonTextBox.TabIndex = 9;
         ButtonTextBox.Text = "TextBox";
         ButtonTextBox.UseVisualStyleBackColor = true;
         // 
         // TextBoxReader
         // 
         TextBoxReader.Location = new System.Drawing.Point(12, 41);
         TextBoxReader.Multiline = true;
         TextBoxReader.Name = "TextBoxReader";
         TextBoxReader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         TextBoxReader.Size = new System.Drawing.Size(370, 180);
         TextBoxReader.TabIndex = 8;
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(771, 419);
         Controls.Add(ButtonRichTextBox);
         Controls.Add(ButtonClear);
         Controls.Add(ButtonListBox);
         Controls.Add(RichTextBoxReader);
         Controls.Add(ListBoxReader);
         Controls.Add(ButtonTextBox);
         Controls.Add(TextBoxReader);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Переход на новую строку";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Button ButtonRichTextBox;
      private System.Windows.Forms.Button ButtonClear;
      private System.Windows.Forms.Button ButtonListBox;
      private System.Windows.Forms.RichTextBox RichTextBoxReader;
      private System.Windows.Forms.ListBox ListBoxReader;
      private System.Windows.Forms.Button ButtonTextBox;
      private System.Windows.Forms.TextBox TextBoxReader;
   }
}