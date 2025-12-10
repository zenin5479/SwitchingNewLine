using System;
using System.Windows.Forms;

namespace SwitchingNewLine
{
   public partial class FormOne : Form
   {
      public FormOne()
      {
         InitializeComponent();
      }

      private void ButtonTextBox_Click(object sender, System.EventArgs e)
      {
         string one = "Первая строка:";
         string two = "Вторая строка:";
         string three = "Третья строка:";
         string four = "Четвертая строка:";

         // Вывод значения разных переменных
         string linefour = string.Format("Значения переменных: double - {0:f4}; int - {1}; bool - {2};", 8.1234, 25, false);
         TextBoxReader.AppendText(one);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.AppendText(two);
         TextBoxReader.AppendText(Environment.NewLine);

         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.AppendText(three);
         TextBoxReader.AppendText(Environment.NewLine);

         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.AppendText(four);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.AppendText(linefour);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.ScrollToCaret();
      }

      private void ButtonListBox_Click(object sender, System.EventArgs e)
      {
         string one = "Первая строка:";
         string two = "Вторая строка:";
         string three = "Третья строка:";
         string four = "Четвертая строка:";

         // Вывод значения разных переменных
         string linefour = string.Format("Значения переменных: double - {0:f4}; int - {1}; bool - {2};", 8.1234, 25, false);


         ListBoxReader.Items.Add(one);

         ListBoxReader.Items.Add(two);

         ListBoxReader.Items.Add(three);

         ListBoxReader.Items.Add(four);
         ListBoxReader.Items.Add(linefour);
         // Прокрутка ListBox вниз
         ListBoxReader.TopIndex = ListBoxReader.Items.Count - 1;

      }

      private void ButtonRichTextBox_Click(object sender, System.EventArgs e)
      {
         string one = "Первая строка:";
         string two = "Вторая строка:";
         string three = "Третья строка:";
         string four = "Четвертая строка:";

         // Вывод значения разных переменных
         string linefour = string.Format("Значения переменных: double - {0:f4}; int - {1}; bool - {2};", 8.1234, 25, false);

         RichTextBoxReader.AppendText(one);
         RichTextBoxReader.AppendText(Environment.NewLine);

         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.AppendText(two);
         RichTextBoxReader.AppendText(Environment.NewLine);

         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.AppendText(three);
         RichTextBoxReader.AppendText(Environment.NewLine);

         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.AppendText(four);
         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.AppendText(linefour);
         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.ScrollToCaret();
      }

      private void ButtonClear_Click(object sender, EventArgs e)
      {
         TextBoxReader.Clear();
         RichTextBoxReader.Clear();
         ListBoxReader.Items.Clear();
      }
   }
}