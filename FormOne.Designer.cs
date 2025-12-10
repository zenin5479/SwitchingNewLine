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
         ButtonHttpWebRequest = new System.Windows.Forms.Button();
         ButtonClear = new System.Windows.Forms.Button();
         ButtonWebRequest = new System.Windows.Forms.Button();
         RichTextBoxReader = new System.Windows.Forms.RichTextBox();
         ListBoxReader = new System.Windows.Forms.ListBox();
         ButtonWebClient = new System.Windows.Forms.Button();
         TextBoxReader = new System.Windows.Forms.TextBox();
         SuspendLayout();
         // 
         // ButtonHttpWebRequest
         // 
         ButtonHttpWebRequest.Location = new System.Drawing.Point(204, 12);
         ButtonHttpWebRequest.Name = "ButtonHttpWebRequest";
         ButtonHttpWebRequest.Size = new System.Drawing.Size(110, 23);
         ButtonHttpWebRequest.TabIndex = 14;
         ButtonHttpWebRequest.Text = "HttpWebRequest";
         ButtonHttpWebRequest.UseVisualStyleBackColor = true;
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
         // ButtonWebRequest
         // 
         ButtonWebRequest.Location = new System.Drawing.Point(108, 12);
         ButtonWebRequest.Name = "ButtonWebRequest";
         ButtonWebRequest.Size = new System.Drawing.Size(90, 23);
         ButtonWebRequest.TabIndex = 12;
         ButtonWebRequest.Text = "WebRequest";
         ButtonWebRequest.UseVisualStyleBackColor = true;
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
         // ButtonWebClient
         // 
         ButtonWebClient.Location = new System.Drawing.Point(12, 12);
         ButtonWebClient.Name = "ButtonWebClient";
         ButtonWebClient.Size = new System.Drawing.Size(90, 23);
         ButtonWebClient.TabIndex = 9;
         ButtonWebClient.Text = "WebClient";
         ButtonWebClient.UseVisualStyleBackColor = true;
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
         Controls.Add(ButtonHttpWebRequest);
         Controls.Add(ButtonClear);
         Controls.Add(ButtonWebRequest);
         Controls.Add(RichTextBoxReader);
         Controls.Add(ListBoxReader);
         Controls.Add(ButtonWebClient);
         Controls.Add(TextBoxReader);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Переход на новую строку";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Button ButtonHttpWebRequest;
      private System.Windows.Forms.Button ButtonClear;
      private System.Windows.Forms.Button ButtonWebRequest;
      private System.Windows.Forms.RichTextBox RichTextBoxReader;
      private System.Windows.Forms.ListBox ListBoxReader;
      private System.Windows.Forms.Button ButtonWebClient;
      private System.Windows.Forms.TextBox TextBoxReader;
   }
}